using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter.klase
{
    class Igrica
    {
        public String Naziv{get; set;}
        public String Sifra { get; set; }
        public Platform Platforma { get; set; }
        public Kategorije Kategorija  { get; set; }
        public bool Trailer { get; set; }
        public int Dostupnost { get; set; }
        public double Cijena { get; set; }
        
    }
}
