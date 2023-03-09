using Bunifu.Framework.UI;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClient
{
    public partial class ReportForm : Form
    {
        static string curTable = "Отгрузка";                                                          //Set current table to open in table reports
        static string reportName = "DBClient.reportShipment.rdlc";                                    //Set current report based on curTable
        public static List<string> savedReports = new List<string>();                                 //Keep saved reports directories
        static string folderPath = Environment.CurrentDirectory + "\\Отчеты\\";
        static List<ReportParameter> parms = new List<ReportParameter>();                             //List of report parameters to use in totalReport

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ChangeStyle();                                                                            //Refresh form style
            updateTableList();                                                                        //Get table names
            BuildReport();                                                                            //Fill reportViewer with shipment table data

            parms.Clear();                                                                            //Clear previous session parameters
            parms.Add(new ReportParameter("UserName", SqlConnections.user));                          //Add parameters to report
        }

        public void TotalReport(List<ReportParameter> parms)                                          //Fill reportViewer with totalReport
        {
            SqlConnections.ds = new DataSet();                                                        //Refresh dataSet
            SqlConnections.da = new SqlDataAdapter();                                                 //Refresh dataAdapter
            SqlConnections.sql = "SELECT * FROM " + curTable;                                         //Query - select data from current table
            SqlConnections.cmd.CommandText = SqlConnections.sql;                                      //Apply query as a command text
            SqlConnections.da.SelectCommand = SqlConnections.cmd;                                     //Select command
            SqlConnections.da.Fill(SqlConnections.ds, curTable);                                      //Fill dataAdapter with current table data

            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);     //Nesessary line for reportViewer to work in WinForms
            SetupReport("DBClient.reportTotal.rdlc");                                                 //Setup total report

            void SetupReport(string reportName)
            {
                reportViewer.ProcessingMode = ProcessingMode.Local;                                   //Set the processing mode for the ReportViewer to Local 

                ReportDataSource shipment = new ReportDataSource();                                   //DataSource with shipment table data
                ReportDataSource payment = new ReportDataSource();                                    //DataSource with payment table data
                ReportDataSource clients = new ReportDataSource();                                    //DataSource with clients table data
                ReportDataSource storage = new ReportDataSource();                                    //DataSource with storage table data
                ReportDataSource storageContains = new ReportDataSource();                            //DataSource with storageContains table data
                ReportDataSource clientBalance = new ReportDataSource();                              //DataSource with clientBalance table data

                reportViewer.LocalReport.ReportEmbeddedResource = reportName;                         //Get report name

                void SetDataSource(string tableName, string dataSetName, ReportDataSource dataSource) //Setup dataSource and add it to reportViewer
                {
                    SqlConnections.da = new SqlDataAdapter();                                         //Refresh dataAdapter
                    SqlConnections.cmd.CommandText = "SELECT * FROM " + tableName;                    //Get current table data
                    SqlConnections.da.SelectCommand = SqlConnections.cmd;                             //Select command
                    SqlConnections.da.Fill(SqlConnections.ds, tableName);                             //Fill dataAdapter with current table data
                    dataSource.Name = dataSetName;                                                    //Set dataSource name
                    dataSource.Value = SqlConnections.ds.Tables[tableName];                           //Set dataSource value

                    reportViewer.LocalReport.DataSources.Add(dataSource);                             //Add dataSource to reportViewer
                }

                SetDataSource("Отгрузка", "DataSet_Shipment", shipment);                              //Setup DataSource with shipment table data
                SetDataSource("Оплата", "DataSet_Payment", payment);                                  //Setup DataSource with payment table data
                SetDataSource("Клиенты", "DataSet_Clients", clients);                                 //Setup DataSource with clients table data
                SetDataSource("Склад", "DataSet_Storage", storage);                                   //Setup DataSource with storage table data
                SetDataSource("Содержимое_склада", "DataSet_StorageContains", storageContains);       //Setup DataSource with storageContains table data
                SetDataSource("Счет_клиента", "DataSet_ClientBalance", clientBalance);                //Setup DataSource with clientBalance table data

                if ((parms != null))                                                                  //If there's a parm block, set that
                {
                    reportViewer.LocalReport.SetParameters(parms);                                    //Send parameters to the report
                }

                this.Show();                                                                          //Display the report
                reportViewer.RefreshReport();                                                         //Load up the report with data
            }
        }

        public void BuildReport()                                                                     //Build report with current table data
        {
            SqlConnections.ds = new DataSet();                                                        //Refresh dataSet
            SqlConnections.da = new SqlDataAdapter();                                                 //Refresh dataAdapter
            SqlConnections.sql = "SELECT * FROM " + curTable;                                         //Query - select data from current table
            SqlConnections.cmd.CommandText = SqlConnections.sql;                                      //Apply query as a command text
            SqlConnections.da.SelectCommand = SqlConnections.cmd;                                     //Select command
            SqlConnections.da.Fill(SqlConnections.ds, curTable);                                      //Fill dataAdapter with current table data

            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);     //Nesessary line for reportViewer to work in WinForms
            SetupReport(reportName, "DataSet1", SqlConnections.ds.Tables[0], null);                   //Setup current table report
            //this.reportViewer.RefreshReport();

            void SetupReport(string reportName, string rdsName, object rdsValue, List<ReportParameter> parms)
            {
                reportViewer.ProcessingMode = ProcessingMode.Local;                                   // Set the processing mode for the ReportViewer to Local 
                // Set the local report path for the ReportViewer
                //reportViewer.LocalReport.ReportPath = Path.Combine("C:\\Users\\Gwynbleidd\\source\\repos\\DBClient\\DBClient\\Report.rdlc");

                ReportDataSource rds = new ReportDataSource();                                        //New report dataSource
                reportViewer.LocalReport.ReportEmbeddedResource = reportName;                         //Get report name
                reportViewer.LocalReport.DataSources.Clear();                                         //remove default reportdatasource

                rds.Name = rdsName;                                                                   //configure the new reportdatasource, set rds name
                rds.Value = rdsValue;                                                                 //configure the new reportdatasource, set rds value

                reportViewer.LocalReport.DataSources.Add(rds);                                        //Add new report dataSource to the report

                if ((parms != null))                                                                  //if there's a parm block, set that
                {
                    reportViewer.LocalReport.SetParameters(parms);                                    //Send parameters to the report
                }

                this.Show();                                                                          //Display the report
                reportViewer.RefreshReport();                                                         //Load up the report with data
                //cGeneral.ms(0);
            }
        }

        private void updateTableList()                                                                //Get table names from database
        {
            SqlConnections.cmd.CommandText = "SELECT * FROM sys.objects WHERE type='U';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) != "Менеджеры" && reader.GetString(0) != "sysdiagrams" && reader.GetString(0) != "Товар" && reader.GetString(0) != "Склад")
                    {
                        tableList.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }

            //tableList.Items.Add("Клиенты (общ)");
        }

        #region AppButtons
        private void minimizeButton_Click(object sender, EventArgs e)                                 //Application minimize button
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)                                     //Application exit button
        {
            this.Close();
        }
        #endregion AppButtons

        private void tableList_SelectedIndexChanged(object sender, EventArgs e)                       //Supporting function for BuildReport(), choosing tables
        {
            curTable = tableList.SelectedItem.ToString();                                             //Set current table value to the chosen table name

            if (curTable == "Отгрузка")                                                               //Get the report for the chosen table
                reportName = "DBClient.reportShipment.rdlc";
            if (curTable == "Оплата")                                                                 //Get the report for the chosen table
                reportName = "DBClient.reportPayment.rdlc";


            //if (curTable == "Клиенты (общ)")
            //    reportName = "DBClient.reportClients.rdlc";
            //........
            //Осталось собрать alter tables, объединив, например, клиента и счет клиента. Только как вывести из этих tables значения в таблицу отчета

            BuildReport();                                                                            //Rebuild report for the chosen table
        }

        #region Style
        public void ChangeStyle()                                                                     //Changing application style
        {
            foreach (Control item in Controls)
            {
                if (item is Panel && item.Name.Contains("Header"))
                {
                    item.BackColor = MainForm.appColor;
                    if (MainForm.appColor == Color.FromArgb(228, 231, 235)) { minimizeButton.Image = Properties.Resources.darkMinimizeIcon; exitButton.Image = Properties.Resources.darkCloseIcon; appName.ForeColor = Color.FromArgb(37, 46, 59); appLogo.Image = Properties.Resources.promekzLogoGray; }
                    else { minimizeButton.Image = Properties.Resources.minimizeIcon; exitButton.Image = Properties.Resources.closeIcon; appName.ForeColor = Color.White; appLogo.Image = Properties.Resources.promekzAppLogo; }
                }
                if (item is PictureBox && !item.Name.Contains("Avatar"))
                    item.BackColor = MainForm.appColor;
            }

            totalReportButton.BackColor = MainForm.appColor;
            totalReportButton.colselected = MainForm.appColor;
            totalReportButton.colhover = MainForm.appColor;
            totalReportButton.colbackground = MainForm.appColor;
            if (MainForm.appColor == Color.FromArgb(6, 181, 126))
            { totalReportButton.ForeColor = Color.FromArgb(89, 205, 169); totalReportButton.OnHovercolor = Color.FromArgb(89, 205, 169); totalReportButton.Textcolor = Color.White; totalReportButton.OnHoverTextColor = Color.White; }
            else if (MainForm.appColor == Color.FromArgb(228, 231, 235))
            { totalReportButton.ForeColor = Color.FromArgb(152, 154, 156); totalReportButton.OnHovercolor = Color.FromArgb(152, 154, 156); totalReportButton.Textcolor = Color.FromArgb(37, 46, 59); totalReportButton.OnHoverTextColor = Color.FromArgb(37, 46, 59); }
            else { totalReportButton.ForeColor = Color.FromArgb(85, 153, 221); totalReportButton.OnHovercolor = Color.FromArgb(85, 153, 221); totalReportButton.Textcolor = Color.White; totalReportButton.OnHoverTextColor = Color.White; }

            BackColor = Color.FromArgb(37, 46, 59);
        }
        #endregion Style

        private void totalReportButton_Click(object sender, EventArgs e)                              //Build total report
        {
            try
            {
                TotalReport(parms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void reportViewer_ReportExport(object sender, ReportExportEventArgs e)                //Override default export event
        {
            e.Cancel = true;

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            ThreadStart tStart = new ThreadStart(Save);
            Thread thread = new Thread(tStart);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            void Save()
            {
                //string deviceInfo = "<DeviceInfo>" +
                // "  <OutputFormat>PDF</OutputFormat>" +
                // "  <PageWidth>8.27in</PageWidth>" +
                // "  <PageHeight>11.69in</PageHeight>" +
                // "  <MarginTop>0.25in</MarginTop>" +
                // "  <MarginLeft>0.4in</MarginLeft>" +
                // "  <MarginRight>0in</MarginRight>" +
                // "  <MarginBottom>0.25in</MarginBottom>" +
                // "  <EmbedFonts>None</EmbedFonts>" +
                // "</DeviceInfo>";
                //string mimeType;
                //string encoding;
                //string fileNameExtension;
                //Warning[] warnings;
                //string[] streams;

                //byte[] byteViewerPDF = reportViewer.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);

                byte[] byteViewerPDF = reportViewer.LocalReport.Render("PDF");
                byte[] byteViewerExcel = reportViewer.LocalReport.Render("Excel");
                byte[] byteViewerWord = reportViewer.LocalReport.Render("Word");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Отчет за " + DateTime.Now.ToString("dd.MM.yyyy");
                saveFileDialog.InitialDirectory = folderPath;
                saveFileDialog.RestoreDirectory = true;

                if (e.Extension.Name == "PDF")
                    saveFileDialog.Filter = "Файлы PDF (*.pdf) | *.pdf |Все файлы (*.*) | *.*";
                else if (e.Extension.Name == "EXCELOPENXML")
                    saveFileDialog.Filter = "Файлы MS Excel (*.xls) | *.xls |Все файлы (*.*) | *.*";
                else if (e.Extension.Name == "WORDOPENXML")
                    saveFileDialog.Filter = "Файлы MS Word (*.doc) | *.doc |Все файлы (*.*) | *.*";

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    switch (e.Extension.Name)
                    {
                        case "PDF":
                            FileStream newPDFFile = new FileStream(saveFileDialog.FileName, FileMode.Create);
                            newPDFFile.Write(byteViewerPDF, 0, byteViewerPDF.Length);
                            newPDFFile.Close();
                            break;
                        case "EXCELOPENXML":
                            FileStream newExcelFile = new FileStream(saveFileDialog.FileName, FileMode.Create);
                            newExcelFile.Write(byteViewerExcel, 0, byteViewerExcel.Length);
                            newExcelFile.Close();
                            break;
                        case "WORDOPENXML":
                            FileStream newDocFile = new FileStream(saveFileDialog.FileName, FileMode.Create);
                            newDocFile.Write(byteViewerWord, 0, byteViewerWord.Length);
                            newDocFile.Close();
                            break;
                    }
                    savedReports.Add(saveFileDialog.FileName);
                }
            }
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveReportLog();
            void SaveReportLog()
            {
                string logPath = folderPath + "Сохраненные отчеты.log";
                if (!File.Exists(logPath)) File.Create(logPath).Close();

                StreamWriter sw = File.AppendText(logPath);
                foreach (string path in savedReports)
                    sw.WriteLine(path);
                sw.Close();
            }
            savedReports.Clear();
        }
    }
}
