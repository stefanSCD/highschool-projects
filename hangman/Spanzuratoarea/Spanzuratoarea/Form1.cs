using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanzuratoarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IncarcaCMB();
            this.comboBox1.SelectedIndex = 0;
        }
        public string domeniu;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.domeniu = this.comboBox1.Text;
            SpanzuratoareaJOC frm = new SpanzuratoareaJOC(this);
            frm.Show();
            this.Hide();
        }

        private void IncarcaCMB()
        {
            this.comboBox1.Items.Add("Țări și Capitale");
            this.comboBox1.Items.Add("Nume de animale");
            this.comboBox1.Items.Add("Meserii");
            this.comboBox1.Items.Add("Nume de plante");
            this.comboBox1.Items.Add("Vedete de film");
            this.comboBox1.Items.Add("Mărci de mașini");
            this.comboBox1.Items.Add("Cuvinte din domeniul tehnologic");
            this.comboBox1.Items.Add("Nume de fructe și legume");
            this.comboBox1.Items.Add("Cuvinte asociate cu sportul");
            this.comboBox1.Items.Add("Nume de orașe");
            this.comboBox1.Items.Add("Nume de culori");
            this.comboBox1.Items.Add("Părți ale corpului");
            this.comboBox1.Items.Add("Cuvinte din domeniul alimentației");
            this.comboBox1.Items.Add("Nume de branduri de îmbrăcăminte");
        }
    }
}
