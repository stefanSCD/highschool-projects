using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FitnessManagement
{
    public  class TurnSus
    {
        public static int InaltimeMinima = 50;
        public int Inaltime, X, Latime;
        public static int Viteza=5;
        public TurnSus(int X,int Inaltime)
        {
            this.X = X;
            this.Inaltime = Inaltime;
            this.Latime = 75;
        }
        
        public void Deseneaza(Graphics g)
        {
            g.DrawImage(FitnessManagement.Properties.Resources.TurnMijloc2, this.X, 0, Latime, Inaltime - TurnSus.InaltimeMinima + 5);
            g.DrawImage(FitnessManagement.Properties.Resources.TurnCapat2, this.X, Inaltime - TurnSus.InaltimeMinima, Latime, TurnSus.InaltimeMinima);
        }

        public void MiscareTurn()
        {
            this.X -= Viteza;
        }
    }
}
