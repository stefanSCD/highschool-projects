using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class Form2 : Form
    {
        public Form2(Form1 frm)
        {
            InitializeComponent();
            IncarcaComboBox();
            DB.IncarcaMasini();
        }
        public DateTime start, final;
        public string locatie;
        private void IncarcaComboBox()
        {
            
            this.comboBox1.Items.Add("Aeroport Otopeni - Bucuresti");
            this.comboBox1.Items.Add("Aeroport Sibiu");
            this.comboBox1.Items.Add("Aeroport Cluj");
            this.comboBox1.Items.Add("Aeroport Iasi");
            this.comboBox1.Items.Add("Aeroport Oradea");
            this.comboBox1.Items.Add("Aeroport Timisoara");
            this.comboBox1.Items.Add("Aeroport Arad");
            this.comboBox1.Items.Add("Aeroport Craiova");
            this.comboBox1.SelectedIndex = 0;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.start = this.dateTimePicker1.Value;
            this.final = this.dateTimePicker2.Value;
            this.locatie = this.comboBox1.Text;
            int nrzile = final.Day - start.Day;
            if (nrzile <= 0)
            {
                MessageBox.Show("Data de sfarsit nu poate fi mai mica sau egala decat cea de incaput!");
            }
            else
            {
                Form3 frm = new Form3(this);
                frm.Show();
                this.Hide();
            }
        }
    }
}
