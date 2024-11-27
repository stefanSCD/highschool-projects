using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avioane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Image = Avioane.Properties.Resources.Back;
            L = this.pictureBox1.Width;
            H = this.pictureBox1.Height;
            Inamici = new List<Avion>();
            Rachete = new List<Avion>();
            Main = new Avion(L / 2, H - 100, 100, 100, Avioane.Properties.Resources.Plane0);
            timer1.Start();
            timer2.Start();
            Cursor.Hide();
        }
        Avion Main;
        int H, L;
        List<Avion> Inamici;
        List<Avion> Rachete;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Main.Deseneaza(g);
            for(int i = 0; i < Inamici.Count; i++)
            {
                Inamici[i].Deseneaza(g);
            }
            for(int i = 0; i < Rachete.Count; i++)
            {
                Rachete[i].Deseneaza(g);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Main.x = e.X;
            Main.y = e.Y;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            for (int i = 0; i < Inamici.Count; i++)
            {
                Inamici[i].y += 5;
            }
            for(int i = 0; i < Inamici.Count; i++)
            {
                if (Main.Coliziune(Inamici[i]))
                {
                    Inamici.RemoveAt(i);
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Ati pierdut!");
                    this.Close();
                }
            }
            for(int i = 0; i < Rachete.Count; i++)
            {
                Rachete[i].y -= 12;
            }
            for(int i = 0; i < Inamici.Count; i++)
            {
                for(int j = 0; j < Rachete.Count; j++)
                {
                    if (Inamici[i].Coliziune(Rachete[j]))
                    {
                        Inamici.RemoveAt(i);
                        Rachete.RemoveAt(j);
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int pozitie = rnd.Next(L);
            Avion inamic = new Avion(pozitie, -120, 100, 100, Avioane.Properties.Resources.Plane1);
            Inamici.Add(inamic);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Avion racheta = new Avion(Main.x + Main.latime / 2, Main.y, 25, 25, Avioane.Properties.Resources.FireBall3);
            Rachete.Add(racheta);
        }

        
    }
}
