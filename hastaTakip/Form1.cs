using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
         DateTime dogumTarihi =  dateDogumTarihi.Value;// datetime :
            Hasta hasta = new Hasta();

            hasta.Adi = txtAdSoyad.Text;
            hasta.Ucret = Convert.ToInt32(txtUcret.Text);
            hasta.DogumYili = Convert.ToInt32(54);
            hasta.Cinsiyet = comboBox1.Text;
            hasta.YasHesapla();
            hasta.İndirimliUcretHesapla();

         dataGridView1.Rows.Add(hasta.Adi,hasta.DogumYili,hasta.Cinsiyet,hasta.Yas,hasta.Ucret,hasta.İndirimliUcret);

        }
    }
}
