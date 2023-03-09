namespace DBClient
{
    partial class info_QueryBuilder
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
            this.separateLine3 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.separateLine = new System.Windows.Forms.PictureBox();
            this.separateLine2 = new System.Windows.Forms.PictureBox();
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.infoText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine3)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).BeginInit();
            this.SuspendLayout();
            // 
            // separateLine3
            // 
            this.separateLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.separateLine3.Location = new System.Drawing.Point(696, 6);
            this.separateLine3.Name = "separateLine3";
            this.separateLine3.Size = new System.Drawing.Size(3, 510);
            this.separateLine3.TabIndex = 183;
            this.separateLine3.TabStop = false;
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
            this.panelHeader.Size = new System.Drawing.Size(698, 57);
            this.panelHeader.TabIndex = 181;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::DBClient.Properties.Resources.minimizeIcon;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(598, 8);
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
            this.exitButton.Location = new System.Drawing.Point(644, 8);
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
            this.appName.Size = new System.Drawing.Size(471, 32);
            this.appName.TabIndex = 0;
            this.appName.Text = "СУБД - ПРОМЭКЗ - Конструктор запросов";
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
            // separateLine
            // 
            this.separateLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.separateLine.Location = new System.Drawing.Point(2, 515);
            this.separateLine.Name = "separateLine";
            this.separateLine.Size = new System.Drawing.Size(695, 3);
            this.separateLine.TabIndex = 184;
            this.separateLine.TabStop = false;
            // 
            // separateLine2
            // 
            this.separateLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.separateLine2.Location = new System.Drawing.Point(-1, 7);
            this.separateLine2.Name = "separateLine2";
            this.separateLine2.Size = new System.Drawing.Size(3, 510);
            this.separateLine2.TabIndex = 182;
            this.separateLine2.TabStop = false;
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panelHeader;
            this.DragControl.Vertical = true;
            // 
            // DragControl2
            // 
            this.DragControl2.Fixed = true;
            this.DragControl2.Horizontal = true;
            this.DragControl2.TargetControl = this.appName;
            this.DragControl2.Vertical = true;
            // 
            // infoText
            // 
            this.infoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.infoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoText.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoText.ForeColor = System.Drawing.Color.Gainsboro;
            this.infoText.Location = new System.Drawing.Point(3, 57);
            this.infoText.Name = "infoText";
            this.infoText.ReadOnly = true;
            this.infoText.Size = new System.Drawing.Size(692, 459);
            this.infoText.TabIndex = 185;
            this.infoText.Text = "";
            // 
            // info_QueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(698, 517);
            this.Controls.Add(this.separateLine3);
            this.Controls.Add(this.separateLine);
            this.Controls.Add(this.separateLine2);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "info_QueryBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "info_QueryBuilder";
            this.VisibleChanged += new System.EventHandler(this.info_QueryBuilder_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.separateLine3)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox separateLine3;
        public System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.PictureBox separateLine;
        private System.Windows.Forms.PictureBox separateLine2;
        private Bunifu.Framework.UI.BunifuElipse elipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl2;
        private System.Windows.Forms.RichTextBox infoText;
    }
}