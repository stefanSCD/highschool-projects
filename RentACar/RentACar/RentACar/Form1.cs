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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.timer1.Start();
        }
        int loadingPosition = 0;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, new Rectangle(0, 0, loadingPosition, pictureBox1.Height));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingPosition += 5;
            if (loadingPosition >= pictureBox1.Width)
            {
                this.timer1.Stop();
                Form2 frm = new Form2(this);
                frm.Show();
                this.Hide();
            }
            pictureBox1.Invalidate();
        }
    }
}
