using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameCenter.klase
{
    public abstract class Osoba
    {
        public int ID { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String JMBG { get; set; }
        public String Kontakt { get; set; }
        public String Adresa { get; set; }
        public String E_Mail { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Osoba(int id, String ime, String prezime, String jmbg, String kontakt, String adresa, String email, String user, String pass)
        {
            Ime = ime; Prezime = prezime; ID = id; JMBG = jmbg; Kontakt = kontakt; Adresa = adresa; E_Mail = email; Username = user; Password = pass;
        }
    }
}
