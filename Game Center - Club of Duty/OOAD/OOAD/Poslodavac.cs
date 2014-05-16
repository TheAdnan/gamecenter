using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    class Poslodavac : Osoba
    {
        public Poslodavac(string ime, string prezime, string id, string jmbg, string kontakt, string adresa, string email) :
            base(ime, prezime, id, jmbg, kontakt, adresa, email, TipOsobe.Poslodavac)
        {

        }
    }
}
