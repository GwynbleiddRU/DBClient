using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using Bunifu.Framework.UI;
using System.IO;
using System.Threading;

namespace DBClient
{
    public partial class panelStats : UserControl
    {
        MainForm mainForm;
        static string tempFilePath = "";
        static string savedReportsLog = Environment.CurrentDirectory + "\\Отчеты\\Сохраненные отчеты.log";

        public panelStats()
        {
            InitializeComponent();
            SqlConnections.OpenConnection();
        }

        public panelStats(Form parent)
        {
            InitializeComponent();
            mainForm = (MainForm)parent;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            SqlConnections.sql = "SELECT * FROM dbo.Клиенты";
            SqlConnections.cmd = new SqlCommand(SqlConnections.sql, SqlConnections.connection);

            SqlConnections.da = new SqlDataAdapter(SqlConnections.cmd);
            SqlConnections.ds = new DataSet();
            SqlConnections.bs = new BindingSource();

            SqlConnections.da.Fill(SqlConnections.ds, "dbo.Клиенты");

            UpdateClientList();
            ListViewReportsLog();
            SetChartStyle();
        }

        #region Style
        public void ChangeStyle()
        {
            foreach (Control item in Controls)
            {
                if (item is PictureBox)
                    item.BackColor = MainForm.appColor;
                if (item.Name.Contains("header"))
                    item.ForeColor = MainForm.appColor;
                if (item is Chart)
                {
                    item.BackColor = Color.FromArgb(37, 46, 59);
                    item.ForeColor = Color.White;
                }
                if (item is BunifuFlatButton)
                {
                    var temp = item as BunifuFlatButton;
                    temp.BackColor = MainForm.appColor;
                    temp.colselected = MainForm.appColor;
                    temp.colhover = MainForm.appColor;
                    temp.colbackground = MainForm.appColor;
                    if (MainForm.appColor == Color.FromArgb(6, 181, 126))
                    { temp.ForeColor = Color.FromArgb(89, 205, 169); temp.OnHovercolor = Color.FromArgb(89, 205, 169); temp.Textcolor = Color.White; temp.OnHoverTextColor = Color.White; }
                    else if (MainForm.appColor == Color.FromArgb(228, 231, 235))
                    { temp.ForeColor = Color.FromArgb(152, 154, 156); temp.OnHovercolor = Color.FromArgb(152, 154, 156); temp.Textcolor = Color.FromArgb(37, 46, 59); temp.OnHoverTextColor = Color.FromArgb(37, 46, 59); }
                    else { temp.ForeColor = Color.FromArgb(85, 153, 221); temp.OnHovercolor = Color.FromArgb(85, 153, 221); temp.Textcolor = Color.White; temp.OnHoverTextColor = Color.White; }
                }
                if (item is BunifuMetroTextbox)
                {
                    var temp = item as BunifuMetroTextbox;
                    temp.ForeColor = MainForm.appColor;
                    temp.BorderColorIdle = MainForm.appColor;
                    if (MainForm.appColor == Color.FromArgb(6, 181, 126))
                    { temp.ForeColor = Color.FromArgb(89, 205, 169); temp.BorderColorFocused = Color.FromArgb(89, 205, 169); temp.BorderColorMouseHover = Color.FromArgb(20, 248, 173); }
                    else if (MainForm.appColor == Color.FromArgb(228, 231, 235))
                    { temp.ForeColor = Color.Gainsboro; temp.BorderColorFocused = Color.White; temp.BorderColorMouseHover = Color.FromArgb(152, 154, 156); }
                    else { temp.ForeColor = Color.FromArgb(85, 153, 221); temp.BorderColorFocused = Color.FromArgb(85, 153, 221); temp.BorderColorMouseHover = Color.FromArgb(85, 153, 221); }
                }
                if (item is BunifuImageButton)
                {
                    item.BackColor = Color.Transparent;
                }
                if (item is ComboBox)
                    item.ForeColor = Color.Gainsboro;
            }
            BackColor = Color.FromArgb(37, 46, 59);
        }

