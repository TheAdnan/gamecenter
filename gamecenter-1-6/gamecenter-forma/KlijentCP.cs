using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCenter.klase;

namespace gamecenter_forma
{
    public partial class KlijentCP : Form
    {
        public KlijentCP()
        {
            InitializeComponent();
        }

        private void KlijentCP_Load(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "gamecenter", "root", "");
                       
           }
    }
}
