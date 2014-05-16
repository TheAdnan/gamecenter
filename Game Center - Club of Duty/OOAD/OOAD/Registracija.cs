using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    abstract class Registracija
    {
        public Registracija(TipRegistracije tip)
        {
            Tip = tip;
        }
        public enum TipRegistracije { Bezreg, Mjesecna, Godisnja, AllTime }
        public TipRegistracije Tip { get; set; }

        public abstract decimal DajPopust();
    }
}
