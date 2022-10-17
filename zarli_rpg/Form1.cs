using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int t, t1, t2, can = 100, can2 = 100;

        private void timer1_Tick(object sender, EventArgs e)
        {
            t1++;
            if (t1 == 2)
            {
                timer1.Stop();
                label4.Visible = false;
                t1 = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t2++;
            if (t2 == 2)
            {
                timer2.Stop();
                label5.Visible = false;
                t2 = 0;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Start();


            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(1, 5);
            s2 = rnd.Next(1, 5);
            s3 = rnd.Next(1, 5);

            if (s1 % 2 == 1 || s3 % 2 == 1 || s2 % 2 == 1)
            {
                label6.Text = "5";
            }
            if (s1 % 2 == 0 && s2 % 2 == 0 && s3 % 2 == 0)
            {
                label4.Text = "Kritik vuruş " + "-" + ((s1 + s2 + s3) * 2).ToString() + " Can";
                can = can - (s1 + s2 + s3) * 2;
                label1.Text = can + " Can";
                label6.Text = "4";

            }

            if (s1 % 2 == 0 && s2 % 2 == 0 && label6.Text != "4")
            {
                label4.Text = "-" + (s1 + s2).ToString() + " Can";
                can = can - (s1 + s2);
                label1.Text = can + " Can";
                label6.Text = "1";

            }
            if (s3 % 2 == 0 && s2 % 2 == 0 && label6.Text != "4")
            {
                label4.Text = "-" + (s3 + s2).ToString() + " Can";
                can = can - (s3 + s2);
                label1.Text = can + " Can";
                label6.Text = "2";

            }
            if (s1 % 2 == 0 && s3 % 2 == 0 && label6.Text != "4")
            {

                label4.Text = "-" + (s1 + s3).ToString() + " Can";
                can = can - (s1 + s3);
                label1.Text = can + " Can";
                label6.Text = "3";


            }
            if (label6.Text == "5")
            {

                label4.Text = "Iskaladınız...";
            }






            label4.Visible = true;
            label3.Text = "Sayılar = " + s1 + " " + s2 + " " + s3;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = can + " Can";
            label2.Text = can2 + " Can";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            timer2.Start();


            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(1, 5);
            s2 = rnd.Next(1, 5);
            s3 = rnd.Next(1, 5);

            if (s1 % 2 == 1 || s3 % 2 == 1 || s2 % 2 == 1)
            {
                label6.Text = "5";
            }
            if (s1 % 2 == 0 && s2 % 2 == 0 && s3 % 2 == 0)
            {
                label5.Text = "Kritik vuruş " + "-" + ((s1 + s2 + s3) * 2).ToString() + " Can";
                can2 = can2 - (s1 + s2 + s3) * 2;
                label2.Text = can2 + " Can";
                label6.Text = "4";

            }

            if (s1 % 2 == 0 && s2 % 2 == 0 && label6.Text != "4")
            {
                label5.Text = "-" + (s1 + s2).ToString() + " Can";
                can2 = can2 - (s1 + s2);
                label2.Text = can2 + " Can";
                label6.Text = "1";

            }
            if (s3 % 2 == 0 && s2 % 2 == 0 && label6.Text != "4")
            {
                label5.Text = "-" + (s3 + s2).ToString() + " Can";
                can2 = can2 - (s3 + s2);
                label2.Text = can2 + " Can";
                label6.Text = "2";

            }
            if (s1 % 2 == 0 && s3 % 2 == 0 && label6.Text != "4")
            {

                label5.Text = "-" + (s1 + s3).ToString() + " Can";
                can2 = can2 - (s1 + s3);
                label2.Text = can2 + " Can";
                label6.Text = "3";


            }
            if (label6.Text == "5")
            {

                label5.Text = "Iskaladınız...";
            }






            label5.Visible = true;
            label3.Text = "Sayılar = " + s1 + " " + s2 + " " + s3;


        }
    }
}