        public void SetChartStyle()
        {
            statsChart.ForeColor = Color.Gainsboro;
            statsChart.BackColor = Color.FromArgb(37, 46, 59);

            //statsChart.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.Gainsboro;
            //statsChart.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.Gainsboro;

            statsChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Gainsboro;
            statsChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Gainsboro;

            statsChart.ChartAreas[0].AxisX.LineColor = Color.Gainsboro;
            statsChart.ChartAreas[0].AxisY.LineColor = Color.Gainsboro;
            statsChart.ChartAreas[0].AxisX.InterlacedColor = Color.Gainsboro;
            statsChart.ChartAreas[0].AxisY.InterlacedColor = Color.Gainsboro;

            statsChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            statsChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            statsChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            statsChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            clientNameList.SelectedItem = clientNameList.Items[0];
        }

        #region ComboBox.DrawItem
        private void FillColorComboBox(object sender, DrawItemEventArgs e, Color selectColor, Color font)
        {
            var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(selectColor), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          new SolidBrush(font),
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }

        private void clientIDList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
        #endregion ComboBox.DrawItem
        #endregion Style

        private void Stats_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();

            string selectedItem = clientNameList.SelectedItem.ToString();
            UpdateClientList();
            if (clientNameList.Items.Contains(selectedItem))
                clientNameList.SelectedItem = selectedItem;
            else
                clientNameList.SelectedItem = clientNameList.Items[0];

            SetPaymentChart(statsChart, clientNameList.SelectedItem.ToString());
        }

        #region Chart
        public void UpdateClientList()
        {
            clientNameList.Items.Clear();

            SqlConnections.cmd.CommandText = "SELECT client_name FROM Клиенты;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    clientNameList.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }
        public void SetPaymentChart(Chart chart, string name)
        {
            SqlConnections.sql = "SELECT * FROM Взаиморасчеты.dbo.Оплата Where Взаиморасчеты.dbo.Оплата.client_id = (SELECT Взаиморасчеты.dbo.Клиенты.client_id FROM Взаиморасчеты.dbo.Клиенты WHERE Взаиморасчеты.dbo.Клиенты.client_name = '" + name + "');";
            SqlConnections.cmd = new SqlCommand(SqlConnections.sql, SqlConnections.connection);

            SqlConnections.da = new SqlDataAdapter(SqlConnections.cmd);
            SqlConnections.ds = new DataSet();
            SqlConnections.bs = new BindingSource();

            SqlConnections.da.Fill(SqlConnections.ds, "Оплата");
            chart.Series.Clear();
            Series sr = new Series();
            chart.DataSource = SqlConnections.ds.Tables["Оплата"];

            chart.Legends[0].ForeColor = Color.Gainsboro;
            chart.Legends[0].BackColor = Color.Transparent;
            chart.ChartAreas[0].BackColor = Color.Transparent;

            sr.Color = MainForm.appColor;
            sr.Name = "Оплата";
            sr.XValueMember = "date";
            sr.YValueMembers = "payment";
            chart.Series.Add(sr);

            chart.DataBind();
            chart.Invalidate();
        }
        private void clientIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPaymentChart(statsChart, clientNameList.SelectedItem.ToString());
        }

        #endregion Chart

