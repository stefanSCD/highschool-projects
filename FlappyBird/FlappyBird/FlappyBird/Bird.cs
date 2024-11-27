using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    public class Bird
    {
        public int X, Y, Latime, Inaltime;
        public int Gravitatia, VitezaY, VitezaAripi;
        public Bird(int x,int y)
        {
            this.X = x;
            this.Y = y;
            Inaltime = 30;
            Latime = 30;
            VitezaAripi = -10;
            VitezaY = 0;
            Gravitatia = 1;
        }
        public void Deseneaza(Graphics g)
        {
            g.DrawImage(FlappyBird.Properties.Resources.FlappyBird, X, Y, Latime, Inaltime);
        }
        
        public void Miscare()
        {
            VitezaY += Gravitatia;
            this.Y += VitezaY;
        }

        public void MiscareAripi()
        {
            VitezaY = VitezaAripi;
            this.Y += VitezaY;
        }

        public bool LovitSol()
        {
            return (this.Y >= SOL.Y);
        }

        public bool LovitTurnuri(PerecheTurnuri pereche)
        {
            if(X+Latime>=pereche.turnsus.X && X <= pereche.turnsus.X + pereche.turnsus.Latime)
            {
                if (Y <= pereche.turnsus.Inaltime) return true;
            }
            if (X + Latime >= pereche.Turnjos.X && X <= pereche.Turnjos.X + pereche.Turnjos.Latime)
            {
                if (Y + Inaltime >= SOL.Y - pereche.Turnjos.Inaltime) return true;
            }
            return false;
        }
    }
}
