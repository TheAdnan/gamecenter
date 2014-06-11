using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameCenter;
using System.Drawing;
using System.Windows.Forms;


namespace GameCenter.klase
{
    public class Klijent: Osoba
    {
        
        public static List<Igrica> ShoppingCart{ get ;set; }
        public int TipRegistracije { get; set; }
        public List<String> Subscriptions { get; set; }
        
        public Klijent(int id, String ime, String prezime, String jmbg, String kontakt, String swika, String email, String user, String pass, int tipReg)
            : base(id, ime, prezime, jmbg, kontakt, swika, email, user, pass)
        {
            TipRegistracije = tipReg;
        }

        public Klijent()
        {
            
        }
        
        
        void DodajUShoppingCart(Igrica i)
        {
            i.Cijena = obracunajPopust(i);
            ShoppingCart.Add(i);
        }

        double obracunajPopust(Igrica i)
        {
            double x = i.Cijena;
            if (this.TipRegistracije == 0)
            {
                return i.Cijena;
            }
            else if (TipRegistracije == 1)
            {
                x = x - x * 0.05;
                return x;
            }
            else if (TipRegistracije == 2)
            {
                x = x - x * 0.07;
                return x;
            }
            else x = x - x * 0.1;
            return x;
        }
    }
}
