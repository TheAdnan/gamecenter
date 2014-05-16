using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    abstract class Osoba
    {
        public Osoba(string ime, string prezime, string id, string jmbg, string kontakt, string adresa, string email, TipOsobe tip)
        {
            Ime = ime;
            Prezime = prezime;
            ID = id;
            JMBG = jmbg;
            Kontakt = kontakt;
            Adresa = adresa;
            Email = email;
            Tip = tip;

            
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ID { get; set; }
        public string JMBG { get; set; }
        public string Kontakt { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }

        public enum TipOsobe { Poslodavac, Recenzent, Racunovodja, Uposlenik, Klijent };
        public TipOsobe Tip { get; set; }

    }
}
