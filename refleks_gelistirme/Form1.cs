using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tik = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            Point pnt2 = new Point();
            Point pnt3 = new Point();
            pnt2.Y = 10;

            pnt3.Y = 10;
            pnt3.X = 60;

            label1.Visible = true;
            label3.Visible = true;
            label2.Visible = false;
            maskedTextBox1.Visible = false;
            label4.Visible = false;
            button2.Enabled = true;
            label1.Location = pnt2;
            label3.Location = pnt3;


            double giriss1 = Convert.ToDouble(maskedTextBox1.Text) * 1000;
            timer1.Interval = Convert.ToInt32(giriss1);
            timer1.Start();
            tik++;
            label3.Text = tik.ToString();
            button2.Enabled = false;
            button1.Enabled = false;
            button1.BackColor = Color.GreenYellow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Point pnt = new Point();

            pnt.X = rnd.Next(50, 750);
            pnt.Y = rnd.Next(50, 750);

            button1.Location = pnt;
            button1.Enabled = true;
            button1.BackColor = Color.White;
            button2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tik -= 1;
            label3.Text = tik.ToString();
            button1.BackColor = Color.Red;
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
