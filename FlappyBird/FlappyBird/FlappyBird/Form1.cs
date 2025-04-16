using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            lista = new List<PerecheTurnuri>();
            L = this.pictureBox1.Width;
            H = this.pictureBox1.Height;
            SOL.Latime = L;
            SOL.Inaltime = 50;
            SOL.Y = H - SOL.Inaltime;
            pasare = new Bird(L / 2, H / 2);
        }
        int L, H;
        List<PerecheTurnuri> lista;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SOL.Deseneaza(g);
            pasare.Deseneaza(g);
            for(int i = 0; i < lista.Count; i++)
            {
                lista[i].DeseneazaTurnuri(g);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pasare.Miscare();
            pictureBox1.Refresh();
            for(int i = 0; i < lista.Count; i++)
            {
                lista[i].Miscare();
            }
            VerificaLovire();
            
            
        }

        private void VerificaLovire()
        {
            bool lovit = false;
            if (pasare.LovitSol()) lovit = true;
            for(int i = 0; i < lista.Count; i++)
            {
                if (pasare.LovitTurnuri(lista[i])) lovit = true;
            }
            if (lovit)
            {
                lista.Clear();
                pasare = new Bird(L / 2, H / 2);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pasare.MiscareAripi();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PerecheTurnuri pereche = new PerecheTurnuri(L);
            lista.Add(pereche);
            if (lista[0].turnsus.X + lista[0].turnsus.Latime < 0)
            {
                lista.RemoveAt(0);
            }
        }

        Bird pasare;
    }
}
