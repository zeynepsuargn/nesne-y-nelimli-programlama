using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Personal
    {
        public Personal( string gAd, int gYas,string gAdres,string gUnvan,int gMesai) 
        { 
            this.Ad=gAd;
            this.Yas=gYas;
            this.Adres=gAdres;
            this.Unvan=gUnvan;
            this.Mesai=gMesai;
        }
        string unvan;

        public string Unvan
        { get { return unvan; }
            set { unvan = value; }
        }   
        string ad;
        public string Ad
        { get { return ad; }
            set {  ad = value; } 
        }
        int yas;
        public int Yas
        { get { return yas; }
            set { yas = value; }
        }
        int mesai;
            public int Mesai
        { get { return mesai; }
            set {  mesai = value; }
        }
        public int ucretHesapla()
        {
            return this.Mesai * 100;
        }
        public void ucretHesapla(int ekUcret)
        {
            int odenecek=this.Mesai*100 + ekUcret;
            MessageBox.Show(odenecek.ToString());

        }
        string adres;
        public string Adres
        { get { return adres; }
            set {  adres = value; }
        }
            
    }
}
