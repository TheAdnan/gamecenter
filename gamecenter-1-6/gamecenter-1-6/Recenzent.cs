using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameCenter.klase
{
   public  class Recenzent: Osoba
    {
        public double Plata { get; set; }
        public int RadnoVrijeme { get; set; }
       public Recenzent(int id, String ime, String prezime, String jmbg, String kontakt, String adresa, String email, String user, String pass, double plata, int radno_vrijeme)
            : base(id, ime, prezime, jmbg, kontakt, adresa, email, user, pass)
        {
        Plata = plata; RadnoVrijeme = radno_vrijeme;
        }
    }
}
