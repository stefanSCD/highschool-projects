using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FitnessManagement
{
    static class Punctaj
    {
        public static int Valoare = 0;
        public static int ValoareMaxima = 0;

        public static void DeseneazaPunctaj(Graphics g)
        {
            Font font = new Font("Times New Roman", 20);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString("Punctaj curent: " + Valoare.ToString(), font, drawBrush, 10, 10);
            g.DrawString("Punctaj maxim: " + ValoareMaxima.ToString(), font, drawBrush, 10, 40);
        }
        public static void ReinitializarePunctaj()
        {
            if (Valoare > ValoareMaxima)
            {
                ValoareMaxima = Valoare;
            }
            Valoare = 0;
        }

    }

}
