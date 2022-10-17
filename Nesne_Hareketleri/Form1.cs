using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Hareketleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top -= 5;

                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    pictureBox2.Top -= 5;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += 5;
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    pictureBox2.Top += 5;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 5;
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    pictureBox2.Left -= 5;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 5;
                if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    pictureBox2.Left += 5;
                }
            }
            if (e.KeyCode == Keys.F)
            {
                if (pictureBox1.Bounds.Top==(pictureBox2.Bounds.Bottom))
                {
                    pictureBox2.Top -= 100;
                }
                if (pictureBox1.Bounds.Bottom+1 == (pictureBox2.Bounds.Top))
                {
                    pictureBox2.Top += 100;
                }
                if (pictureBox1.Bounds.Left == (pictureBox2.Bounds.Right+1))
                {
                    pictureBox2.Left -= 100;
                }
                if (pictureBox1.Bounds.Right == (pictureBox2.Bounds.Left))
                {
                    pictureBox2.Left +=100;
                }
            }
        }


    }
}
