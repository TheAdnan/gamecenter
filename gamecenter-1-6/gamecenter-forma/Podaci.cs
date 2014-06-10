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
    public class Podaci
    {
        public List<Igrica> sveIgrice{get; set;}
        public List<Uposlenik> sviUposlenici{set;get;}
        public List<Recenzent> sviRecenzenti{get; set;}
        public List<Klijent> sviKlijenti{set; get;}
    }
}
