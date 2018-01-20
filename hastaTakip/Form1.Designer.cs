namespace hastaTakip
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDogumYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnYas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnİndirimliUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "doğum yılı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ucret:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(60, 13);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(60, 66);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "kadın",
            "erkek"});
            this.comboBox1.Location = new System.Drawing.Point(407, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "cinsiyet:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnAdi,
            this.clmnDogumYili,
            this.clmnCinsiyet,
            this.clmnYas,
            this.clmnUcret,
            this.clmnİndirimliUcret});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // clmnAdi
            // 
            this.clmnAdi.FillWeight = 80F;
            this.clmnAdi.HeaderText = "ad soyad";
            this.clmnAdi.Name = "clmnAdi";
            // 
            // clmnDogumYili
            // 
            this.clmnDogumYili.FillWeight = 50F;
            this.clmnDogumYili.HeaderText = "dogumyılı";
            this.clmnDogumYili.Name = "clmnDogumYili";
            this.clmnDogumYili.Width = 50;
            // 
            // clmnCinsiyet
            // 
            this.clmnCinsiyet.FillWeight = 50F;
            this.clmnCinsiyet.HeaderText = "cinsiyet";
            this.clmnCinsiyet.Name = "clmnCinsiyet";
            this.clmnCinsiyet.Width = 50;
            // 
            // clmnYas
            // 
            this.clmnYas.FillWeight = 50F;
            this.clmnYas.HeaderText = "yas";
            this.clmnYas.Name = "clmnYas";
            // 
            // clmnUcret
            // 
            this.clmnUcret.HeaderText = "ucret";
            this.clmnUcret.Name = "clmnUcret";
            // 
            // clmnİndirimliUcret
            // 
            this.clmnİndirimliUcret.HeaderText = "indirimli ucret";
            this.clmnİndirimliUcret.Name = "clmnİndirimliUcret";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(407, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Hasta Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(504, 38);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDogumTarihi.Location = new System.Drawing.Point(60, 41);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.dateDogumTarihi.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 261);
            this.Controls.Add(this.dateDogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDogumYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnYas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnİndirimliUcret;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
    }
}

