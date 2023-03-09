namespace DBClient
{
    partial class panelOperations_AddClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.registerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.phoneTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.emailTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.creditTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.balanceTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.managerList = new System.Windows.Forms.ComboBox();
            this.separateLine2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.minimizeButton);
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.appName);
            this.panelHeader.Controls.Add(this.appLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(574, 57);
            this.panelHeader.TabIndex = 3;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::DBClient.Properties.Resources.minimizeIcon;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(477, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(40, 41);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::DBClient.Properties.Resources.closeIcon;
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(523, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 20;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(69, 17);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(381, 32);
            this.appName.TabIndex = 0;
            this.appName.Text = "СУБД - ПРОМЭКЗ - Новый клиент";
            // 
            // appLogo
            // 
            this.appLogo.Image = global::DBClient.Properties.Resources.promekzAppLogo;
            this.appLogo.Location = new System.Drawing.Point(13, 9);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(40, 40);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 0;
            this.appLogo.TabStop = false;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
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
            // registerButton
            // 
            this.registerButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerButton.BorderRadius = 0;
            this.registerButton.ButtonText = "Зарегистрировать клиента";
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.DisabledColor = System.Drawing.Color.Gray;
            this.registerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.registerButton.Iconimage = null;
            this.registerButton.Iconimage_right = null;
            this.registerButton.Iconimage_right_Selected = null;
            this.registerButton.Iconimage_Selected = null;
            this.registerButton.IconMarginLeft = 0;
            this.registerButton.IconMarginRight = 0;
            this.registerButton.IconRightVisible = true;
            this.registerButton.IconRightZoom = 0D;
            this.registerButton.IconVisible = true;
            this.registerButton.IconZoom = 60D;
            this.registerButton.IsTab = false;
            this.registerButton.Location = new System.Drawing.Point(121, 443);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.registerButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.registerButton.OnHoverTextColor = System.Drawing.Color.White;
            this.registerButton.selected = false;
            this.registerButton.Size = new System.Drawing.Size(333, 40);
            this.registerButton.TabIndex = 121;
            this.registerButton.Text = "Зарегистрировать клиента";
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButton.Textcolor = System.Drawing.Color.White;
            this.registerButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.nameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.nameTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.nameTextBox.BorderThickness = 1;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.nameTextBox.isPassword = false;
            this.nameTextBox.Location = new System.Drawing.Point(248, 102);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 35);
            this.nameTextBox.TabIndex = 165;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.phoneTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.phoneTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.phoneTextBox.BorderThickness = 1;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.phoneTextBox.isPassword = false;
            this.phoneTextBox.Location = new System.Drawing.Point(248, 145);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(206, 35);
            this.phoneTextBox.TabIndex = 166;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneTextBox_KeyDown);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.emailTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.emailTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.emailTextBox.BorderThickness = 1;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.emailTextBox.isPassword = false;
            this.emailTextBox.Location = new System.Drawing.Point(248, 188);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(206, 35);
            this.emailTextBox.TabIndex = 167;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTextBox_KeyDown);
            // 
            // creditTextBox
            // 
            this.creditTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.creditTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.creditTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.creditTextBox.BorderThickness = 1;
            this.creditTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.creditTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.creditTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.creditTextBox.isPassword = false;
            this.creditTextBox.Location = new System.Drawing.Point(248, 231);
            this.creditTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(206, 35);
            this.creditTextBox.TabIndex = 168;
            this.creditTextBox.Text = "0";
            this.creditTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.creditTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.creditTextBox_KeyDown);
            this.creditTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creditTextBox_KeyPress);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.balanceTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.balanceTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.balanceTextBox.BorderThickness = 1;
            this.balanceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.balanceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.balanceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.balanceTextBox.isPassword = false;
            this.balanceTextBox.Location = new System.Drawing.Point(248, 274);
            this.balanceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(206, 35);
            this.balanceTextBox.TabIndex = 169;
            this.balanceTextBox.Text = "0";
            this.balanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.balanceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.balanceTextBox_KeyDown);
            this.balanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTextBox_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(116, 109);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(55, 28);
            this.bunifuCustomLabel5.TabIndex = 170;
            this.bunifuCustomLabel5.Text = "Имя:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(116, 152);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 28);
            this.bunifuCustomLabel1.TabIndex = 171;
            this.bunifuCustomLabel1.Text = "Телефон:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(116, 195);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 28);
            this.bunifuCustomLabel2.TabIndex = 172;
            this.bunifuCustomLabel2.Text = "Эл. адрес:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(116, 238);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(81, 28);
            this.bunifuCustomLabel3.TabIndex = 173;
            this.bunifuCustomLabel3.Text = "Кредит:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(116, 281);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(79, 28);
            this.bunifuCustomLabel4.TabIndex = 174;
            this.bunifuCustomLabel4.Text = "Баланс:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(116, 357);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(114, 28);
            this.bunifuCustomLabel6.TabIndex = 175;
            this.bunifuCustomLabel6.Text = "Менеджер:";
            // 
            // managerList
            // 
            this.managerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.managerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.managerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerList.ForeColor = System.Drawing.Color.Gainsboro;
            this.managerList.FormattingEnabled = true;
            this.managerList.Location = new System.Drawing.Point(248, 356);
            this.managerList.Name = "managerList";
            this.managerList.Size = new System.Drawing.Size(206, 28);
            this.managerList.TabIndex = 176;
            // 
            // separateLine2
            // 
            this.separateLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.separateLine2.Location = new System.Drawing.Point(0, -1);
            this.separateLine2.Name = "separateLine2";
            this.separateLine2.Size = new System.Drawing.Size(3, 535);
            this.separateLine2.TabIndex = 177;
            this.separateLine2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox1.Location = new System.Drawing.Point(570, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 535);
            this.pictureBox1.TabIndex = 178;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox2.Location = new System.Drawing.Point(-18, 516);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(590, 3);
            this.pictureBox2.TabIndex = 179;
            this.pictureBox2.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.errorLabel.Location = new System.Drawing.Point(200, 417);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(152, 21);
            this.errorLabel.TabIndex = 180;
            this.errorLabel.Text = "Заполните все поля";
            this.errorLabel.Visible = false;
            // 
            // panelOperations_AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(574, 520);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.separateLine2);
            this.Controls.Add(this.managerList);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelOperations_AddClient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый клиент";
            this.Load += new System.EventHandler(this.panelOperations_AddClient_Load);
            this.VisibleChanged += new System.EventHandler(this.panelOperations_AddClient_VisibleChanged);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private System.Windows.Forms.PictureBox appLogo;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton registerButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox balanceTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox creditTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailTextBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox phoneTextBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ComboBox managerList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox separateLine2;
        private Bunifu.Framework.UI.BunifuCustomLabel errorLabel;
    }
}