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
    public partial class StatisticaUtilizatori : Form
    {
        public StatisticaUtilizatori(Administrator frm)
        {
            InitializeComponent();
            this.frm = frm;
            dt = new DataSet1.StatisticaDataTable();
            tba = new DataSet1TableAdapters.StatisticaTableAdapter();
            tba.Fill(dt);
            this.chart1.Series.Clear();
            this.chart1.Series.Add("Utilizatori");
            this.chart1.DataSource = dt;
            this.chart1.Series["Utilizatori"].XValueMember = "Nume";
            this.chart1.Series["Utilizatori"].YValueMembers = "Varsta";
            this.chart1.Series["Utilizatori"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
        Administrator frm;
        DataSet1TableAdapters.StatisticaTableAdapter tba;
        DataSet1.StatisticaDataTable dt;
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
    }
}
