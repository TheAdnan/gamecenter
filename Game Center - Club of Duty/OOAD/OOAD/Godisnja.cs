using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    class Godisnja : Registracija
    {
        public override decimal DajPopust()
        {
            return 40;
        }
    }
}
