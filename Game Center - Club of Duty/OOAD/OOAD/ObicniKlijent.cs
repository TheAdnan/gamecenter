using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    class ObicniKlijent : Klijent
    {
        public ObicniKlijent(string ime, string prezime, string id, string jmbg, string kontakt, string adresa, string email, Registracija reg) :
            base(ime, prezime, id, jmbg, kontakt, adresa, email, TipKlijenta.ObicniKlijent, reg)
        {

        }
    }
}
