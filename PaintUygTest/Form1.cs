using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUygTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resimyolu;
        Color renk;

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resimyolu = openFileDialog1.FileName;

        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
        Bitmap bmp;
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resimyolu);
            Graphics grp = Graphics.FromImage(bmp);
            grp.DrawString(txtMetin.Text,new Font("MS UI Gothic",int.Parse(txtBoyut.Text),FontStyle.Regular),new SolidBrush(renk),40,50);
            pictureBox1.Image = bmp;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
            
        }
    }
}
