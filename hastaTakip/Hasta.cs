using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaTakip
{
    class Hasta
    {
        public string Adi;
        public int Ucret;
        public int DogumYili;
        public string Cinsiyet;
        public int Yas;
        public  int İndirimliUcret;

     public   void YasHesapla()
        {
            Yas = DateTime.Now.Year - DogumYili;
        
        }
        public void İndirimliUcretHesapla()
        {
            if (Yas>=65)
            {
                İndirimliUcret = 0;
            }
            else if (Cinsiyet=="kadın")
            {
                İndirimliUcret =( Ucret *80)/100;
                

            }

            else if (Yas<15)
            {
                İndirimliUcret = Ucret * 50 / 100;
            }
            else
            {
                İndirimliUcret = Ucret;
            }
        }
    }
}
