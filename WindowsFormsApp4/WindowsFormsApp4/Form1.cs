using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int x = 1;
        public int scor1 = 0, scor2 = 0;
        int cnt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button1.Text = "X";
                x = 2;
            }
            else
            {
                this.button1.Text = "O";
                x = 1;
            }
            this.button1.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button2.Text = "X";
                x = 2;
            }
            else
            {
                this.button2.Text = "O";
                x = 1;
            }
            this.button2.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button3.Text = "X";
                x = 2;
            }
            else
            {
                this.button3.Text = "O";
                x = 1;
            }
            this.button3.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button4.Text = "X";
                x = 2;
            }
            else
            {
                this.button4.Text = "O";
                x = 1;
            }
            this.button4.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button5.Text = "X";
                x = 2;
            }
            else
            {
                this.button5.Text = "O";
                x = 1;
            }
            this.button5.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button6.Text = "X";
                x = 2;
            }
            else
            {
                this.button6.Text = "O";
                x = 1;
            }
            this.button6.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button7.Text = "X";
                x = 2;
            }
            else
            {
                this.button7.Text = "O";
                x = 1;
            }
            this.button7.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button8.Text = "X";
                x = 2;
            }
            else
            {
                this.button8.Text = "O";
                x = 1;
            }
            this.button8.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cnt++;
            if (x == 1)
            {
                this.button9.Text = "X";
                x = 2;
            }
            else
            {
                this.button9.Text = "O";
                x = 1;
            }
            this.button9.Enabled = false;
            if (VerificaCastigator())
            {
                MessageBox.Show("Jucătorul " + (x == 1 ? "O" : "X") + " a câștigat!");
                if (x == 1)
                {
                    scor1 += 1;
                    this.lab1.Text = scor1.ToString();
                }
                else
                {
                    scor2 += 1;
                    this.lab2.Text = scor2.ToString();
                }
                Resetare();
                cnt = 0;
            }
            else if (cnt == 9)
            {
                MessageBox.Show("EGALITATE!");
                Resetare();
                cnt = 0;
            }
        }
        private void Resetare()
        {
            this.button1.Enabled = true;
            this.button1.Text = "";
            this.button2.Enabled = true;
            this.button2.Text = "";
            this.button3.Enabled = true;
            this.button3.Text = "";
            this.button4.Enabled = true;
            this.button4.Text = "";
            this.button5.Enabled = true;
            this.button5.Text = "";
            this.button6.Enabled = true;
            this.button6.Text = "";
            this.button7.Enabled = true;
            this.button7.Text = "";
            this.button8.Enabled = true;
            this.button8.Text = "";
            this.button9.Enabled = true;
            this.button9.Text = "";
        }
        private bool VerificaCastigator()
        {
            // Verificare linii
            for (int i = 0; i < 3; i++)
            {
                if (VerificaLinie(i))
                    return true;
            }

            // Verificare coloane
            for (int i = 0; i < 3; i++)
            {
                if (VerificaColoana(i))
                    return true;
            }

            // Verificare diagonale
            if (VerificaDiagonalaPrincipala() || VerificaDiagonalaSecundara())
                return true;

            return false;
        }

        private bool VerificaLinie(int linie)
        {
            return (GetSimbol(linie, 0) == GetSimbol(linie, 1) && GetSimbol(linie, 1) == GetSimbol(linie, 2) && GetSimbol(linie, 0) != "");
        }

        private bool VerificaColoana(int coloana)
        {
            return (GetSimbol(0, coloana) == GetSimbol(1, coloana) && GetSimbol(1, coloana) == GetSimbol(2, coloana) && GetSimbol(0, coloana) != "");
        }

        private bool VerificaDiagonalaPrincipala()
        {
            return (GetSimbol(0, 0) == GetSimbol(1, 1) && GetSimbol(1, 1) == GetSimbol(2, 2) && GetSimbol(0, 0) != "");
        }

        private bool VerificaDiagonalaSecundara()
        {
            return (GetSimbol(0, 2) == GetSimbol(1, 1) && GetSimbol(1, 1) == GetSimbol(2, 0) && GetSimbol(0, 2) != "");
        }

        private string GetSimbol(int linie, int coloana)
        {
            Control[] controls = this.Controls.Find("button" + (linie * 3 + coloana + 1), true);
            if (controls.Length > 0 && controls[0] is Button)
            {
                return ((Button)controls[0]).Text;
            }
            return "";
        }

    }
}
