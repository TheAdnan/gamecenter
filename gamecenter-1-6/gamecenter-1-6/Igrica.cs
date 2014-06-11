using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameCenter.klase
{
    public class Igrica
    {
        public int Sifra { get; set; }
        public String Naziv{get; set;}
        
        public int Platforma { get; set; }
        public String Kategorija  { get; set; }
        public bool Trailer { get; set; }
        public int Dostupnost { get; set; }
        public double Cijena { get; set; }

        public String slika { get; set; }
        public  Image Slika;

        public void PostaviSliku(String swika)
        {
            Slika = Image.FromFile(@"D:\ETF\4. semestar\OOAD\gamecenter-1-6\slike-igrica\" + swika + ".jpg");
        }
        public Igrica(int sifra, String name, bool trejler, int available, double cijena, int pltfrm, String ktgr, String sliks)
        {
            Naziv = name; Sifra = sifra; Trailer = trejler; Dostupnost = available; Cijena = cijena; Platforma = pltfrm; Kategorija = ktgr; slika = sliks;
        }

        public override String ToString()
        {
            return Naziv;
        }
        
    }
}
