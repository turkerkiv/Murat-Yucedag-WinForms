
namespace Proje6
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proje6DataSet = new Proje6.Proje6DataSet();
            this.proje6CagirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje6CagirTableAdapter = new Proje6.Proje6DataSetTableAdapters.Proje6CagirTableAdapter();
            this.ürünAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünFiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFiyat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6CagirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünAdıDataGridViewTextBoxColumn,
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn,
            this.personelAdıDataGridViewTextBoxColumn,
            this.ürünFiyatıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proje6CagirBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(808, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // proje6DataSet
            // 
            this.proje6DataSet.DataSetName = "Proje6DataSet";
            this.proje6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proje6CagirBindingSource
            // 
            this.proje6CagirBindingSource.DataMember = "Proje6Cagir";
            this.proje6CagirBindingSource.DataSource = this.proje6DataSet;
            // 
            // proje6CagirTableAdapter
            // 
            this.proje6CagirTableAdapter.ClearBeforeFill = true;
            // 
            // ürünAdıDataGridViewTextBoxColumn
            // 
            this.ürünAdıDataGridViewTextBoxColumn.DataPropertyName = "Ürün Adı";
            this.ürünAdıDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.ürünAdıDataGridViewTextBoxColumn.Name = "ürünAdıDataGridViewTextBoxColumn";
            // 
            // müşteriAdıSoyadıDataGridViewTextBoxColumn
            // 
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn.DataPropertyName = "Müşteri Adı Soyadı";
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn.HeaderText = "Müşteri Adı Soyadı";
            this.müşteriAdıSoyadıDataGridViewTextBoxColumn.Name = "müşteriAdıSoyadıDataGridViewTextBoxColumn";
            // 
            // personelAdıDataGridViewTextBoxColumn
            // 
            this.personelAdıDataGridViewTextBoxColumn.DataPropertyName = "Personel Adı";
            this.personelAdıDataGridViewTextBoxColumn.HeaderText = "Personel Adı";
            this.personelAdıDataGridViewTextBoxColumn.Name = "personelAdıDataGridViewTextBoxColumn";
            // 
            // ürünFiyatıDataGridViewTextBoxColumn
            // 
            this.ürünFiyatıDataGridViewTextBoxColumn.DataPropertyName = "Ürün Fiyatı";
            this.ürünFiyatıDataGridViewTextBoxColumn.HeaderText = "Ürün Fiyatı";
            this.ürünFiyatıDataGridViewTextBoxColumn.Name = "ürünFiyatıDataGridViewTextBoxColumn";
            // 
            // cmbUrun
            // 
            this.cmbUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(12, 336);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 27);
            this.cmbUrun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(157)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(29, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(157)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(173, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(157)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(345, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Ad Soyad";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(362, 336);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(121, 27);
            this.cmbPersonel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(157)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(545, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // cmbFiyat
            // 
            this.cmbFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.cmbFiyat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiyat.Enabled = false;
            this.cmbFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.cmbFiyat.FormattingEnabled = true;
            this.cmbFiyat.Location = new System.Drawing.Point(537, 336);
            this.cmbFiyat.Name = "cmbFiyat";
            this.cmbFiyat.Size = new System.Drawing.Size(121, 27);
            this.cmbFiyat.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.button1.Location = new System.Drawing.Point(680, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "Satışı Gerçekleştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(187, 336);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 27);
            this.cmbMusteri.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(808, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6CagirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Proje6DataSet proje6DataSet;
        private System.Windows.Forms.BindingSource proje6CagirBindingSource;
        private Proje6DataSetTableAdapters.Proje6CagirTableAdapter proje6CagirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriAdıSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünFiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbMusteri;
    }
}

