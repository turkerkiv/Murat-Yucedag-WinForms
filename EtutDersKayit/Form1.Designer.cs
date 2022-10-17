
namespace EtutDersKayit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.btnEtutOlustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.btnEtutVer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEtutId = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnYOgrt = new System.Windows.Forms.Button();
            this.btnYOgr = new System.Windows.Forms.Button();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtAd = new System.Windows.Forms.TextBox();
            this.cmbDers2 = new System.Windows.Forms.ComboBox();
            this.txtOgrTel = new System.Windows.Forms.TextBox();
            this.txtOgrSinif = new System.Windows.Forms.TextBox();
            this.txtOgrMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.btnYDers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtutOlustur);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.cmbOgretmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.cmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // cmbDers
            // 
            this.cmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(120, 38);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(178, 33);
            this.cmbDers.TabIndex = 1;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(120, 130);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(178, 33);
            this.mskTarih.TabIndex = 2;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saat:";
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Location = new System.Drawing.Point(120, 84);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(178, 33);
            this.cmbOgretmen.TabIndex = 6;
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(120, 175);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(178, 33);
            this.mskSaat.TabIndex = 7;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // btnEtutOlustur
            // 
            this.btnEtutOlustur.Location = new System.Drawing.Point(120, 218);
            this.btnEtutOlustur.Name = "btnEtutOlustur";
            this.btnEtutOlustur.Size = new System.Drawing.Size(178, 45);
            this.btnEtutOlustur.TabIndex = 8;
            this.btnEtutOlustur.Text = "Etüt oluştur";
            this.btnEtutOlustur.UseVisualStyleBackColor = true;
            this.btnEtutOlustur.Click += new System.EventHandler(this.btnEtutOlustur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDersAd);
            this.groupBox2.Controls.Add(this.btnYDers);
            this.groupBox2.Controls.Add(this.txtEtutId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtOgrNo);
            this.groupBox2.Controls.Add(this.btnEtutVer);
            this.groupBox2.Controls.Add(this.lblOgrenci);
            this.groupBox2.Location = new System.Drawing.Point(325, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 285);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Location = new System.Drawing.Point(6, 41);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(119, 25);
            this.lblOgrenci.TabIndex = 1;
            this.lblOgrenci.Text = "Öğrenci no:";
            // 
            // btnEtutVer
            // 
            this.btnEtutVer.Location = new System.Drawing.Point(131, 119);
            this.btnEtutVer.Name = "btnEtutVer";
            this.btnEtutVer.Size = new System.Drawing.Size(115, 45);
            this.btnEtutVer.TabIndex = 9;
            this.btnEtutVer.Text = "Etüt ver";
            this.btnEtutVer.UseVisualStyleBackColor = true;
            this.btnEtutVer.Click += new System.EventHandler(this.btnEtutVer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 283);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(559, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(131, 38);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(115, 33);
            this.txtOgrNo.TabIndex = 11;
            this.txtOgrNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Etüt id:";
            // 
            // txtEtutId
            // 
            this.txtEtutId.Enabled = false;
            this.txtEtutId.Location = new System.Drawing.Point(131, 80);
            this.txtEtutId.Name = "txtEtutId";
            this.txtEtutId.Size = new System.Drawing.Size(115, 33);
            this.txtEtutId.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtOgrMail);
            this.groupBox4.Controls.Add(this.txtOgrTel);
            this.groupBox4.Controls.Add(this.txtOgrSinif);
            this.groupBox4.Controls.Add(this.cmbDers2);
            this.groupBox4.Controls.Add(this.txtOgrtSoyad);
            this.groupBox4.Controls.Add(this.txtOgrtAd);
            this.groupBox4.Controls.Add(this.txtOgrSoyad);
            this.groupBox4.Controls.Add(this.txtOgrAd);
            this.groupBox4.Controls.Add(this.btnYOgrt);
            this.groupBox4.Controls.Add(this.btnYOgr);
            this.groupBox4.Location = new System.Drawing.Point(583, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 574);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // btnYOgrt
            // 
            this.btnYOgrt.Location = new System.Drawing.Point(12, 522);
            this.btnYOgrt.Name = "btnYOgrt";
            this.btnYOgrt.Size = new System.Drawing.Size(307, 46);
            this.btnYOgrt.TabIndex = 15;
            this.btnYOgrt.Text = "Yeni Öğretmen";
            this.btnYOgrt.UseVisualStyleBackColor = true;
            this.btnYOgrt.Click += new System.EventHandler(this.btnYOgrt_Click);
            // 
            // btnYOgr
            // 
            this.btnYOgr.Location = new System.Drawing.Point(12, 350);
            this.btnYOgr.Name = "btnYOgr";
            this.btnYOgr.Size = new System.Drawing.Size(307, 46);
            this.btnYOgr.TabIndex = 14;
            this.btnYOgr.Text = "Yeni Öğrenci";
            this.btnYOgr.UseVisualStyleBackColor = true;
            this.btnYOgr.Click += new System.EventHandler(this.btnYOgr_Click);
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(90, 149);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(229, 33);
            this.txtOgrAd.TabIndex = 14;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(90, 191);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(229, 33);
            this.txtOgrSoyad.TabIndex = 17;
            // 
            // txtOgrtSoyad
            // 
            this.txtOgrtSoyad.Location = new System.Drawing.Point(90, 442);
            this.txtOgrtSoyad.Name = "txtOgrtSoyad";
            this.txtOgrtSoyad.Size = new System.Drawing.Size(229, 33);
            this.txtOgrtSoyad.TabIndex = 20;
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Location = new System.Drawing.Point(90, 402);
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Size = new System.Drawing.Size(229, 33);
            this.txtOgrtAd.TabIndex = 19;
            // 
            // cmbDers2
            // 
            this.cmbDers2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers2.FormattingEnabled = true;
            this.cmbDers2.Location = new System.Drawing.Point(90, 482);
            this.cmbDers2.Name = "cmbDers2";
            this.cmbDers2.Size = new System.Drawing.Size(229, 33);
            this.cmbDers2.TabIndex = 9;
            // 
            // txtOgrTel
            // 
            this.txtOgrTel.Location = new System.Drawing.Point(90, 272);
            this.txtOgrTel.Name = "txtOgrTel";
            this.txtOgrTel.Size = new System.Drawing.Size(229, 33);
            this.txtOgrTel.TabIndex = 22;
            // 
            // txtOgrSinif
            // 
            this.txtOgrSinif.Location = new System.Drawing.Point(90, 230);
            this.txtOgrSinif.Name = "txtOgrSinif";
            this.txtOgrSinif.Size = new System.Drawing.Size(229, 33);
            this.txtOgrSinif.TabIndex = 21;
            // 
            // txtOgrMail
            // 
            this.txtOgrMail.Location = new System.Drawing.Point(90, 311);
            this.txtOgrMail.Name = "txtOgrMail";
            this.txtOgrMail.Size = new System.Drawing.Size(229, 33);
            this.txtOgrMail.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ders:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Soyad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Sınıf:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Tel:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ad:";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(56, 179);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(190, 33);
            this.txtDersAd.TabIndex = 30;
            // 
            // btnYDers
            // 
            this.btnYDers.Location = new System.Drawing.Point(11, 218);
            this.btnYDers.Name = "btnYDers";
            this.btnYDers.Size = new System.Drawing.Size(235, 46);
            this.btnYDers.TabIndex = 29;
            this.btnYDers.Text = "Yeni Ders";
            this.btnYDers.UseVisualStyleBackColor = true;
            this.btnYDers.Click += new System.EventHandler(this.btnYDers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 122);
            this.button1.TabIndex = 32;
            this.button1.Text = "Foto yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(914, 604);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEtutOlustur;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.ComboBox cmbOgretmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEtutVer;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.TextBox txtEtutId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrMail;
        private System.Windows.Forms.TextBox txtOgrTel;
        private System.Windows.Forms.TextBox txtOgrSinif;
        private System.Windows.Forms.ComboBox cmbDers2;
        private System.Windows.Forms.TextBox txtOgrtSoyad;
        private System.Windows.Forms.TextBox txtOgrtAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Button btnYOgrt;
        private System.Windows.Forms.Button btnYOgr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Button btnYDers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

