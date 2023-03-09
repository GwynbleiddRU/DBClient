namespace DBClient
{
    partial class panelOperations_RemoveStorage
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.separateLine2 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.registerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.headerImportantInfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.headerImportant = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.storageList = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.errorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox2.Location = new System.Drawing.Point(-16, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(590, 3);
            this.pictureBox2.TabIndex = 183;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox1.Location = new System.Drawing.Point(570, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 535);
            this.pictureBox1.TabIndex = 182;
            this.pictureBox1.TabStop = false;
            // 
            // separateLine2
            // 
            this.separateLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.separateLine2.Location = new System.Drawing.Point(0, 0);
            this.separateLine2.Name = "separateLine2";
            this.separateLine2.Size = new System.Drawing.Size(3, 535);
            this.separateLine2.TabIndex = 181;
            this.separateLine2.TabStop = false;
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
            this.panelHeader.TabIndex = 180;
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
            this.appName.Size = new System.Drawing.Size(378, 32);
            this.appName.TabIndex = 0;
            this.appName.Text = "СУБД - ПРОМЭКЗ - Удалить склад";
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
            // registerButton
            // 
            this.registerButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerButton.BorderRadius = 0;
            this.registerButton.ButtonText = "Удалить склад";
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
            this.registerButton.Location = new System.Drawing.Point(121, 212);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.registerButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.registerButton.OnHoverTextColor = System.Drawing.Color.White;
            this.registerButton.selected = false;
            this.registerButton.Size = new System.Drawing.Size(333, 40);
            this.registerButton.TabIndex = 184;
            this.registerButton.Text = "Удалить склад";
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButton.Textcolor = System.Drawing.Color.White;
            this.registerButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
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
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(163, 186);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(275, 21);
            this.bunifuCustomLabel8.TabIndex = 199;
            this.bunifuCustomLabel8.Text = "- обязательные для заполнения поля";
            // 
            // headerImportantInfo
            // 
            this.headerImportantInfo.AutoSize = true;
            this.headerImportantInfo.BackColor = System.Drawing.Color.Transparent;
            this.headerImportantInfo.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerImportantInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.headerImportantInfo.Location = new System.Drawing.Point(123, 184);
            this.headerImportantInfo.Name = "headerImportantInfo";
            this.headerImportantInfo.Size = new System.Drawing.Size(34, 43);
            this.headerImportantInfo.TabIndex = 198;
            this.headerImportantInfo.Text = "*";
            // 
            // headerImportant
            // 
            this.headerImportant.AutoSize = true;
            this.headerImportant.BackColor = System.Drawing.Color.Transparent;
            this.headerImportant.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerImportant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.headerImportant.Location = new System.Drawing.Point(461, 105);
            this.headerImportant.Name = "headerImportant";
            this.headerImportant.Size = new System.Drawing.Size(34, 43);
            this.headerImportant.TabIndex = 200;
            this.headerImportant.Text = "*";
            // 
            // storageList
            // 
            this.storageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.storageList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storageList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storageList.ForeColor = System.Drawing.Color.Gainsboro;
            this.storageList.FormattingEnabled = true;
            this.storageList.Location = new System.Drawing.Point(249, 105);
            this.storageList.Name = "storageList";
            this.storageList.Size = new System.Drawing.Size(206, 28);
            this.storageList.TabIndex = 203;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(117, 105);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(70, 28);
            this.bunifuCustomLabel3.TabIndex = 202;
            this.bunifuCustomLabel3.Text = "Склад:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.errorLabel.Location = new System.Drawing.Point(212, 165);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(123, 21);
            this.errorLabel.TabIndex = 209;
            this.errorLabel.Text = "Выберите склад";
            this.errorLabel.Visible = false;
            // 
            // panelOperations_RemoveStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(574, 287);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.storageList);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.headerImportant);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.headerImportantInfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.separateLine2);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelOperations_RemoveStorage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить склад";
            this.Load += new System.EventHandler(this.panelOperations_RemoveStorage_Load);
            this.VisibleChanged += new System.EventHandler(this.panelOperations_RemoveStorage_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox separateLine2;
        public System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private System.Windows.Forms.PictureBox appLogo;
        private Bunifu.Framework.UI.BunifuFlatButton registerButton;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel headerImportant;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel headerImportantInfo;
        private System.Windows.Forms.ComboBox storageList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel errorLabel;
    }
}