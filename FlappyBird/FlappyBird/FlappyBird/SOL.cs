using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    public static class SOL
    {
        public static int Y, Latime, Inaltime;
        public static void Deseneaza(Graphics g)
        {
            g.DrawImage(FlappyBird.Properties.Resources.Iarba, 0, Y, Latime, 100);
        }
    }
}
