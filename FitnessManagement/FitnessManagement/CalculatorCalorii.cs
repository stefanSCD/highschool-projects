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
    public partial class CalculatorCalorii : Form
    {
        public CalculatorCalorii(Utilizator frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.radioButton1.Checked = true;
        }
        Utilizator frm;

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox4.Text == "")
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
                return;
            }
            double BMR=0,total=0;
            double greutate = double.Parse(this.textBox3.Text);
            double inaltime = double.Parse(this.textBox2.Text);
            double varsta = double.Parse(this.textBox4.Text);
            if (this.radioButton1.Checked == true)
            {
                BMR = (10 * greutate) + (6.25 * inaltime) - (5 * varsta) + 5;
            }
            else if (this.radioButton2.Checked == true)
            {
                BMR = (10 * greutate) + (6.25 * inaltime) - (5 * varsta) - 161;
            }
            if(this.comboBox1.Text== "Sedentar (puțin sau deloc exercițiu)")
            {
                total = BMR * 1.2;
            }
            else if(this.comboBox1.Text== "Activitate ușoară (exercițiu ușor/sport 1-3 zile pe săptămână)")
            {
                total = BMR * 1.375;
            }
            else if(this.comboBox1.Text== "Moderat activ (exercițiu moderat/sport 3-5 zile pe săptămână)")
            {
                total = BMR * 1.55;
            }
            else if(this.comboBox1.Text== "Foarte activ (exercițiu intens/sport 6-7 zile pe săptămână)")
            {
                total = BMR * 1.725;
            }
            else if(this.comboBox1.Text== "Extrem de activ (exercițiu foarte intens/zilnic, activitate fizică foarte solicitantă)")
            {
                total = BMR * 1.9;
            }
            this.textBox1.Text = total.ToString();
        }
    }
}
