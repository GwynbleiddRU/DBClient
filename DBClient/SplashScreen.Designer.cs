namespace DBClient
{
    partial class SplashScreen
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
            this.fader = new System.Windows.Forms.Timer(this.components);
            this.ColorTransition = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // fader
            // 
            this.fader.Enabled = true;
            this.fader.Interval = 1;
            this.fader.Tick += new System.EventHandler(this.fader_Tick);
            // 
            // ColorTransition
            // 
            this.ColorTransition.Color1 = System.Drawing.Color.Lime;
            this.ColorTransition.Color2 = System.Drawing.Color.YellowGreen;
            this.ColorTransition.ProgessValue = 0;
            // 
            // appLogo
            // 
            this.appLogo.Image = global::DBClient.Properties.Resources.promekzAppLogo;
            this.appLogo.Location = new System.Drawing.Point(216, 74);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(123, 123);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 1;
            this.appLogo.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Days", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(181, 222);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(203, 24);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "ООО \"ПРОМЭКЗ\"";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::DBClient.Properties.Resources.closeIcon;
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(508, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 3;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 20;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Days", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(212, 260);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(127, 24);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Загрузка...";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(560, 340);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.appLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SplashScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer fader;
        private Bunifu.Framework.UI.BunifuColorTransition ColorTransition;
        private System.Windows.Forms.PictureBox appLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}