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
    public partial class SpanzuratoareaJOC : Form
    {
        public SpanzuratoareaJOC(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.label2.Text = "Domeniul : " + frm.domeniu;
            GenereazaCuvant();
            this.pictureBox1.Image = Spanzuratoarea.Properties.Resources._1;
            nrGreseli = 0;
            punctaj = 100;
            this.lblPunctaj.Text = "Punctaj : " + punctaj.ToString();
            this.label1.Focus();
        }
        Form1 frm;
        string cuvant;
        char[] cuv,original;
        private void GenereazaCuvant()
        {
            Random rnd = new Random();
            if (frm.domeniu=="Țări și Capitale")
            {
                int pozitie = rnd.Next(Domenii.tariCapitale.Count());
                this.cuvant=Domenii.tariCapitale[pozitie];
            }
            else if(frm.domeniu=="Nume de animale")
            {
                int pozitie = rnd.Next(Domenii.numeAnimale.Count());
                this.cuvant = Domenii.numeAnimale[pozitie];
            }
            else if(frm.domeniu=="Meserii")
            {
                int pozitie = rnd.Next(Domenii.meserii.Count());
                this.cuvant = Domenii.meserii[pozitie];
            }
            else if(frm.domeniu=="Nume de plante")
            {
                int pozitie = rnd.Next(Domenii.numePlante.Count());
                this.cuvant = Domenii.numePlante[pozitie];
            }
            else if( frm.domeniu=="Vedete de film")
            {
                int pozitie = rnd.Next(Domenii.vedeteFilm.Count());
                this.cuvant = Domenii.vedeteFilm[pozitie];
            }
            else if(frm.domeniu=="Mărci de mașini")
            {
                int pozitie = rnd.Next(Domenii.marciMasini.Count());
                this.cuvant = Domenii.marciMasini[pozitie];
            }
            else if(frm.domeniu=="Cuvinte din domeniul tehnologic")
            {
                int pozitie = rnd.Next(Domenii.cuvinteTehnologie.Count());
                this.cuvant = Domenii.cuvinteTehnologie[pozitie];
            }
            else if(frm.domeniu=="Nume de fructe și legume")
            {
                int pozitie = rnd.Next(Domenii.fructeLegume.Count());
                this.cuvant = Domenii.fructeLegume[pozitie];
            }
            else if(frm.domeniu=="Cuvinte asociate cu sportul")
            {
                int pozitie = rnd.Next(Domenii.cuvinteSport.Count());
                this.cuvant=Domenii.cuvinteSport[pozitie];
            }
            else if(frm.domeniu=="Nume de orașe")
            {
                int pozitie = rnd.Next(Domenii.orase.Count());
                this.cuvant = Domenii.orase[pozitie];
            }
            else if(frm.domeniu=="Nume de culori")
            {
                int pozitie = rnd.Next(Domenii.culori.Count());
                this.cuvant = Domenii.culori[pozitie];
            }
            else if(frm.domeniu=="Părți ale corpului")
            {
                int pozitie = rnd.Next(Domenii.partiCorp.Count());
                this.cuvant = Domenii.partiCorp[pozitie];
            }
            else if(frm.domeniu=="Cuvinte din domeniul alimentației")
            {
                int pozitie = rnd.Next(Domenii.alimente.Count());
                this.cuvant = Domenii.alimente[pozitie];
            }
            else if(frm.domeniu=="Nume de branduri de îmbrăcăminte")
            {
                int pozitie = rnd.Next(Domenii.branduriImbracaminte.Count());
                this.cuvant = Domenii.branduriImbracaminte[pozitie];
            }
            cuv = cuvant.ToCharArray();
            original = cuvant.ToCharArray();
            for(int i = 0; i < cuv.Length; i++)
            {
                if ((cuv[i]>='a' && cuv[i]<='z') || (cuv[i]>='A' && cuv[i] <= 'Z'))
                {
                    cuv[i] = '_';
                }
            }
            string c = new string(cuv);
            this.lblCuvant.Text = c;

        }
        int nrGreseli;
        int punctaj;
        private void Verifica(char a)
        {
            int cnt = 0;
            bool exista = false;
            for(int i = 0; i < original.Length; i++)
            {
                char x = char.ToLower(original[i]);
                if (x==a)
                {
                    cuv[i]=original[i];
                    cnt++;
                }
            }
            string c = new string(cuv);
            this.lblCuvant.Text = c;
            for(int i = 0; i < cuv.Length; i++)
            {
                if (cuv[i] == '_')
                {
                    exista = true;
                }
            }
            if (exista == false)
            {
                MessageBox.Show("Felicitari!!\n Ai castigat cu " + punctaj + " puncte!","WINNER!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.Close();
            }
            if (cnt == 0)
            {
                nrGreseli++;
                punctaj -= 5;
                this.lblPunctaj.Text = "Punctaj : " + punctaj.ToString();
            }
            if (nrGreseli == 1)
            {
                this.pictureBox1.Image = Spanzuratoarea.Properties.Resources._2;
            }
            else if (nrGreseli == 2)
            {
                this.pictureBox1.Image = Spanzuratoarea.Properties.Resources._3;
            }
            else if(nrGreseli == 3)
            {
                this.pictureBox1.Image = Spanzuratoarea.Properties.Resources._4;
            }
            else if (nrGreseli == 4)
            {
                this.pictureBox1.Image = Spanzuratoarea.Properties.Resources._5;
            }
            else if (nrGreseli == 5)
            {
                this.pictureBox1.Image = Spanzuratoarea.Properties.Resources._6;
            }
            else if (nrGreseli == 6)
            {
                this.pictureBox1.Image = Spanzuratoarea.Properties.Resources._7;
                punctaj= 0;
                this.lblPunctaj.Text = "Punctaj : " + punctaj.ToString();
                MessageBox.Show("Din pacate ai pierdut!", "LOSE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
        private void SpanzuratoareaJOC_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.label1.Focus();
            Verifica('a');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Visible = false;
            this.label1.Focus();
            Verifica('b');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Visible = false;
            this.label1.Focus();
            Verifica('c');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Visible = false;
            this.label1.Focus();
            Verifica('d');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.Visible = false;
            this.label1.Focus();
            Verifica('e');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.Visible = false;
            this.label1.Focus();
            Verifica('f');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Visible = false;
            this.label1.Focus();
            Verifica('g');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.Visible = false;
            this.label1.Focus();
            Verifica('h');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.button16.Visible = false;
            this.label1.Focus();
            Verifica('i');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.button15.Visible = false;
            this.label1.Focus();
            Verifica('j');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.button14.Visible = false;
            this.label1.Focus();
            Verifica('k');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.button13.Visible = false;
            this.label1.Focus();
            Verifica('l');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.button12.Visible = false;
            this.label1.Focus();
            Verifica('m');
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.button11.Visible = false;
            this.label1.Focus();
            Verifica('n');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.button10.Visible = false;
            this.label1.Focus();
            Verifica('o');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button9.Visible = false;
            this.label1.Focus();
            Verifica('p');
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.button24.Visible = false;
            this.label1.Focus();
            Verifica('q');
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.button23.Visible = false;
            this.label1.Focus();
            Verifica('r');
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.button22.Visible = false;
            this.label1.Focus();
            Verifica('s');
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.button21.Visible = false;
            this.label1.Focus();
            Verifica('t');
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.button20.Visible = false;
            this.label1.Focus();
            Verifica('u');
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.button19.Visible = false;
            this.label1.Focus();
            Verifica('v');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.button18.Visible = false;
            this.label1.Focus();
            Verifica('w');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.button17.Visible = false;
            this.label1.Focus();
            Verifica('x');
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.button26.Visible = false;
            this.label1.Focus();
            Verifica('y');
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.button25.Visible = false;
            this.label1.Focus();
            Verifica('z');
        }
    }
}
