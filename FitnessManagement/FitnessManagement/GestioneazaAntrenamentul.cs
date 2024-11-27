using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessManagement
{
    public partial class GestioneazaAntrenamentul : Form
    {
        public GestioneazaAntrenamentul(Administrator frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.tabControl1.Visible = false;
        }
        Administrator frm;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabControl1.SelectedIndex = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabControl1.SelectedIndex = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string cale = openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(cale);
                ImgAntrenamente.img3 = cale;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string cale = openFileDialog1.FileName;
                this.pictureBox2.Image = Image.FromFile(cale);
                ImgAntrenamente.img2 = cale;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string cale = openFileDialog1.FileName;
                this.pictureBox3.Image = Image.FromFile(cale);
                ImgAntrenamente.img1 = cale;
            }
        }
    }
}
