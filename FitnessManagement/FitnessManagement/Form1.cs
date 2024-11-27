using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FitnessManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            string folder = Application.StartupPath;
            folder = Path.Combine(folder, "Imagini");
            folder = Path.Combine(folder, "push-pull-legs.jpg");
            ImgAntrenamente.img1 = folder;
            folder = Application.StartupPath;
            folder = Path.Combine(folder, "Imagini");
            folder = Path.Combine(folder, "6weekplanembed-4708c1b8355640e3a6a27db07d6c6a0c.jpg");
            ImgAntrenamente.img2 = folder;
            folder = Application.StartupPath;
            folder = Path.Combine(folder, "Imagini");
            folder = Path.Combine(folder, "c8b33d555cd8ec4c569d8cdfc4ed6dc1.jpg");
            ImgAntrenamente.img3 = folder;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panel1.Width += 3;
            if (panel1.Width >= 599)
            {
                timer1.Stop();
                Logare frm = new Logare();
                frm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
