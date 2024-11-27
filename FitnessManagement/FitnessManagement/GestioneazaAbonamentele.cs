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
    public partial class GestioneazaAbonamentele : Form
    {
        public GestioneazaAbonamentele(Administrator frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.tabControl1.Visible = false;
            tableAdapter = new DataSet1TableAdapters.AbonamenteTableAdapter();
            dt = new DataSet1.AbonamenteDataTable();
            tba = new DataSet1TableAdapters.UtilizatoriTableAdapter();
            dtUt = new DataSet1.UtilizatoriDataTable();
            tba.Fill(dtUt);
            this.comboBox1.DataSource = dtUt;
            this.comboBox1.DisplayMember = "NumeUtilizator";
        }
        int id;
        Administrator frm;
        DataSet1TableAdapters.AbonamenteTableAdapter tableAdapter;
        DataSet1TableAdapters.UtilizatoriTableAdapter tba;
        DataSet1.UtilizatoriDataTable dtUt;
        DataSet1.AbonamenteDataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            tableAdapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView2.DataSource = dt;
            this.dataGridView3.DataSource = dt;
            this.dataGridView4.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            id = (int)tba.GetIdByNU(this.comboBox1.Text);
            tableAdapter.Insert(id, this.comboBox2.Text, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            tableAdapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView2.DataSource = dt;
            this.dataGridView3.DataSource = dt;
            this.dataGridView4.DataSource = dt;
            MessageBox.Show("Abonament adaugat cu succes!");
        }
        int ii;
        private void button8_Click(object sender, EventArgs e)
        {

            tableAdapter.UpdateData(this.dateTimePicker4.Value, this.dateTimePicker3.Value, this.comboBox3.Text,ii);
            MessageBox.Show("Abonament modificat cu succes");
            tableAdapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView2.DataSource = dt;
            this.dataGridView3.DataSource = dt;
            this.dataGridView4.DataSource = dt;
        }


        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ii = int.Parse(this.dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            DateTime x = DateTime.Parse( this.dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString());
            DateTime y = DateTime.Parse( this.dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString());
            this.dateTimePicker4.Value = x;
            this.dateTimePicker3.Value = y;
            this.comboBox3.Text = this.dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iz= int.Parse(this.dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString());
            tableAdapter.DeletEAB(iz);
            MessageBox.Show("Abonament sters cu succes!");
            tableAdapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView2.DataSource = dt;
            this.dataGridView3.DataSource = dt;
            this.dataGridView4.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = false;
        }
    }
}
