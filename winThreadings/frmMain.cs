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
        Thread rot;
        Thread blau;
        Random rnd;
        Draw d;

        public frmMain()
        {
            InitializeComponent();

            rnd = new Random();
            d = new Draw(pbHintergrund);
        }

        private void btnRot_Click(object sender, EventArgs e)
        {
            rot = new Thread(Rot);
            rot.Start();
        }
        private void btnBlau_Click(object sender, EventArgs e)
        {
            blau = new Thread(Blau);
            blau.Start();
        }

        private void Rot()
        {
            for (int i = 0; i < 50; i++)
            {
                d.DrawRectangle(20, 20, Brushes.Red);
                Thread.Sleep(100);
            }

            MessageBox.Show("Rot fertig", "Rot fertig", MessageBoxButtons.OK);
        }
        private void Blau()
        {
            for (int i = 0; i < 50; i++)
            {
                d.DrawRectangle(20, 20, Brushes.Blue);
                Thread.Sleep(100);
            }

            MessageBox.Show("Blau fertig", "Blau fertig", MessageBoxButtons.OK);
        }

    }
}
