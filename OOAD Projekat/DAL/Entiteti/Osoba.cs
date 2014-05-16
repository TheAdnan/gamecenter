using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Osoba
    {
        private string ime;
        private string prezime;
        private string id;
        private string jmbg;
        private string kontakt;
        private string adresa;
        private string email;


        public Osoba(string i, string p, string d, string j, string k, string a, string e)
        {
            this.Ime = i;
            this.Prezime = p;
            this.ID = d;
            this.JMBG = j;
            this.Kontakt = k;
            this.Adresa = a;
            this.Email = e;

        }

        ~Osoba() { }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ID { get; set; }
        public string JMBG { get; set; }
        public string Kontakt { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }

     
    }
}
