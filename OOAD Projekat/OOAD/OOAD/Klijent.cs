using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    class Klijent : Osoba
    {
        public Klijent(string ime, string prezime, string id, string jmbg, string kontakt, string adresa, string email, TipKlijenta tip, Registracija reg) :
            base(ime, prezime, id, jmbg, kontakt, adresa, email, TipOsobe.Klijent)
        {
            Tip = tip;
            Registracija = reg;
        }

        public enum TipKlijenta { ObicniKlijent, RegistrovaniKlijent };
        public TipKlijenta Tip { get; set; }

        public Registracija @Registracija { get; set; }


    }
}
