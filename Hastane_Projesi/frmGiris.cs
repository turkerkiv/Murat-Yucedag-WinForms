using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            frmDoktorGiris frmdktr = new frmDoktorGiris();
            frmdktr.Show();
            this.Hide();
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            frmSekreterGiris frmskrt = new frmSekreterGiris();
            frmskrt.Show();
            this.Hide();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            frmHastaGiris frmhst = new frmHastaGiris();
            frmhst.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoktor_MouseHover(object sender, EventArgs e)
        {
            btnDoktor.BackgroundImage = Properties.Resources.surgeon_1;
            label1.Visible = true;
            btnDoktor.Dock= DockStyle.Fill;

        }

        private void btnDoktor_MouseLeave(object sender, EventArgs e)
        {
            btnDoktor.BackgroundImage = Properties.Resources.surgeon_doctor_pngrepo_com;
            label1.Visible = false;
            btnDoktor.Dock = DockStyle.None;

        }

        private void btnDoktor_MouseDown(object sender, MouseEventArgs e)
        {
            btnDoktor.BackgroundImage = Properties.Resources.surgeon_doctor_pngrepo_com;
            btnDoktor.Dock = DockStyle.None;
        }

        private void btnDoktor_MouseUp(object sender, MouseEventArgs e)
        {
            btnDoktor.BackgroundImage = Properties.Resources.surgeon_1;
            btnDoktor.Dock = DockStyle.Fill;
        }

        private void btnSekreter_MouseDown(object sender, MouseEventArgs e)
        {
            btnSekreter.BackgroundImage = Properties.Resources.secretary_pngrepo_com;
            btnSekreter.Dock = DockStyle.None;
        }

        private void btnSekreter_MouseUp(object sender, MouseEventArgs e)
        {
            btnSekreter.BackgroundImage = Properties.Resources.secretary_1;
            btnSekreter.Dock= DockStyle.Fill;
        }

        private void btnSekreter_MouseHover(object sender, EventArgs e)
        {
            btnSekreter.BackgroundImage = Properties.Resources.secretary_1;
            btnSekreter.Dock= DockStyle.Fill;
            label2.Visible = true;
        }

        private void btnSekreter_MouseLeave(object sender, EventArgs e)
        {
            btnSekreter.BackgroundImage = Properties.Resources.secretary_pngrepo_com;
            btnSekreter.Dock = DockStyle.None;
            label2.Visible = false;
        }

        private void btnHasta_MouseDown(object sender, MouseEventArgs e)
        {
            btnHasta.BackgroundImage = Properties.Resources._936_9361184_avatar_patient_patient_avatar;
            btnHasta.Dock = DockStyle.None;
        }

        private void btnHasta_MouseUp(object sender, MouseEventArgs e)
        {
            btnHasta.BackgroundImage = Properties.Resources._936_9361184_avatar_patient_1;
            btnHasta.Dock = DockStyle.Fill;
        }

        private void btnHasta_MouseHover(object sender, EventArgs e)
        {
            btnHasta.BackgroundImage = Properties.Resources._936_9361184_avatar_patient_1;
            btnHasta.Dock = DockStyle.Fill;
            label3.Visible = true;
        }

        private void btnHasta_MouseLeave(object sender, EventArgs e)
        {
            btnHasta.BackgroundImage = Properties.Resources._936_9361184_avatar_patient_patient_avatar;
            btnHasta.Dock = DockStyle.None;
            label3.Visible = false;
        }

        Point pnt2;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            pnt2.X = e.X;
            pnt2.Y = e.Y;
        }
        
        
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point pnt = new Point();
                pnt.X= MousePosition.X;
                pnt.Y= MousePosition.Y;

                this.Location = new Point(pnt.X - pnt2.X, pnt.Y - pnt2.Y);
            }

            

        }
    }
}
