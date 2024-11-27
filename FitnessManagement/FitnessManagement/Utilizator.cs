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
    public partial class Utilizator : Form
    {
        public Utilizator(Logare frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.label3.Text = "Utilizator : " + frm.nume;
            tba = new DataSet1TableAdapters.AbonamenteTableAdapter();
            tbaUT = new DataSet1TableAdapters.UtilizatoriTableAdapter();
        }
        Logare frm;
        DataSet1TableAdapters.AbonamenteTableAdapter tba;
        DataSet1TableAdapters.UtilizatoriTableAdapter tbaUT;

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

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatorCalorii frm = new CalculatorCalorii(this);
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime x = DateTime.Now;
            int id = (int) tbaUT.GetIdByNU(frm.nume);
            if ((int)tba.CheckAbonament(x, id) > 0)
            {
                MessageBox.Show("Abonamentul dumneavoastra este ACTIV");
            }
            else
            {
                MessageBox.Show("Abonamentul dumneavoastra este INACTIV");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VizualizeazaAntrenamentul frm = new VizualizeazaAntrenamentul(this);
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FlappyBird frm = new FlappyBird(this);
            frm.Show();
            this.Hide();
        }
    }
}
