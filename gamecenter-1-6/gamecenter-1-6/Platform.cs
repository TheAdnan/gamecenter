using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameCenter.klase
{
    public class Platform
    {
        public String Naziv { get; set; }
        public List<Klijent> Subscriberi { get; set; }
        public Platform(String naziv)
        {
            Naziv = naziv;
        }

    }
}
