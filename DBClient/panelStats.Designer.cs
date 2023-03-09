namespace DBClient
{
    partial class panelStats
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelStats));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.infoTextLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.headerInfoLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imageListExtensions = new System.Windows.Forms.ImageList(this.components);
            this.reportContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.separateLine5 = new System.Windows.Forms.PictureBox();
            this.separateLine3 = new System.Windows.Forms.PictureBox();
            this.separateLine4 = new System.Windows.Forms.PictureBox();
            this.headerClientLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.clientNameList = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.statsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new DBClient.ReportDataSet();
            this.buildReportButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerReportsLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.savedReportListView = new System.Windows.Forms.ListView();
            this.updateButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.alphabeticalSortingReports = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateSortingReports = new Bunifu.Framework.UI.BunifuThinButton2();
            this.reportContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(842, 123);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(177, 56);
            this.bunifuCustomLabel8.TabIndex = 144;
            this.bunifuCustomLabel8.Text = "Всего отгрузок за\r\nпоследний месяц:\r\n";
            // 
            // infoTextLabel3
            // 
            this.infoTextLabel3.AutoSize = true;
            this.infoTextLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.infoTextLabel3.Location = new System.Drawing.Point(841, 557);
            this.infoTextLabel3.Name = "infoTextLabel3";
            this.infoTextLabel3.Size = new System.Drawing.Size(215, 84);
            this.infoTextLabel3.TabIndex = 142;
            this.infoTextLabel3.Text = "Электронный адрес:\r\nemail@promekz.ru\r\nТел.: 8 (342) 299-83-40";
            // 
            // headerInfoLabel
            // 
            this.headerInfoLabel.AutoSize = true;
            this.headerInfoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.headerInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.headerInfoLabel.Location = new System.Drawing.Point(841, 19);
            this.headerInfoLabel.Name = "headerInfoLabel";
            this.headerInfoLabel.Size = new System.Drawing.Size(87, 28);
            this.headerInfoLabel.TabIndex = 137;
            this.headerInfoLabel.Text = "Сводка:";
            // 
            // imageListExtensions
            // 
            this.imageListExtensions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListExtensions.ImageStream")));
            this.imageListExtensions.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListExtensions.Images.SetKeyName(0, "excelFlatIcon.png");
            this.imageListExtensions.Images.SetKeyName(1, "wordFlatIcon.png");
            this.imageListExtensions.Images.SetKeyName(2, "pdfIcon.png");
            // 
            // reportContextMenuStrip
            // 
            this.reportContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.reportContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.reportContextMenuStrip.Name = "reportContextMenuStrip";
            this.reportContextMenuStrip.Size = new System.Drawing.Size(223, 132);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.openToolStripMenuItem.Image = global::DBClient.Properties.Resources.openIcon;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.openToolStripMenuItem.MouseEnter += new System.EventHandler(this.openToolStripMenuItem_MouseEnter);
            this.openToolStripMenuItem.MouseLeave += new System.EventHandler(this.openToolStripMenuItem_MouseLeave);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.renameToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.renameToolStripMenuItem.Image = global::DBClient.Properties.Resources.renameIcon;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.renameToolStripMenuItem.Text = "Переименовать";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            this.renameToolStripMenuItem.MouseEnter += new System.EventHandler(this.renameToolStripMenuItem_MouseEnter);
            this.renameToolStripMenuItem.MouseLeave += new System.EventHandler(this.renameToolStripMenuItem_MouseLeave);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.locationToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.locationToolStripMenuItem.Image = global::DBClient.Properties.Resources.folderIcon;
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.locationToolStripMenuItem.Text = "Расположение";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            this.locationToolStripMenuItem.MouseEnter += new System.EventHandler(this.locationToolStripMenuItem_MouseEnter);
            this.locationToolStripMenuItem.MouseLeave += new System.EventHandler(this.locationToolStripMenuItem_MouseLeave);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteToolStripMenuItem.Image = global::DBClient.Properties.Resources.deleteIcon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            this.deleteToolStripMenuItem.MouseEnter += new System.EventHandler(this.deleteToolStripMenuItem_MouseEnter);
            this.deleteToolStripMenuItem.MouseLeave += new System.EventHandler(this.deleteToolStripMenuItem_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(762, 3);
            this.pictureBox2.TabIndex = 146;
            this.pictureBox2.TabStop = false;
            // 
            // separateLine5
            // 
            this.separateLine5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.separateLine5.Image = ((System.Drawing.Image)(resources.GetObject("separateLine5.Image")));
            this.separateLine5.Location = new System.Drawing.Point(816, 341);
            this.separateLine5.Name = "separateLine5";
            this.separateLine5.Size = new System.Drawing.Size(3, 300);
            this.separateLine5.TabIndex = 141;
            this.separateLine5.TabStop = false;
            // 
            // separateLine3
            // 
            this.separateLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.separateLine3.Image = ((System.Drawing.Image)(resources.GetObject("separateLine3.Image")));
            this.separateLine3.Location = new System.Drawing.Point(847, 314);
            this.separateLine3.Name = "separateLine3";
            this.separateLine3.Size = new System.Drawing.Size(200, 3);
            this.separateLine3.TabIndex = 140;
            this.separateLine3.TabStop = false;
            // 
            // separateLine4
            // 
            this.separateLine4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.separateLine4.Image = ((System.Drawing.Image)(resources.GetObject("separateLine4.Image")));
            this.separateLine4.Location = new System.Drawing.Point(816, 19);
            this.separateLine4.Name = "separateLine4";
            this.separateLine4.Size = new System.Drawing.Size(3, 271);
            this.separateLine4.TabIndex = 139;
            this.separateLine4.TabStop = false;
            // 
            // headerClientLabel
            // 
            this.headerClientLabel.AutoSize = true;
            this.headerClientLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.headerClientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.headerClientLabel.Location = new System.Drawing.Point(17, 19);
            this.headerClientLabel.Name = "headerClientLabel";
            this.headerClientLabel.Size = new System.Drawing.Size(202, 28);
            this.headerClientLabel.TabIndex = 168;
            this.headerClientLabel.Text = "Оплата по клиенту:";
            // 
            // clientNameList
            // 
            this.clientNameList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.clientNameList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.clientNameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.clientNameList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clientNameList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientNameList.ForeColor = System.Drawing.Color.Gainsboro;
            this.clientNameList.FormattingEnabled = true;
            this.clientNameList.Location = new System.Drawing.Point(599, 19);
            this.clientNameList.Name = "clientNameList";
            this.clientNameList.Size = new System.Drawing.Size(183, 27);
            this.clientNameList.TabIndex = 167;
            this.clientNameList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.clientIDList_DrawItem);
            this.clientNameList.SelectedIndexChanged += new System.EventHandler(this.clientIDList_SelectedIndexChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(481, 19);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(81, 28);
            this.bunifuCustomLabel5.TabIndex = 166;
            this.bunifuCustomLabel5.Text = "Клиент:";
            // 
            // statsChart
            // 
            this.statsChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.statsChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            chartArea1.Name = "ChartArea1";
            this.statsChart.ChartAreas.Add(chartArea1);
            this.statsChart.DataSource = this.reportDataSetBindingSource;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Gainsboro;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Gainsboro;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.Gainsboro;
            legend1.TitleSeparatorColor = System.Drawing.Color.Gainsboro;
            this.statsChart.Legends.Add(legend1);
            this.statsChart.Location = new System.Drawing.Point(22, 74);
            this.statsChart.Name = "statsChart";
            this.statsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelForeColor = System.Drawing.Color.Gainsboro;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.statsChart.Series.Add(series1);
            this.statsChart.Size = new System.Drawing.Size(760, 216);
            this.statsChart.TabIndex = 169;
            this.statsChart.Text = "statsChart";
            // 
            // reportDataSetBindingSource
            // 
            this.reportDataSetBindingSource.DataSource = this.reportDataSet;
            this.reportDataSetBindingSource.Position = 0;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildReportButton
            // 
            this.buildReportButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buildReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.buildReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buildReportButton.BorderRadius = 0;
            this.buildReportButton.ButtonText = "Составить отчет";
            this.buildReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildReportButton.DisabledColor = System.Drawing.Color.Gray;
            this.buildReportButton.Iconcolor = System.Drawing.Color.Transparent;
            this.buildReportButton.Iconimage = null;
            this.buildReportButton.Iconimage_right = null;
            this.buildReportButton.Iconimage_right_Selected = null;
            this.buildReportButton.Iconimage_Selected = null;
            this.buildReportButton.IconMarginLeft = 0;
            this.buildReportButton.IconMarginRight = 0;
            this.buildReportButton.IconRightVisible = true;
            this.buildReportButton.IconRightZoom = 0D;
            this.buildReportButton.IconVisible = true;
            this.buildReportButton.IconZoom = 60D;
            this.buildReportButton.IsTab = false;
            this.buildReportButton.Location = new System.Drawing.Point(599, 341);
            this.buildReportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buildReportButton.Name = "buildReportButton";
            this.buildReportButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.buildReportButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buildReportButton.OnHoverTextColor = System.Drawing.Color.White;
            this.buildReportButton.selected = false;
            this.buildReportButton.Size = new System.Drawing.Size(183, 28);
            this.buildReportButton.TabIndex = 154;
            this.buildReportButton.Text = "Составить отчет";
            this.buildReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buildReportButton.Textcolor = System.Drawing.Color.White;
            this.buildReportButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildReportButton.Click += new System.EventHandler(this.buildReportButton_Click);
            // 
            // headerReportsLabel
            // 
            this.headerReportsLabel.AutoSize = true;
            this.headerReportsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.headerReportsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.headerReportsLabel.Location = new System.Drawing.Point(17, 341);
            this.headerReportsLabel.Name = "headerReportsLabel";
            this.headerReportsLabel.Size = new System.Drawing.Size(198, 28);
            this.headerReportsLabel.TabIndex = 156;
            this.headerReportsLabel.Text = "Работа с отчетами:";
            // 
            // savedReportListView
            // 
            this.savedReportListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.savedReportListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedReportListView.ForeColor = System.Drawing.Color.Gainsboro;
            this.savedReportListView.HideSelection = false;
            this.savedReportListView.LabelEdit = true;
            this.savedReportListView.Location = new System.Drawing.Point(22, 390);
            this.savedReportListView.MultiSelect = false;
            this.savedReportListView.Name = "savedReportListView";
            this.savedReportListView.Size = new System.Drawing.Size(760, 251);
            this.savedReportListView.SmallImageList = this.imageListExtensions;
            this.savedReportListView.TabIndex = 160;
            this.savedReportListView.UseCompatibleStateImageBehavior = false;
            this.savedReportListView.View = System.Windows.Forms.View.List;
            this.savedReportListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.savedReportListView_AfterLabelEdit);
            this.savedReportListView.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.savedReportListView_BeforeLabelEdit);
            this.savedReportListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.savedReportListView_KeyDown);
            this.savedReportListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.savedReportListView_MouseClick);
            this.savedReportListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.savedReportListView_MouseDown);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageActive = null;
            this.updateButton.Location = new System.Drawing.Point(757, 390);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(25, 25);
            this.updateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateButton.TabIndex = 157;
            this.updateButton.TabStop = false;
            this.updateButton.Zoom = 10;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(842, 199);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 56);
            this.bunifuCustomLabel1.TabIndex = 170;
            this.bunifuCustomLabel1.Text = "Выручка за\r\nпоследний месяц:\r\n";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(842, 74);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(146, 28);
            this.bunifuCustomLabel2.TabIndex = 171;
            this.bunifuCustomLabel2.Text = "Сумма долгов:\r\n";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(842, 341);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(204, 84);
            this.bunifuCustomLabel3.TabIndex = 172;
            this.bunifuCustomLabel3.Text = "Для редактирования\r\nотчета вызовите\r\nконтектстное меню";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(842, 438);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(204, 28);
            this.bunifuCustomLabel4.TabIndex = 173;
            this.bunifuCustomLabel4.Text = "Сортировка отчетов:";
            // 
            // alphabeticalSortingReports
            // 
            this.alphabeticalSortingReports.ActiveBorderThickness = 1;
            this.alphabeticalSortingReports.ActiveCornerRadius = 20;
            this.alphabeticalSortingReports.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.alphabeticalSortingReports.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.alphabeticalSortingReports.ActiveLineColor = System.Drawing.Color.Gainsboro;
            this.alphabeticalSortingReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.alphabeticalSortingReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alphabeticalSortingReports.BackgroundImage")));
            this.alphabeticalSortingReports.ButtonText = "По алфавиту";
            this.alphabeticalSortingReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alphabeticalSortingReports.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.alphabeticalSortingReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.alphabeticalSortingReports.IdleBorderThickness = 1;
            this.alphabeticalSortingReports.IdleCornerRadius = 10;
            this.alphabeticalSortingReports.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.alphabeticalSortingReports.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.alphabeticalSortingReports.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.alphabeticalSortingReports.Location = new System.Drawing.Point(846, 471);
            this.alphabeticalSortingReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alphabeticalSortingReports.Name = "alphabeticalSortingReports";
            this.alphabeticalSortingReports.Size = new System.Drawing.Size(190, 40);
            this.alphabeticalSortingReports.TabIndex = 210;
            this.alphabeticalSortingReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alphabeticalSortingReports.Click += new System.EventHandler(this.alphabeticalSortingReports_Click);
            // 
            // dateSortingReports
            // 
            this.dateSortingReports.ActiveBorderThickness = 1;
            this.dateSortingReports.ActiveCornerRadius = 20;
            this.dateSortingReports.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.dateSortingReports.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.dateSortingReports.ActiveLineColor = System.Drawing.Color.Gainsboro;
            this.dateSortingReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.dateSortingReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dateSortingReports.BackgroundImage")));
            this.dateSortingReports.ButtonText = "Дата изменения";
            this.dateSortingReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateSortingReports.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dateSortingReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateSortingReports.IdleBorderThickness = 1;
            this.dateSortingReports.IdleCornerRadius = 10;
            this.dateSortingReports.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.dateSortingReports.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.dateSortingReports.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.dateSortingReports.Location = new System.Drawing.Point(846, 513);
            this.dateSortingReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateSortingReports.Name = "dateSortingReports";
            this.dateSortingReports.Size = new System.Drawing.Size(190, 40);
            this.dateSortingReports.TabIndex = 211;
            this.dateSortingReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateSortingReports.Click += new System.EventHandler(this.dateSortingReports_Click);
            // 
            // panelStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.dateSortingReports);
            this.Controls.Add(this.alphabeticalSortingReports);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.statsChart);
            this.Controls.Add(this.headerClientLabel);
            this.Controls.Add(this.clientNameList);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.savedReportListView);
            this.Controls.Add(this.headerReportsLabel);
            this.Controls.Add(this.buildReportButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.infoTextLabel3);
            this.Controls.Add(this.separateLine5);
            this.Controls.Add(this.separateLine3);
            this.Controls.Add(this.separateLine4);
            this.Controls.Add(this.headerInfoLabel);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "panelStats";
            this.Size = new System.Drawing.Size(1069, 677);
            this.Load += new System.EventHandler(this.Stats_Load);
            this.VisibleChanged += new System.EventHandler(this.Stats_VisibleChanged);
            this.reportContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separateLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel infoTextLabel3;
        private System.Windows.Forms.PictureBox separateLine5;
        private System.Windows.Forms.PictureBox separateLine3;
        private System.Windows.Forms.PictureBox separateLine4;
        private Bunifu.Framework.UI.BunifuCustomLabel headerInfoLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageListExtensions;
        private System.Windows.Forms.ContextMenuStrip reportContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel headerClientLabel;
        private System.Windows.Forms.ComboBox clientNameList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart statsChart;
        private System.Windows.Forms.BindingSource reportDataSetBindingSource;
        private ReportDataSet reportDataSet;
        private Bunifu.Framework.UI.BunifuFlatButton buildReportButton;
        private Bunifu.Framework.UI.BunifuCustomLabel headerReportsLabel;
        private System.Windows.Forms.ListView savedReportListView;
        private Bunifu.Framework.UI.BunifuImageButton updateButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuThinButton2 alphabeticalSortingReports;
        private Bunifu.Framework.UI.BunifuThinButton2 dateSortingReports;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}
