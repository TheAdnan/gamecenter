using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entiteti
{
    public class Igrica
    {
        private string Naziv;
        private string Sifra;
        private Platform Platforma;
        private kategorije Kategorija;
        private boolean Trailer;
        private integer Dostupnost;
        private real Cijena;
        public Igrica()
        {
        }
        ~Igrica()
        {
        }
        public boolean DaLiJeDostupna(integer Dostupnost)
        {
        }
        public string DajKategoriju()
        {
        }
        public string DajPlatformu()
        {
        }
        public string GenerisiSifru()
        {
        }
        public void ObracunajPopust(TipoviRegistracije tip_kupca)
        {
        }
    }
}
