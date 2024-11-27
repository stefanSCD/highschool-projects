using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    public class TurnJos
    {
        public int X, Inaltime, Latime;
        public static int InaltimeMinima = 50;
        static int Viteza = 5;
        public TurnJos(int x,int inaltime)
        {
            this.X = x;
            this.Inaltime = inaltime;
            this.Latime = 75;
        }

        public void Deseneaza(Graphics g)
        {
            g.DrawImage(FlappyBird.Properties.Resources.TurnMijloc1, this.X, SOL.Y - Inaltime + TurnJos.InaltimeMinima, Latime, Inaltime - TurnJos.InaltimeMinima);
            g.DrawImage(FlappyBird.Properties.Resources.TurnCapat1, this.X, SOL.Y - Inaltime, Latime, TurnJos.InaltimeMinima);
        }

        public void Miscare()
        {
            this.X -= Viteza;
        }
    }
}
