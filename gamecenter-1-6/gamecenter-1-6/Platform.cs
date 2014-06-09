using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameCenter.klase
{
    public class Platform
    {
        public int ID { get; set; }
        public String Naziv { get; set; }
        public List<Klijent> Subscriberi { get; set; }
        public Platform(int id, String naziv)
        {
            Naziv = naziv;
            ID = id;
        }

    }
}
