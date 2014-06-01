using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameCenter;


namespace GameCenter.klase
{
    class Klijent: Osoba
    {
        public enum TipKlijenta
        {
            Obicni, Registrovani
        };
        public enum TipoviRegistracije
        {
            AllTime, Mjesecni, Godisnji
        };
        public TipoviRegistracije Tip_registracije { get; set; }
        public TipKlijenta Tip_klijenta { get; set; }
        public List<String> Subscriptions { get; set; }
        public Klijent(int id, String ime, String prezime, int jmbg, String kontakt, String adresa, String email, String user, String pass, TipKlijenta tk, TipoviRegistracije tr)
            : base(id, ime, prezime, jmbg, kontakt, adresa, email, user, pass)
        {
            Tip_klijenta = tk;
            Tip_registracije = tr;
            Subscriptions = new List<String>();
        }
    }
}
