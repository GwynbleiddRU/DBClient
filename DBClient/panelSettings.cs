using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace DBClient
{
    public partial class panelSettings : UserControl
    {
        MainForm mainForm;

        public panelSettings()
        {
            InitializeComponent();
        }

        public panelSettings(Form parent)
        {
            InitializeComponent();
            mainForm = (MainForm)parent;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        public void ChangeStyle()
        {
            //panelHeader.BackColor = DBClient.appColor;
            //DBClient frm = (DBClient)Application.OpenForms["DBClient"];
            //frm.panelHeader.BackColor = DBClient.appColor;

            foreach (Control item in Controls)
            {
                if (item is PictureBox)
                {
                    item.BackColor = MainForm.appColor;
                }
                if (item is BunifuCheckbox)
                {
                    //item.BackColor = Color.Gainsboro;
                    var temp = item as BunifuCheckbox;
                    temp.ChechedOffColor = Color.Gainsboro;
                    temp.CheckedOnColor = MainForm.appColor;
                    if (MainForm.appColor == Color.FromArgb(228, 231, 235))
                        temp.ForeColor = Color.FromArgb(37, 46, 59);
                    else temp.ForeColor = Color.Gainsboro;
                }
                if (item.Name.Contains("header"))
                    item.ForeColor = MainForm.appColor;
            }
            BackColor = Color.FromArgb(37, 46, 59);
        }

        #region AppModeCheckBox
        private void complexModeCheckBox_OnChange(object sender, EventArgs e)
        {
            simpleModeCheckBox.Checked = false;
            if (!complexModeCheckBox.Checked || !simpleModeCheckBox.Checked)  //Disable both checkBoxes of being unchecked
            {
                complexModeCheckBox.Checked = true;
                complexModeNotifyLabel.Visible = true;
            }
            MainForm.workMode = "complex";
        }

        private void simpleModeCheckBox_OnChange(object sender, EventArgs e)
        {
            complexModeCheckBox.Checked = false;
            if (!complexModeCheckBox.Checked || !simpleModeCheckBox.Checked)  //Disable both checkBoxes of being unchecked
            {
                simpleModeCheckBox.Checked = true;
                complexModeNotifyLabel.Visible = false;
            }
            MainForm.workMode = "simple";
        }
        #endregion AppModeCheckBox

        #region AppColorCheckBox
        private void promekzColorCheckBox_OnChange(object sender, EventArgs e)
        {
            greenColorCheckBox.Checked = false;
            blueColorCheckBox.Checked = false;
            if (!promekzColorCheckBox.Checked || !greenColorCheckBox.Checked || !blueColorCheckBox.Checked)  //Disable both checkBoxes of being unchecked
            {
                promekzColorCheckBox.Checked = true;
            }
            MainForm.appColor = Color.FromArgb(228, 231, 235);
            ChangeStyle();
        }

        private void greenColorCheckBox_OnChange(object sender, EventArgs e)
        {
            promekzColorCheckBox.Checked = false;
            blueColorCheckBox.Checked = false;
            if (!promekzColorCheckBox.Checked || !greenColorCheckBox.Checked || !blueColorCheckBox.Checked)  //Disable both checkBoxes of being unchecked
            {
                greenColorCheckBox.Checked = true;
            }
            MainForm.appColor = Color.FromArgb(6, 181, 126);
            ChangeStyle();
        }

        private void blueColorCheckBox_OnChange(object sender, EventArgs e)
        {
            promekzColorCheckBox.Checked = false;
            greenColorCheckBox.Checked = false;
            if (!promekzColorCheckBox.Checked || !greenColorCheckBox.Checked || !blueColorCheckBox.Checked)  //Disable both checkBoxes of being unchecked
            {
                blueColorCheckBox.Checked = true;
            }
            MainForm.appColor = Color.FromArgb(0, 102, 204);
            ChangeStyle();
        }
        #endregion AppColorCheckBox

        #region JournalFormatCheckBox

        private void txtJournalCheckBox_OnChange(object sender, EventArgs e)
        {
            logJournalCheckBox.Checked = false;
            docJournalCheckBox.Checked = false;
            if (!txtJournalCheckBox.Checked || !logJournalCheckBox.Checked || !docJournalCheckBox.Checked)  //Disable both checkBoxes of being unchecked
            {
                txtJournalCheckBox.Checked = true;
                MainForm.journalFormat = ".txt";
            }
        }

        private void logJournalCheckBox_OnChange(object sender, EventArgs e)
        {
            txtJournalCheckBox.Checked = false;
            docJournalCheckBox.Checked = false;
            if (!txtJournalCheckBox.Checked || !logJournalCheckBox.Checked || !docJournalCheckBox.Checked)  //Disable both checkBoxes of being unchecked
            {
                logJournalCheckBox.Checked = true;
                MainForm.journalFormat = ".log";
            }
        }

        private void docJournalCheckBox_OnChange(object sender, EventArgs e)
        {
            logJournalCheckBox.Checked = false;
            txtJournalCheckBox.Checked = false;
            if (!txtJournalCheckBox.Checked || !logJournalCheckBox.Checked || !docJournalCheckBox.Checked)  //Disable both checkBoxes of being unchecked
            {
                docJournalCheckBox.Checked = true;
                MainForm.journalFormat = ".doc";
            }
        }

        #endregion JournalFormatCheckBox

        private void Settings_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();

            if (SqlConnections.rights == "user")
            {
                complexModeCheckBox.Enabled = false;
                notifyRightsLabel.Visible = true;
            }
            else
            {
                complexModeCheckBox.Enabled = true;
                notifyRightsLabel.Visible = false;
            }
        }
    }
}
