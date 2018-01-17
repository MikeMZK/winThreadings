using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace winThreadings
{
    public partial class frmMain : Form
    {
        Stopwatch sw = new Stopwatch();
        string currenttime = "00:00:00";

        public frmMain()
        {
            InitializeComponent();
            lblStoppuhr.Text = currenttime;
            timerT.Interval = 1;
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ThreadMethod);
            timerT.Enabled = true;
            th.Start();
        }

        private void ThreadMethod()
        {
            sw.Start();
            Thread.Sleep(2132);

            TimeSpan ts = sw.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            currenttime = elapsedTime;

            sw.Stop();
        }

        private void timerT_Tick(object sender, EventArgs e)
        {
            lblStoppuhr.Text = currenttime;
        }
    }
}
