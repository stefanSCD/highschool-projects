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
    public partial class GestioneazaUtilizatori : Form
    {
        public GestioneazaUtilizatori(Administrator frm)
        {
            InitializeComponent();
            this.frm = frm;
            UtilizatoriTableAdapter = new DataSet1TableAdapters.UtilizatoriTableAdapter();
            utilizatoriTable = new DataSet1.UtilizatoriDataTable();
            tba = new DataSet1TableAdapters.ConturiTableAdapter();
        }
        Administrator frm;
        DataSet1TableAdapters.UtilizatoriTableAdapter UtilizatoriTableAdapter;
        DataSet1.UtilizatoriDataTable utilizatoriTable;
        DataSet1TableAdapters.ConturiTableAdapter tba;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabUtilizatori.Visible = true;
            UtilizatoriTableAdapter.Fill(utilizatoriTable);
            this.dataGridView1.DataSource = utilizatoriTable;
            UtilizatoriTableAdapter.Fill(utilizatoriTable);
            this.dataGridView2.DataSource = utilizatoriTable;
            this.radioButton1.Checked = true;
            this.radioButton4.Checked = true;
            this.dataGridView3.DataSource = utilizatoriTable;
            this.dataGridView4.DataSource = utilizatoriTable;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tabUtilizatori.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tabUtilizatori.SelectedIndex = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tabUtilizatori.SelectedIndex = 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.tabUtilizatori.SelectedIndex = 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tba.Insert(this.textBox3.Text, this.textBox4.Text, "2");
            if (this.radioButton1.Checked == true) {
                UtilizatoriTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.numericUpDown1.Value.ToString(), "Masculin");
            }
            else if (this.radioButton2.Checked == true)
            {
                UtilizatoriTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.numericUpDown1.Value.ToString(), "Feminin");
            }
            MessageBox.Show("Utilizator adaugat cu succes!");
            UtilizatoriTableAdapter.Fill(utilizatoriTable);
            this.dataGridView1.DataSource = utilizatoriTable;
            this.dataGridView2.DataSource = utilizatoriTable;
            this.dataGridView3.DataSource = utilizatoriTable;
            this.dataGridView4.DataSource = utilizatoriTable;
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.numericUpDown1.Value = 7;
            this.radioButton1.Checked = true;
        }
        int id;
        string numeUtilizator;
        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(this.dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            string nume = this.dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            string prenume = this.dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
             numeUtilizator = this.dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            string parola = this.dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            string varsta = this.dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
            string gen = this.dataGridView3.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.textBox8.Text = nume;
            this.textBox7.Text = prenume;
            this.textBox6.Text = numeUtilizator;
            this.textBox5.Text = parola;
            this.numericUpDown2.Value = int.Parse(varsta);
            if (gen == "Masculin")
            {
                this.radioButton4.Checked = true;
            }
            else if (gen == "Feminin")
            {
                this.radioButton3.Checked = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox8.Text == "" || this.textBox7.Text=="" || this.textBox6.Text == "" || this.textBox5.Text == "")
            {
                MessageBox.Show("Nu ai selectat niciun utilizator sau cel putin un camp este gol!");
                return;
            }
            if (this.radioButton4.Checked == true) {
                UtilizatoriTableAdapter.Modifica(this.textBox8.Text, this.textBox7.Text, this.textBox6.Text, this.textBox5.Text, this.numericUpDown2.Value.ToString(), "Masculin", id);
            }
            else if (this.radioButton3.Checked == true)
            {
                UtilizatoriTableAdapter.Modifica(this.textBox8.Text, this.textBox7.Text, this.textBox6.Text, this.textBox5.Text, this.numericUpDown2.Value.ToString(), "Feminin", id);
            }
            tba.UpdateUtilizator(this.textBox6.Text, this.textBox5.Text, numeUtilizator);
            MessageBox.Show("Utilizator modificat cu succes!");
            UtilizatoriTableAdapter.Fill(utilizatoriTable);
            this.dataGridView1.DataSource = utilizatoriTable;
            this.dataGridView2.DataSource = utilizatoriTable;
            this.dataGridView3.DataSource = utilizatoriTable;
            this.dataGridView4.DataSource = utilizatoriTable;
            this.textBox8.Clear();
            this.textBox7.Clear();
            this.textBox6.Clear();
            this.textBox5.Clear();
            this.numericUpDown2.Value = 7;
            this.radioButton4.Checked = true;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox8.Clear();
            this.textBox7.Clear();
            this.textBox6.Clear();
            this.textBox5.Clear();
            this.numericUpDown2.Value = 7;
            this.radioButton4.Checked = true;
        }

        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string numeUtilizator = this.dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
            int ii = int.Parse(this.dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString());
            UtilizatoriTableAdapter.Delete1(ii);
            tba.DeleteUtilizator(numeUtilizator);
            MessageBox.Show("Utilizator sters cu succes!");
            UtilizatoriTableAdapter.Fill(utilizatoriTable);
            this.dataGridView1.DataSource = utilizatoriTable;
            this.dataGridView2.DataSource = utilizatoriTable;
            this.dataGridView3.DataSource = utilizatoriTable;
            this.dataGridView4.DataSource = utilizatoriTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
