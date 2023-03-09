namespace DBClient
{
    partial class panelAuthorization
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelAuthorization));
            this.authorizeErrorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.infoTextLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.infoLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.authorizeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.separateLine2 = new System.Windows.Forms.PictureBox();
            this.separateLine3 = new System.Windows.Forms.PictureBox();
            this.separateLine = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.infoTextLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableEditAccessLevelLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DBEditAccessLevelLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.infoTextLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.authorizeErrorLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.currentSessionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizeErrorLabel
            // 
            this.authorizeErrorLabel.AutoSize = true;
            this.authorizeErrorLabel.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizeErrorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.authorizeErrorLabel.Location = new System.Drawing.Point(264, 500);
            this.authorizeErrorLabel.Name = "authorizeErrorLabel";
            this.authorizeErrorLabel.Size = new System.Drawing.Size(255, 21);
            this.authorizeErrorLabel.TabIndex = 93;
            this.authorizeErrorLabel.Text = "заполните поля \"логин\" и \"пароль\"";
            this.authorizeErrorLabel.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(177, 322);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(86, 32);
            this.bunifuCustomLabel1.TabIndex = 88;
            this.bunifuCustomLabel1.Text = "Логин:";
            // 
            // infoTextLabel3
            // 
            this.infoTextLabel3.AutoSize = true;
            this.infoTextLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.infoTextLabel3.Location = new System.Drawing.Point(834, 567);
            this.infoTextLabel3.Name = "infoTextLabel3";
            this.infoTextLabel3.Size = new System.Drawing.Size(215, 84);
            this.infoTextLabel3.TabIndex = 83;
            this.infoTextLabel3.Text = "Электронный адрес:\r\nemail@promekz.ru\r\nТел.: 8 (342) 299-83-40";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.infoLabel.Location = new System.Drawing.Point(834, 19);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(198, 252);
            this.infoLabel.TabIndex = 81;
            this.infoLabel.Text = "Регистрация нового\r\nпользователя:\r\n\r\n\r\nДля регистрации\r\nнового аккаунта\r\nобратите" +
    "сь к \r\nсистемному\r\nадминистратору";
            // 
            // authorizeButton
            // 
            this.authorizeButton.ActiveBorderThickness = 1;
            this.authorizeButton.ActiveCornerRadius = 20;
            this.authorizeButton.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.authorizeButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.authorizeButton.ActiveLineColor = System.Drawing.Color.Gainsboro;
            this.authorizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.authorizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("authorizeButton.BackgroundImage")));
            this.authorizeButton.ButtonText = "Авторизоваться";
            this.authorizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorizeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.authorizeButton.IdleBorderThickness = 1;
            this.authorizeButton.IdleCornerRadius = 20;
            this.authorizeButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.authorizeButton.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.authorizeButton.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.authorizeButton.Location = new System.Drawing.Point(257, 529);
            this.authorizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.authorizeButton.Name = "authorizeButton";
            this.authorizeButton.Size = new System.Drawing.Size(262, 66);
            this.authorizeButton.TabIndex = 92;
            this.authorizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authorizeButton.Click += new System.EventHandler(this.authorizeButton_Click);
            // 
            // Avatar
            // 
            this.Avatar.Image = global::DBClient.Properties.Resources.rickAvatar;
            this.Avatar.Location = new System.Drawing.Point(291, 64);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(193, 189);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avatar.TabIndex = 87;
            this.Avatar.TabStop = false;
            // 
            // separateLine2
            // 
            this.separateLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.separateLine2.Image = ((System.Drawing.Image)(resources.GetObject("separateLine2.Image")));
            this.separateLine2.Location = new System.Drawing.Point(816, 341);
            this.separateLine2.Name = "separateLine2";
            this.separateLine2.Size = new System.Drawing.Size(3, 300);
            this.separateLine2.TabIndex = 86;
            this.separateLine2.TabStop = false;
            // 
            // separateLine3
            // 
            this.separateLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.separateLine3.Image = ((System.Drawing.Image)(resources.GetObject("separateLine3.Image")));
            this.separateLine3.Location = new System.Drawing.Point(847, 314);
            this.separateLine3.Name = "separateLine3";
            this.separateLine3.Size = new System.Drawing.Size(200, 3);
            this.separateLine3.TabIndex = 85;
            this.separateLine3.TabStop = false;
            // 
            // separateLine
            // 
            this.separateLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.separateLine.Image = ((System.Drawing.Image)(resources.GetObject("separateLine.Image")));
            this.separateLine.Location = new System.Drawing.Point(816, 19);
            this.separateLine.Name = "separateLine";
            this.separateLine.Size = new System.Drawing.Size(3, 271);
            this.separateLine.TabIndex = 84;
            this.separateLine.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(177, 410);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 32);
            this.bunifuCustomLabel2.TabIndex = 91;
            this.bunifuCustomLabel2.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordTextBox.HintForeColor = System.Drawing.Color.Gainsboro;
            this.passwordTextBox.HintText = "";
            this.passwordTextBox.isPassword = true;
            this.passwordTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.passwordTextBox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.passwordTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.passwordTextBox.LineThickness = 3;
            this.passwordTextBox.Location = new System.Drawing.Point(291, 377);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(294, 65);
            this.passwordTextBox.TabIndex = 95;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.OnValueChanged += new System.EventHandler(this.passwordTextBox_OnValueChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginTextBox.HintForeColor = System.Drawing.Color.Gainsboro;
            this.loginTextBox.HintText = "";
            this.loginTextBox.isPassword = false;
            this.loginTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.loginTextBox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.loginTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.loginTextBox.LineThickness = 3;
            this.loginTextBox.Location = new System.Drawing.Point(291, 289);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(294, 65);
            this.loginTextBox.TabIndex = 94;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
            // 
            // infoTextLabel4
            // 
            this.infoTextLabel4.AutoSize = true;
            this.infoTextLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.infoTextLabel4.Location = new System.Drawing.Point(834, 410);
            this.infoTextLabel4.Name = "infoTextLabel4";
            this.infoTextLabel4.Size = new System.Drawing.Size(168, 56);
            this.infoTextLabel4.TabIndex = 96;
            this.infoTextLabel4.Text = "Редактирование \r\nтаблиц:\r\n";
            this.infoTextLabel4.Visible = false;
            // 
            // tableEditAccessLevelLabel
            // 
            this.tableEditAccessLevelLabel.AutoSize = true;
            this.tableEditAccessLevelLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableEditAccessLevelLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.tableEditAccessLevelLabel.Location = new System.Drawing.Point(917, 438);
            this.tableEditAccessLevelLabel.Name = "tableEditAccessLevelLabel";
            this.tableEditAccessLevelLabel.Size = new System.Drawing.Size(101, 28);
            this.tableEditAccessLevelLabel.TabIndex = 97;
            this.tableEditAccessLevelLabel.Text = "Доступно\r\n";
            this.tableEditAccessLevelLabel.Visible = false;
            // 
            // DBEditAccessLevelLabel
            // 
            this.DBEditAccessLevelLabel.AutoSize = true;
            this.DBEditAccessLevelLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBEditAccessLevelLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DBEditAccessLevelLabel.Location = new System.Drawing.Point(917, 505);
            this.DBEditAccessLevelLabel.Name = "DBEditAccessLevelLabel";
            this.DBEditAccessLevelLabel.Size = new System.Drawing.Size(101, 28);
            this.DBEditAccessLevelLabel.TabIndex = 99;
            this.DBEditAccessLevelLabel.Text = "Доступно\r\n";
            this.DBEditAccessLevelLabel.Visible = false;
            // 
            // infoTextLabel5
            // 
            this.infoTextLabel5.AutoSize = true;
            this.infoTextLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextLabel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.infoTextLabel5.Location = new System.Drawing.Point(834, 477);
            this.infoTextLabel5.Name = "infoTextLabel5";
            this.infoTextLabel5.Size = new System.Drawing.Size(183, 56);
            this.infoTextLabel5.TabIndex = 98;
            this.infoTextLabel5.Text = "Управление базой\r\nданных:\r\n";
            this.infoTextLabel5.Visible = false;
            // 
            // authorizeErrorLabel2
            // 
            this.authorizeErrorLabel2.AutoSize = true;
            this.authorizeErrorLabel2.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizeErrorLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.authorizeErrorLabel2.Location = new System.Drawing.Point(264, 503);
            this.authorizeErrorLabel2.Name = "authorizeErrorLabel2";
            this.authorizeErrorLabel2.Size = new System.Drawing.Size(239, 21);
            this.authorizeErrorLabel2.TabIndex = 101;
            this.authorizeErrorLabel2.Text = "неправильный логин или пароль";
            this.authorizeErrorLabel2.Visible = false;
            // 
            // currentSessionLabel
            // 
            this.currentSessionLabel.AutoSize = true;
            this.currentSessionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.currentSessionLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.currentSessionLabel.Location = new System.Drawing.Point(834, 341);
            this.currentSessionLabel.Name = "currentSessionLabel";
            this.currentSessionLabel.Size = new System.Drawing.Size(12, 28);
            this.currentSessionLabel.TabIndex = 103;
            this.currentSessionLabel.Text = "\r\n";
            this.currentSessionLabel.Visible = false;
            // 
            // panelAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.currentSessionLabel);
            this.Controls.Add(this.authorizeErrorLabel2);
            this.Controls.Add(this.DBEditAccessLevelLabel);
            this.Controls.Add(this.infoTextLabel5);
            this.Controls.Add(this.tableEditAccessLevelLabel);
            this.Controls.Add(this.infoTextLabel4);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.authorizeErrorLabel);
            this.Controls.Add(this.authorizeButton);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.separateLine2);
            this.Controls.Add(this.separateLine3);
            this.Controls.Add(this.separateLine);
            this.Controls.Add(this.infoTextLabel3);
            this.Controls.Add(this.infoLabel);
            this.Name = "panelAuthorization";
            this.Size = new System.Drawing.Size(1069, 677);
            this.VisibleChanged += new System.EventHandler(this.Authorization_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel authorizeErrorLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 authorizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.PictureBox separateLine2;
        private System.Windows.Forms.PictureBox separateLine3;
        private System.Windows.Forms.PictureBox separateLine;
        private Bunifu.Framework.UI.BunifuCustomLabel infoTextLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel infoLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox loginTextBox;
        public Bunifu.Framework.UI.BunifuCustomLabel infoTextLabel4;
        public Bunifu.Framework.UI.BunifuCustomLabel tableEditAccessLevelLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel DBEditAccessLevelLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel infoTextLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel authorizeErrorLabel2;
        public Bunifu.Framework.UI.BunifuCustomLabel currentSessionLabel;
    }
}
