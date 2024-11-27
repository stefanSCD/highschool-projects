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
    public partial class VizualizeazaAntrenamentul : Form
    {
        public VizualizeazaAntrenamentul(Utilizator frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        Utilizator frm;
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.Text== "Pierdere in greutate")
            {
                this.pictureBox1.Image = Image.FromFile(ImgAntrenamente.img3);
            }
            else if(this.comboBox1.Text== "Mentinere greutate")
            {
                this.pictureBox1.Image = Image.FromFile(ImgAntrenamente.img2);
            }
            else if (this.comboBox1.Text == "Crestere in greutate")
            {
                this.pictureBox1.Image = Image.FromFile(ImgAntrenamente.img1);
            }
        }
    }
}
