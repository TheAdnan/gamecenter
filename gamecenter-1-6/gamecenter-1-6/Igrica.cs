using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter.klase
{
    public class Igrica
    {
        public int Sifra { get; set; }
        public String Naziv{get; set;}
        
        public Platform Platforma { get; set; }
        public Kategorije Kategorija  { get; set; }
        public bool Trailer { get; set; }
        public int Dostupnost { get; set; }
        public double Cijena { get; set; }
        public Igrica(int sifra, String name, bool trejler, int available, double cijena)
        {
            Naziv = name; Sifra = sifra; Trailer = trejler; Dostupnost = available; Cijena = cijena;
        }
        
    }
}
