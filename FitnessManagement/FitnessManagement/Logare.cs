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
    public partial class Logare : Form
    {
        public Logare()
        {
            InitializeComponent();
            tba = new DataSet1TableAdapters.ConturiTableAdapter();
        }
        DataSet1TableAdapters.ConturiTableAdapter tba;
        private void Logare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string nume;
        private void button2_Click(object sender, EventArgs e)
        {
            if (tba.count(this.textBox1.Text, this.textBox2.Text) > 0)
            {
                string text = tba.GetIdByNume(this.textBox1.Text);
                int id = int.Parse(text);
                if (id == 1)
                {
                    nume = this.textBox1.Text;
                    Administrator frm = new Administrator(this);
                    frm.Show();
                    this.Hide();
                    this.textBox1.Clear();
                    this.textBox2.Clear();
                }
                else if (id == 2) {
                    nume = this.textBox1.Text;
                    Utilizator frm = new Utilizator(this);
                    frm.Show();
                    this.Hide();
                    this.textBox1.Clear();
                    this.textBox2.Clear();
                }
            }
            else
            {
                this.textBox1.Clear();
                this.textBox2.Clear();
                this.textBox1.Focus();
                MessageBox.Show("Eroare la logare!");
            }
        }
    }
}