        private void buildReportButton_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.ShowDialog();
            ListViewReportsLog();
        }

        #region ListViewReports
        public void ListViewReportsLog()
        {
            savedReportListView.BeginUpdate();

            savedReportListView.Items.Clear();
            savedReportListView.SmallImageList = imageListExtensions;

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Отчеты\\"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Отчеты\\");
            if (!File.Exists(savedReportsLog))
                File.Create(savedReportsLog).Close();

            string imageKey = "wordFlatIcon.png";
            foreach (string item in File.ReadAllLines(savedReportsLog))
            {
                string itemText = item;
                if (itemText.IndexOf('\\') != -1)
                    itemText = itemText.Remove(0, itemText.LastIndexOf('\\') + 1);   //Обрезаем строку директории - получаем имя и формат

                if (item.Contains(".pdf"))
                    imageKey = "pdfIcon.png";
                else if (item.Contains(".xls"))
                    imageKey = "excelFlatIcon.png";
                else if (item.Contains(".doc"))
                    imageKey = "wordFlatIcon.png";

                savedReportListView.Items.Add(item, itemText, imageKey);
            }

            savedReportListView.EndUpdate();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            //GetSavedReportsFromLog();
            ListViewReportsLog();
        }

        #region Oldbuttons
        //private void openReportButton_Click(object sender, EventArgs e)
        //{
        //    openReportLabel.Visible = false;
        //    try
        //    {
        //        string path = savedReportListView.SelectedItems[0].Name.ToString();
        //        try
        //        {
        //            System.Diagnostics.Process.Start(path);
        //        }
        //        catch   //If file wasnt found remove its directory from listbox and log
        //        {
        //            MessageBox.Show("Отчет не найден. \nВозможно, файл был перемещен или удален");

        //            var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(savedReportListView.SelectedItems[0].Name.ToString()));
        //            File.WriteAllLines(savedReportsLog, file);

        //            savedReportListView.Items.Remove(savedReportListView.SelectedItems[0]);
        //        }
        //    }
        //    catch
        //    {
        //        openReportLabel.Visible = true;
        //    }
        //}
        //private void removeReportButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        File.Delete(savedReportListView.SelectedItems[0].Name);
        //        var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(savedReportListView.SelectedItems[0].Name.ToString()));
        //        File.WriteAllLines(savedReportsLog, file);
        //    }
        //    finally
        //    {
        //        savedReportListView.Items.Remove(savedReportListView.SelectedItems[0]);
        //    }
        //}
        //private void renameButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        openReportLabel.Visible = false;
        //        string extension = savedReportListView.SelectedItems[0].Name.ToString().Remove(0, savedReportListView.SelectedItems[0].Name.ToString().LastIndexOf('.'));
        //        string oldPath = savedReportListView.SelectedItems[0].Name.ToString();
        //        string newPath = oldPath.Remove(oldPath.LastIndexOf('\\'));
        //        newPath += "\\" + renameTextBox.Text + extension;  //Full path for file with new name

        //        try
        //        {
        //            if (renameTextBox.Text != "")
        //            {
        //                renameReportLabel.Visible = false;
        //                File.Move(oldPath, newPath);

        //                var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(oldPath));
        //                File.WriteAllLines(savedReportsLog, file);
        //                StreamWriter sw = File.AppendText(savedReportsLog);
        //                sw.WriteLine(newPath);
        //                sw.Close();

        //                ListViewReportsLog();
        //            }
        //            else
        //                renameReportLabel.Visible = true;
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Отчет не найден. \nВозможно, файл был перемещен или удален");

        //            var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(oldPath));
        //            File.WriteAllLines(savedReportsLog, file);

        //            savedReportListView.Items.Remove(savedReportListView.SelectedItems[0]);
        //        }
        //    }
        //    catch
        //    {
        //        openReportLabel.Visible = true;
        //    }

        //}
        #endregion Oldbuttons

        #region ListView ContextMenu
        private void savedReportListView_MouseClick(object sender, MouseEventArgs e) //Вызов контекстного меню по клику пкм на item
        {
            if (e.Button == MouseButtons.Right)
            {
                if (savedReportListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    reportContextMenuStrip.Show(savedReportListView, new Point(e.X, e.Y));
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedFile = savedReportListView.SelectedItems[0];
            string filePath = selectedFile.Name.ToString();
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch   //If file wasnt found remove its directory from listbox and log
            {
                MessageBox.Show("Отчет не найден. \nВозможно, файл был перемещен или удален");

                var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(savedReportListView.SelectedItems[0].Name.ToString()));
                File.WriteAllLines(savedReportsLog, file);

                savedReportListView.Items.Remove(savedReportListView.SelectedItems[0]);
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить этот отчет?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ListViewItem selectedFile = savedReportListView.SelectedItems[0];
                try
                {
                    File.Delete(selectedFile.Name);
                    var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(selectedFile.Name.ToString()));
                    File.WriteAllLines(savedReportsLog, file);
                }
                finally
                {
                    savedReportListView.Items.Remove(selectedFile);
                }
            }
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedFile = savedReportListView.SelectedItems[0];
            string filePath = selectedFile.Name.ToString();
            string folder = filePath.Remove(filePath.LastIndexOf('\\'));

            try
            {
                System.Diagnostics.Process Proc = new System.Diagnostics.Process();
                Proc.StartInfo.FileName = "explorer";
                Proc.StartInfo.Arguments = folder;
                Proc.Start();
                Proc.Close();
            }
            catch
            {

            }
        }

        #region Rename
        private void savedReportListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2 && savedReportListView.SelectedItems.Count > 0)
            {
                if (File.Exists(savedReportListView.SelectedItems[0].Name))
                    savedReportListView.SelectedItems[0].BeginEdit();
                else
                {
                    MessageBox.Show("Отчет не найден. \nВозможно, файл был перемещен или удален");

                    var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(savedReportListView.SelectedItems[0].Name));
                    File.WriteAllLines(savedReportsLog, file);

                    savedReportListView.Items.Remove(savedReportListView.SelectedItems[0]);
                }
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(savedReportListView.SelectedItems[0].Name))
                savedReportListView.SelectedItems[0].BeginEdit();
            else
            {
                MessageBox.Show("Отчет не найден. \nВозможно, файл был перемещен или удален");

                var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(savedReportListView.SelectedItems[0].Name));
                File.WriteAllLines(savedReportsLog, file);

                savedReportListView.Items.Remove(savedReportListView.SelectedItems[0]);
            }
        }

        private void savedReportListView_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            tempFilePath = savedReportListView.SelectedItems[0].Name;
        }

        private void savedReportListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                string extension = tempFilePath.Remove(0, tempFilePath.LastIndexOf('.'));
                string newPath = tempFilePath.Remove(tempFilePath.LastIndexOf('\\'));
                newPath += "\\" + e.Label;  //Full path for file with new name

                if (e.Label.Length > 0)
                {
                    if (!e.Label.Contains(".doc") && !e.Label.Contains(".xls") && !e.Label.Contains(".pdf"))
                    {
                        newPath += extension;  //Full path for file with new name with extension              
                                               //e.Label += extension;
                    }

                    try
                    {
                        if (!File.Exists(newPath))
                        {
                            //if (savedReportListView.SelectedItems[0].Text.ToString() != "")
                            //{
                                File.Move(tempFilePath, newPath);

                                var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(tempFilePath));
                                File.WriteAllLines(savedReportsLog, file);
                                StreamWriter sw = File.AppendText(savedReportsLog);
                                sw.WriteLine(newPath);
                                sw.Close();
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Имя не может быть пустым");
                            //    e.CancelEdit = true;
                            //}
                        }
                        else
                            MessageBox.Show("Файл с таким именем уже существует в указанной директории");

                        Thread thread = new Thread(ListViewReportsLog);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Отчет не найден. \nВозможно, файл был перемещен или удален");

                        var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(tempFilePath));
                        File.WriteAllLines(savedReportsLog, file);

                        savedReportListView.Items.Remove(savedReportListView.SelectedItems[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Имя не может быть пустым");
                    e.CancelEdit = true;
                }
            }
            catch { } //имя не было изменено
        }

        #endregion Rename

        #region ContextMenuItem RecolorOnHover
        private void deleteToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.FromArgb(37, 46, 59);
        }

        private void deleteToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Gainsboro;
        }

        private void locationToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.FromArgb(37, 46, 59);
        }

        private void locationToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Gainsboro;
        }

        private void renameToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.FromArgb(37, 46, 59);
        }

        private void renameToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Gainsboro;
        }

        private void openToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.FromArgb(37, 46, 59);
        }

        private void openToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Gainsboro;
        }

        #endregion ContextMenuItem RecolorOnHover

        #endregion ListView ContextMenu

        private void savedReportListView_MouseDown(object sender, MouseEventArgs e)
        {
            // Make sure it was a double left click, like the normal DoubleClick event
            if ((e.Button == MouseButtons.Left) && (e.Clicks == 2))
            {
                ListViewItem selectedFile = savedReportListView.SelectedItems[0];
                string filePath = selectedFile.Name.ToString();
                try
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                catch   //If file wasnt found remove its directory from listbox and log
                {
                    MessageBox.Show("Отчет не найден. \nВозможно, файл был перемещен или удален");

                    var file = File.ReadAllLines(savedReportsLog).Where(s => !s.Contains(savedReportListView.SelectedItems[0].Name.ToString()));
                    File.WriteAllLines(savedReportsLog, file);

                    savedReportListView.Items.Remove(savedReportListView.SelectedItems[0]);
                }
            }
        }

        #region Sorting
        private void alphabeticalSortingReports_Click(object sender, EventArgs e)
        {
            savedReportListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            ListViewReportsLog();
        }

        private void dateSortingReports_Click(object sender, EventArgs e)
        {
            savedReportListView.Sorting = System.Windows.Forms.SortOrder.None;
            ListViewReportsLog();
        }
        #endregion Sorting

        #endregion ListViewReports

    }
}
