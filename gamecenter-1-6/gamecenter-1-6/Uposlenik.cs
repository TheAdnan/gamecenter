using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter.klase
{
    public class Uposlenik: Osoba
    {
        
        public double Plata { get; set; }
        public int RadnoVrijeme { get; set; }
        public Uposlenik(int id, String ime, String prezime, String jmbg, String kontakt, String adresa, String email, String user, String pass, double plata, int radno_vrijeme)
            : base(id, ime, prezime, jmbg, kontakt, adresa, email, user, pass)
        {
           Plata = plata; RadnoVrijeme = radno_vrijeme;
        }
    }
}
