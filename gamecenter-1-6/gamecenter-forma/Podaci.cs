using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCenter.klase;
using System.Windows.Forms;
using System.Drawing;

namespace gamecenter_forma
{
    public static class Podaci
    {
        public static List<Igrica> sveIgrice{get; set;}
        public static List<Uposlenik> sviUposlenici{set;get;}
        public static List<Recenzent> sviRecenzenti{get; set;}
        public static List<Klijent> sviKlijenti{set; get;}
    }
}
