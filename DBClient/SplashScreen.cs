using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using Bunifu.Framework.Lib;
using Bunifu.Framework.UI;

namespace DBClient
{
    public partial class SplashScreen : Form
    {
        List<Color> colors = new List<Color>();
        public SplashScreen()
        {
            colors.Add(Color.FromArgb(0, 102, 204));
            colors.Add(Color.FromArgb(83, 112, 191));
            colors.Add(Color.FromArgb(82, 148, 191));
            colors.Add(Color.FromArgb(82, 184, 191));
            colors.Add(Color.FromArgb(82, 191, 162));
            colors.Add(Color.FromArgb(82, 191, 126));
            colors.Add(Color.FromArgb(82, 191, 90));
            colors.Add(Color.FromArgb(112, 191, 83));
            colors.Add(Color.FromArgb(148, 191, 82));
            colors.Add(Color.FromArgb(184, 191, 82));
            colors.Add(Color.FromArgb(191, 162, 82));
            colors.Add(Color.FromArgb(191, 126, 82));

            InitializeComponent();
        }

        int curColor = 0;
        int loop = 0;

        private void fader_Tick(object sender, EventArgs e)
        {
            fader.Enabled = false;
            if (curColor < colors.Count-1)
            {
                BackColor = BunifuColorTransition.getColorScale(loop, colors[curColor], colors[curColor + 1]);
                if (loop < 100) { loop++; }
                else { loop = 0; curColor++; }

                fader.Enabled = true;
            }
            else { }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SplashScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
