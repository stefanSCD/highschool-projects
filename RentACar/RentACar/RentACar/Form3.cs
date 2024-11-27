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
    public partial class Form3 : Form
    {
        public Form3(Form2 frm)
        {
            InitializeComponent();
            this.frm = frm;
            tba = new DataSet1TableAdapters.masiniTableAdapter();
            dt = new DataSet1.masiniDataTable();
            tba.Fill(dt);
            this.label5.Text = frm.locatie;
            this.label6.Text = frm.start.ToString();
            this.label7.Text = frm.final.ToString();
            int nrZile = frm.final.Day - frm.start.Day + 1;

            this.label8.Text = "Marca : " +  dt[0].Marca;
            this.label9.Text = "Model : " + dt[0].Model;
            this.label10.Text = "Cutie de viteze : " + dt[0].CutieDeViteze;
            this.label11.Text = "Combustibil : " + dt[0].Combustibil;
            this.label12.Text = "Consum : " + dt[0].Consum.ToString();
            this.label13.Text = "Numar de locuri : " + dt[0].NumarLocuri.ToString();
            this.label14.Text = "Pret pe zi : " + dt[0].PretPeZi.ToString();
            this.label15.Text = "Pret total : " + (nrZile * dt[0].PretPeZi).ToString();

            this.label23.Text = "Marca : " + dt[1].Marca;
            this.label22.Text = "Model : " + dt[1].Model;
            this.label21.Text = "Cutie de viteze : " + dt[1].CutieDeViteze;
            this.label20.Text = "Combustibil : " + dt[1].Combustibil;
            this.label19.Text = "Consum : " + dt[1].Consum.ToString();
            this.label18.Text = "Numar de locuri : " + dt[1].NumarLocuri.ToString();
            this.label17.Text = "Pret pe zi : " + dt[1].PretPeZi.ToString();
            this.label16.Text = "Pret total : " + (nrZile * dt[1].PretPeZi).ToString();

            this.label26.Text = "Marca : " + dt[2].Marca;
            this.label28.Text = "Model : " + dt[2].Model;
            this.label30.Text = "Cutie de viteze : " + dt[2].CutieDeViteze;
            this.label21.Text = "Combustibil : " + dt[2].Combustibil;
            this.label29.Text = "Consum : " + dt[2].Consum.ToString();
            this.label27.Text = "Numar de locuri : " + dt[2].NumarLocuri.ToString();
            this.label25.Text = "Pret pe zi : " + dt[2].PretPeZi.ToString();
            this.label24.Text = "Pret total : " + (nrZile * dt[2].PretPeZi).ToString();

            this.label33.Text = "Marca : " + dt[4].Marca;
            this.label35.Text = "Model : " + dt[4].Model;
            this.label37.Text = "Cutie de viteze : " + dt[4].CutieDeViteze;
            this.label39.Text = "Combustibil : " + dt[4].Combustibil;
            this.label38.Text = "Consum : " + dt[4].Consum.ToString();
            this.label36.Text = "Numar de locuri : " + dt[4].NumarLocuri.ToString();
            this.label34.Text = "Pret pe zi : " + dt[4].PretPeZi.ToString();
            this.label32.Text = "Pret total : " + (nrZile * dt[4].PretPeZi).ToString();

            this.label41.Text = "Marca : " + dt[3].Marca;
            this.label43.Text = "Model : " + dt[3].Model;
            this.label45.Text = "Cutie de viteze : " + dt[3].CutieDeViteze;
            this.label47.Text = "Combustibil : " + dt[3].Combustibil;
            this.label46.Text = "Consum : " + dt[3].Consum.ToString();
            this.label44.Text = "Numar de locuri : " + dt[3].NumarLocuri.ToString();
            this.label42.Text = "Pret pe zi : " + dt[3].PretPeZi.ToString();
            this.label40.Text = "Pret total : " + (nrZile * dt[3].PretPeZi).ToString();

            this.label49.Text = "Marca : " + dt[5].Marca;
            this.label51.Text = "Model : " + dt[5].Model;
            this.label53.Text = "Cutie de viteze : " + dt[5].CutieDeViteze;
            this.label55.Text = "Combustibil : " + dt[5].Combustibil;
            this.label54.Text = "Consum : " + dt[5].Consum.ToString();
            this.label52.Text = "Numar de locuri : " + dt[5].NumarLocuri.ToString();
            this.label50.Text = "Pret pe zi : " + dt[5].PretPeZi.ToString();
            this.label48.Text = "Pret total : " + (nrZile * dt[5].PretPeZi).ToString();

            this.label57.Text = "Marca : " + dt[8].Marca;
            this.label59.Text = "Model : " + dt[8].Model;
            this.label61.Text = "Cutie de viteze : " + dt[8].CutieDeViteze;
            this.label63.Text = "Combustibil : " + dt[8].Combustibil;
            this.label62.Text = "Consum : " + dt[8].Consum.ToString();
            this.label60.Text = "Numar de locuri : " + dt[8].NumarLocuri.ToString();
            this.label58.Text = "Pret pe zi : " + dt[8].PretPeZi.ToString();
            this.label56.Text = "Pret total : " + (nrZile * dt[8].PretPeZi).ToString();

            this.label65.Text = "Marca : " + dt[6].Marca;
            this.label67.Text = "Model : " + dt[6].Model;
            this.label69.Text = "Cutie de viteze : " + dt[6].CutieDeViteze;
            this.label71.Text = "Combustibil : " + dt[6].Combustibil;
            this.label70.Text = "Consum : " + dt[6].Consum.ToString();
            this.label68.Text = "Numar de locuri : " + dt[6].NumarLocuri.ToString();
            this.label66.Text = "Pret pe zi : " + dt[6].PretPeZi.ToString();
            this.label64.Text = "Pret total : " + (nrZile * dt[6].PretPeZi).ToString();

            this.label73.Text = "Marca : " + dt[7].Marca;
            this.label75.Text = "Model : " + dt[7].Model;
            this.label77.Text = "Cutie de viteze : " + dt[7].CutieDeViteze;
            this.label79.Text = "Combustibil : " + dt[7].Combustibil;
            this.label78.Text = "Consum : " + dt[7].Consum.ToString();
            this.label76.Text = "Numar de locuri : " + dt[7].NumarLocuri.ToString();
            this.label74.Text = "Pret pe zi : " + dt[7].PretPeZi.ToString();
            this.label72.Text = "Pret total : " + (nrZile * dt[7].PretPeZi).ToString();

            this.label81.Text = "Marca : " + dt[11].Marca;
            this.label83.Text = "Model : " + dt[11].Model;
            this.label85.Text = "Cutie de viteze : " + dt[11].CutieDeViteze;
            this.label87.Text = "Combustibil : " + dt[11].Combustibil;
            this.label86.Text = "Consum : " + dt[11].Consum.ToString();
            this.label84.Text = "Numar de locuri : " + dt[11].NumarLocuri.ToString();
            this.label82.Text = "Pret pe zi : " + dt[11].PretPeZi.ToString();
            this.label80.Text = "Pret total : " + (nrZile * dt[11].PretPeZi).ToString();

            this.label89.Text = "Marca : " + dt[9].Marca;
            this.label91.Text = "Model : " + dt[9].Model;
            this.label93.Text = "Cutie de viteze : " + dt[9].CutieDeViteze;
            this.label95.Text = "Combustibil : " + dt[9].Combustibil;
            this.label94.Text = "Consum : " + dt[9].Consum.ToString();
            this.label92.Text = "Numar de locuri : " + dt[9].NumarLocuri.ToString();
            this.label90.Text = "Pret pe zi : " + dt[9].PretPeZi.ToString();
            this.label88.Text = "Pret total : " + (nrZile * dt[9].PretPeZi).ToString();

            this.label97.Text = "Marca : " + dt[10].Marca;
            this.label99.Text = "Model : " + dt[10].Model;
            this.label101.Text = "Cutie de viteze : " + dt[10].CutieDeViteze;
            this.label103.Text = "Combustibil : " + dt[10].Combustibil;
            this.label102.Text = "Consum : " + dt[10].Consum.ToString();
            this.label100.Text = "Numar de locuri : " + dt[10].NumarLocuri.ToString();
            this.label98.Text = "Pret pe zi : " + dt[10].PretPeZi.ToString();
            this.label96.Text = "Pret total : " + (nrZile * dt[10].PretPeZi).ToString();

            this.label105.Text = "Marca : " + dt[13].Marca;
            this.label107.Text = "Model : " + dt[13].Model;
            this.label109.Text = "Cutie de viteze : " + dt[13].CutieDeViteze;
            this.label111.Text = "Combustibil : " + dt[13].Combustibil;
            this.label110.Text = "Consum : " + dt[13].Consum.ToString();
            this.label108.Text = "Numar de locuri : " + dt[13].NumarLocuri.ToString();
            this.label106.Text = "Pret pe zi : " + dt[13].PretPeZi.ToString();
            this.label104.Text = "Pret total : " + (nrZile * dt[13].PretPeZi).ToString();

            this.label113.Text = "Marca : " + dt[12].Marca;
            this.label115.Text = "Model : " + dt[12].Model;
            this.label117.Text = "Cutie de viteze : " + dt[12].CutieDeViteze;
            this.label119.Text = "Combustibil : " + dt[12].Combustibil;
            this.label118.Text = "Consum : " + dt[12].Consum.ToString();
            this.label116.Text = "Numar de locuri : " + dt[12].NumarLocuri.ToString();
            this.label114.Text = "Pret pe zi : " + dt[12].PretPeZi.ToString();
            this.label112.Text = "Pret total : " + (nrZile * dt[12].PretPeZi).ToString();

            this.label121.Text = "Marca : " + dt[14].Marca;
            this.label123.Text = "Model : " + dt[14].Model;
            this.label125.Text = "Cutie de viteze : " + dt[14].CutieDeViteze;
            this.label127.Text = "Combustibil : " + dt[14].Combustibil;
            this.label126.Text = "Consum : " + dt[14].Consum.ToString();
            this.label124.Text = "Numar de locuri : " + dt[14].NumarLocuri.ToString();
            this.label122.Text = "Pret pe zi : " + dt[14].PretPeZi.ToString();
            this.label120.Text = "Pret total : " + (nrZile * dt[14].PretPeZi).ToString();

            this.label129.Text = "Marca : " + dt[17].Marca;
            this.label131.Text = "Model : " + dt[17].Model;
            this.label133.Text = "Cutie de viteze : " + dt[17].CutieDeViteze;
            this.label135.Text = "Combustibil : " + dt[17].Combustibil;
            this.label134.Text = "Consum : " + dt[17].Consum.ToString();
            this.label132.Text = "Numar de locuri : " + dt[17].NumarLocuri.ToString();
            this.label130.Text = "Pret pe zi : " + dt[17].PretPeZi.ToString();
            this.label128.Text = "Pret total : " + (nrZile * dt[17].PretPeZi).ToString();

            this.label137.Text = "Marca : " + dt[16].Marca;
            this.label139.Text = "Model : " + dt[16].Model;
            this.label141.Text = "Cutie de viteze : " + dt[16].CutieDeViteze;
            this.label143.Text = "Combustibil : " + dt[16].Combustibil;
            this.label142.Text = "Consum : " + dt[16].Consum.ToString();
            this.label140.Text = "Numar de locuri : " + dt[16].NumarLocuri.ToString();
            this.label138.Text = "Pret pe zi : " + dt[16].PretPeZi.ToString();
            this.label136.Text = "Pret total : " + (nrZile * dt[16].PretPeZi).ToString();

            this.label145.Text = "Marca : " + dt[15].Marca;
            this.label147.Text = "Model : " + dt[15].Model;
            this.label149.Text = "Cutie de viteze : " + dt[15].CutieDeViteze;
            this.label151.Text = "Combustibil : " + dt[15].Combustibil;
            this.label150.Text = "Consum : " + dt[15].Consum.ToString();
            this.label148.Text = "Numar de locuri : " + dt[15].NumarLocuri.ToString();
            this.label146.Text = "Pret pe zi : " + dt[15].PretPeZi.ToString();
            this.label144.Text = "Pret total : " + (nrZile * dt[15].PretPeZi).ToString();

            this.label153.Text = "Marca : " + dt[20].Marca;
            this.label155.Text = "Model : " + dt[20].Model;
            this.label157.Text = "Cutie de viteze : " + dt[20].CutieDeViteze;
            this.label159.Text = "Combustibil : " + dt[20].Combustibil;
            this.label158.Text = "Consum : " + dt[20].Consum.ToString();
            this.label156.Text = "Numar de locuri : " + dt[20].NumarLocuri.ToString();
            this.label154.Text = "Pret pe zi : " + dt[20].PretPeZi.ToString();
            this.label152.Text = "Pret total : " + (nrZile * dt[20].PretPeZi).ToString();

            this.label161.Text = "Marca : " + dt[18].Marca;
            this.label163.Text = "Model : " + dt[18].Model;
            this.label165.Text = "Cutie de viteze : " + dt[18].CutieDeViteze;
            this.label167.Text = "Combustibil : " + dt[18].Combustibil;
            this.label166.Text = "Consum : " + dt[18].Consum.ToString();
            this.label164.Text = "Numar de locuri : " + dt[18].NumarLocuri.ToString();
            this.label162.Text = "Pret pe zi : " + dt[18].PretPeZi.ToString();
            this.label160.Text = "Pret total : " + (nrZile * dt[18].PretPeZi).ToString();

            this.label169.Text = "Marca : " + dt[19].Marca;
            this.label171.Text = "Model : " + dt[19].Model;
            this.label173.Text = "Cutie de viteze : " + dt[19].CutieDeViteze;
            this.label175.Text = "Combustibil : " + dt[19].Combustibil;
            this.label174.Text = "Consum : " + dt[19].Consum.ToString();
            this.label172.Text = "Numar de locuri : " + dt[19].NumarLocuri.ToString();
            this.label170.Text = "Pret pe zi : " + dt[19].PretPeZi.ToString();
            this.label168.Text = "Pret total : " + (nrZile * dt[19].PretPeZi).ToString();
            tbInchirieri = new DataSet1TableAdapters.inchirieriTableAdapter();
            dtInchirieri = new DataSet1.inchirieriDataTable();

            Verificare();
        }
        private void Verificare()
        {
            if (tbInchirieri.VerificaDisponibilitate(1, frm.start, frm.final) > 0)
            {
                this.panel1.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(2, frm.start, frm.final) > 0)
            {
                this.panel3.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(3, frm.start, frm.final) > 0)
            {
                this.panel2.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(5, frm.start, frm.final) > 0)
            {
                this.panel4.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(4, frm.start, frm.final) > 0)
            {
                this.panel5.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(6, frm.start, frm.final) > 0)
            {
                this.panel6.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(9, frm.start, frm.final) > 0)
            {
                this.panel7.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(7, frm.start, frm.final) > 0)
            {
                this.panel8.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(8, frm.start, frm.final) > 0)
            {
                this.panel9.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(12, frm.start, frm.final) > 0)
            {
                this.panel10.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(10, frm.start, frm.final) > 0)
            {
                this.panel11.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(11, frm.start, frm.final) > 0)
            {
                this.panel12.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(14, frm.start, frm.final) > 0)
            {
                this.panel13.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(13, frm.start, frm.final) > 0)
            {
                this.panel14.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(15, frm.start, frm.final) > 0)
            {
                this.panel15.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(18, frm.start, frm.final) > 0)
            {
                this.panel19.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(17, frm.start, frm.final) > 0)
            {
                this.panel20.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(16, frm.start, frm.final) > 0)
            {
                this.panel21.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(21, frm.start, frm.final) > 0)
            {
                this.panel16.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(19, frm.start, frm.final) > 0)
            {
                this.panel17.Enabled = false;
            }
            if (tbInchirieri.VerificaDisponibilitate(20, frm.start, frm.final) > 0)
            {
                this.panel18.Enabled = false;
            }
        }
        Form2 frm;
        DataSet1TableAdapters.masiniTableAdapter tba;
        DataSet1.masiniDataTable dt;
        DataSet1TableAdapters.inchirieriTableAdapter tbInchirieri;
        DataSet1.inchirieriDataTable dtInchirieri;
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            tbInchirieri.Insert(1, frm.start, frm.final);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel3.Enabled = false;
            tbInchirieri.Insert(2, frm.start, frm.final);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel2.Enabled = false;
            tbInchirieri.Insert(3, frm.start, frm.final);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel4.Enabled = false;
            tbInchirieri.Insert(5, frm.start, frm.final);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel5.Enabled = false;
            tbInchirieri.Insert(4, frm.start, frm.final);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel6.Enabled = false;
            tbInchirieri.Insert(6, frm.start, frm.final);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.panel7.Enabled = false;
            tbInchirieri.Insert(9, frm.start, frm.final);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.panel8.Enabled = false;
            tbInchirieri.Insert(7, frm.start, frm.final);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.panel9.Enabled = false;
            tbInchirieri.Insert(8, frm.start, frm.final);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.panel10.Enabled = false;
            tbInchirieri.Insert(12, frm.start, frm.final);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.panel11.Enabled = false;
            tbInchirieri.Insert(10, frm.start, frm.final);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.panel12.Enabled = false;
            tbInchirieri.Insert(11, frm.start, frm.final);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.panel13.Enabled = false;
            tbInchirieri.Insert(14, frm.start, frm.final);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.panel14.Enabled = false;
            tbInchirieri.Insert(13, frm.start, frm.final);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.panel19.Enabled = false;
            tbInchirieri.Insert(15, frm.start, frm.final);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.panel20.Enabled = false;
            tbInchirieri.Insert(17, frm.start, frm.final);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.panel21.Enabled = false;
            tbInchirieri.Insert(16, frm.start, frm.final);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.panel16.Enabled = false;
            tbInchirieri.Insert(21, frm.start, frm.final);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.panel17.Enabled = false;
            tbInchirieri.Insert(19, frm.start, frm.final);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.panel18.Enabled = false;
            tbInchirieri.Insert(20, frm.start, frm.final);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.panel15.Enabled = false;
            tbInchirieri.Insert(15, frm.start, frm.final);
        }
    }
}
