using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace winThreadings
{
    class Draw
    {
        PictureBox pb;
        Graphics g;
        Random rnd;

        public Draw(PictureBox pb)
        {
            this.pb = pb;
            g = pb.CreateGraphics();

            rnd = new Random();
        }

        public void DrawRectangle(int width, int height, Brush color)
        {
            g.DrawRectangle(new Pen(color, 4), new Rectangle(rnd.Next(0, pb.Width), rnd.Next(0, pb.Height), width, height));
        }

    }
}
