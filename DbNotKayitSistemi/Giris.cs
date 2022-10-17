using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            maskedTextBox1.Focus();

            button1.BackColor = Color.DarkTurquoise;
            maskedTextBox1.BackColor = Color.DarkTurquoise;
            label1.BackColor= Color.DarkTurquoise;
            panel2.BackColor= Color.DarkTurquoise;

            button2.BackColor = Color.CadetBlue;
            maskedTextBox2.BackColor = Color.CadetBlue;
            label2.BackColor = Color.CadetBlue;
            panel1.BackColor = Color.CadetBlue;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            maskedTextBox2.Focus();

            button1.BackColor = Color.CadetBlue;
            maskedTextBox1.BackColor = Color.CadetBlue;
            label1.BackColor = Color.CadetBlue;
            panel2.BackColor = Color.CadetBlue;

            button2.BackColor = Color.DarkTurquoise;
            maskedTextBox2.BackColor = Color.DarkTurquoise;
            label2.BackColor = Color.DarkTurquoise;
            panel1.BackColor = Color.DarkTurquoise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length == 4)
            {
                frmOgrenciDetay frm = new frmOgrenciDetay();
                frm.ogrno = maskedTextBox1.Text;
                frm.Show();
                this.Hide();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text.Length == 4)
            {
                frmOgretmenDetay fr = new frmOgretmenDetay();
                fr.Show();
                this.Hide();
            }
        }
    }
}
