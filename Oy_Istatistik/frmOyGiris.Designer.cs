
namespace WindowsFormsApp1
{
    partial class frmOyGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnOyGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(95, 9);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(306, 31);
            this.txtAd.TabIndex = 1;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(95, 68);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(306, 31);
            this.txtA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Parti:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(95, 105);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(306, 31);
            this.txtB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "B Parti:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(95, 142);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(306, 31);
            this.txtC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "C Parti:";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(95, 179);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(306, 31);
            this.txtD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "D Parti:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(95, 216);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(306, 31);
            this.txtE.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "E Parti:";
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.Location = new System.Drawing.Point(95, 253);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(150, 46);
            this.btnGrafikler.TabIndex = 12;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnOyGiris
            // 
            this.btnOyGiris.Location = new System.Drawing.Point(251, 253);
            this.btnOyGiris.Name = "btnOyGiris";
            this.btnOyGiris.Size = new System.Drawing.Size(150, 46);
            this.btnOyGiris.TabIndex = 13;
            this.btnOyGiris.Text = "Oy girişi yap";
            this.btnOyGiris.UseVisualStyleBackColor = true;
            this.btnOyGiris.Click += new System.EventHandler(this.btnOyGiris_Click);
            // 
            // frmOyGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(415, 314);
            this.Controls.Add(this.btnOyGiris);
            this.Controls.Add(this.btnGrafikler);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmOyGiris";
            this.Text = "VTGS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Button btnOyGiris;
    }
}

