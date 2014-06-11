﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameCenter.klase
{
    public class Uposlenik: Osoba
    {
        
        public double Plata { get; set; }
        public int RadnoVrijeme { get; set; }
        public Uposlenik(int id, String ime, String prezime, String jmbg, String kontakt, String swika, String email, String user, String pass, double plata, int radno_vrijeme)
            : base(id, ime, prezime, jmbg, kontakt, swika, email, user, pass)
        {
           Plata = plata; RadnoVrijeme = radno_vrijeme;
        }

        public Uposlenik()
        {
            // TODO: Complete member initialization
        }
    }
}
