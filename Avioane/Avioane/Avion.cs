using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Avioane
{
    public class Avion
    {
        public int x, y;
        public int latime, inaltime;
        public Image img;
        public Avion(int x,int y,int latime,int inaltime, Image img)
        {
            this.x = x;
            this.y = y;
            this.latime = latime;
            this.inaltime = inaltime;
            this.img = img;
        }

        public void Deseneaza(Graphics g)
        {
            g.DrawImage(img, x, y, latime, inaltime);
        }

        public bool Coliziune(Avion a)
        {
            if(a.x+a.latime > this.x && a.x < this.x + this.latime)
            {
                if(a.y+a.inaltime>this.y && a.y < this.y + this.inaltime)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
