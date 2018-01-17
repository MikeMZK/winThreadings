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

        public frmMain()
        {
            InitializeComponent();

            rnd = new Random();
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
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 20, 20));
                Thread.Sleep(100); 
            }

            MessageBox.Show("Rot fertig", "Rot fertig", MessageBoxButtons.OK);
        }
        private void Blau()
        {
            for (int i = 0; i < 50; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }

            MessageBox.Show("Blau fertig", "Blau fertig", MessageBoxButtons.OK);
        }

    }
}
