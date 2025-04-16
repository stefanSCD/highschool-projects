using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FitnessManagement
{
    public class PerecheTurnuri
    {
        public TurnSus turnsus;
        public TurnJos Turnjos;
        public int PasajTrecere = 150;
        public bool Numarat = false;
        public PerecheTurnuri(int X)
        {
            Random rnd = new Random();
            int InaltimeTurnSus = TurnSus.InaltimeMinima + rnd.Next(SOL.Y - TurnJos.InaltimeMinima - PasajTrecere);
            int InaltimeTurnJos = SOL.Y - PasajTrecere - InaltimeTurnSus;
            turnsus = new TurnSus(X, InaltimeTurnSus);
            Turnjos = new TurnJos(X, InaltimeTurnJos);
        }

        public void DeseneazaTurnuri(Graphics g)
        {
            Turnjos.Deseneaza(g);
            turnsus.Deseneaza(g);
        }

        public void Miscare()
        {
            turnsus.MiscareTurn();
            Turnjos.Miscare();
        }
    }
}
