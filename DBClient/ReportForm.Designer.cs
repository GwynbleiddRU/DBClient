namespace DBClient
{
    partial class ReportForm
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
            this.ОтгрузкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.separateLine = new System.Windows.Forms.PictureBox();
            this.totalReportButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chooseTableLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableList = new System.Windows.Forms.ComboBox();
            this.separateLine2 = new System.Windows.Forms.PictureBox();
            this.separateLine3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ОтгрузкаBindingSource)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine3)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "DBClient.Report.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 57);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(870, 493);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.ReportExport += new Microsoft.Reporting.WinForms.ExportEventHandler(this.reportViewer_ReportExport);
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
            this.panelHeader.Size = new System.Drawing.Size(870, 57);
            this.panelHeader.TabIndex = 2;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = global::DBClient.Properties.Resources.minimizeIcon;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(772, 8);
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
            this.exitButton.Location = new System.Drawing.Point(818, 8);
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
            this.appName.Size = new System.Drawing.Size(399, 32);
            this.appName.TabIndex = 0;
            this.appName.Text = "СУБД - ПРОМЭКЗ - Мастер отчетов";
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
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.appName;
            this.DragControl.Vertical = true;
            // 
            // DragControl2
            // 
            this.DragControl2.Fixed = true;
            this.DragControl2.Horizontal = true;
            this.DragControl2.TargetControl = this.panelHeader;
            this.DragControl2.Vertical = true;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.separateLine);
            this.panel1.Controls.Add(this.totalReportButton);
            this.panel1.Controls.Add(this.chooseTableLabel);
            this.panel1.Controls.Add(this.tableList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 64);
            this.panel1.TabIndex = 3;
            // 
            // separateLine
            // 
            this.separateLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.separateLine.Location = new System.Drawing.Point(-12, 60);
            this.separateLine.Name = "separateLine";
            this.separateLine.Size = new System.Drawing.Size(900, 3);
            this.separateLine.TabIndex = 180;
            this.separateLine.TabStop = false;
            // 
            // totalReportButton
            // 
            this.totalReportButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.totalReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.totalReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.totalReportButton.BorderRadius = 0;
            this.totalReportButton.ButtonText = "Итоговый отчет";
            this.totalReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalReportButton.DisabledColor = System.Drawing.Color.Gray;
            this.totalReportButton.Iconcolor = System.Drawing.Color.Transparent;
            this.totalReportButton.Iconimage = null;
            this.totalReportButton.Iconimage_right = null;
            this.totalReportButton.Iconimage_right_Selected = null;
            this.totalReportButton.Iconimage_Selected = null;
            this.totalReportButton.IconMarginLeft = 0;
            this.totalReportButton.IconMarginRight = 0;
            this.totalReportButton.IconRightVisible = true;
            this.totalReportButton.IconRightZoom = 0D;
            this.totalReportButton.IconVisible = true;
            this.totalReportButton.IconZoom = 60D;
            this.totalReportButton.IsTab = false;
            this.totalReportButton.Location = new System.Drawing.Point(13, 18);
            this.totalReportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalReportButton.Name = "totalReportButton";
            this.totalReportButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.totalReportButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.totalReportButton.OnHoverTextColor = System.Drawing.Color.White;
            this.totalReportButton.selected = false;
            this.totalReportButton.Size = new System.Drawing.Size(190, 30);
            this.totalReportButton.TabIndex = 121;
            this.totalReportButton.Text = "Итоговый отчет";
            this.totalReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalReportButton.Textcolor = System.Drawing.Color.White;
            this.totalReportButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReportButton.Click += new System.EventHandler(this.totalReportButton_Click);
            // 
            // chooseTableLabel
            // 
            this.chooseTableLabel.AutoSize = true;
            this.chooseTableLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseTableLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.chooseTableLabel.Location = new System.Drawing.Point(435, 20);
            this.chooseTableLabel.Name = "chooseTableLabel";
            this.chooseTableLabel.Size = new System.Drawing.Size(185, 28);
            this.chooseTableLabel.TabIndex = 102;
            this.chooseTableLabel.Text = "Выберите таблицу:";
            // 
            // tableList
            // 
            this.tableList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tableList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableList.ForeColor = System.Drawing.Color.Gainsboro;
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(648, 20);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(190, 28);
            this.tableList.TabIndex = 0;
            this.tableList.SelectedIndexChanged += new System.EventHandler(this.tableList_SelectedIndexChanged);
            // 
            // separateLine2
            // 
            this.separateLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.separateLine2.Location = new System.Drawing.Point(0, 31);
            this.separateLine2.Name = "separateLine2";
            this.separateLine2.Size = new System.Drawing.Size(3, 600);
            this.separateLine2.TabIndex = 178;
            this.separateLine2.TabStop = false;
            // 
            // separateLine3
            // 
            this.separateLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.separateLine3.Location = new System.Drawing.Point(866, 17);
            this.separateLine3.Name = "separateLine3";
            this.separateLine3.Size = new System.Drawing.Size(3, 600);
            this.separateLine3.TabIndex = 179;
            this.separateLine3.TabStop = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 614);
            this.Controls.Add(this.separateLine3);
            this.Controls.Add(this.separateLine2);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ОтгрузкаBindingSource)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource ОтгрузкаBindingSource;
        public System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private System.Windows.Forms.PictureBox appLogo;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl2;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tableList;
        private Bunifu.Framework.UI.BunifuCustomLabel chooseTableLabel;
        private Bunifu.Framework.UI.BunifuFlatButton totalReportButton;
        private System.Windows.Forms.PictureBox separateLine2;
        private System.Windows.Forms.PictureBox separateLine3;
        private System.Windows.Forms.PictureBox separateLine;
    }
}