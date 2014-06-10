using GameCenter.klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamecenter_forma
{
    public partial class UposlenikCP : Form
    {
        private TextBox userame;
        private string username;

        public UposlenikCP()
        {
            InitializeComponent();
        }

        public UposlenikCP(TextBox userame)
        {
            // TODO: Complete member initialization
            
        }
        public static Podaci p = new Podaci();
        public Uposlenik Cojek = new Uposlenik();
        public UposlenikCP(string username)
        {
            DAL.DAL f = DAL.DAL.Instanca;
            try
            {
                // f.kreirajKonekciju("localhost", "gamecenter", "root", "");

                DAL.DAL.IgricaDAO igrica = f.getDAO.getIgricaDAO();
                p.sveIgrice = igrica.getAll();
                DAL.DAL.KlijentDAO klijent = f.getDAO.getKlijentDAO();
                p.sviKlijenti = klijent.getAll();
                DAL.DAL.UposlenikDAO uposlenik = f.getDAO.getUposlenikDAO();
                Cojek = uposlenik.getByUsername(username);

            }
            catch
            {
                MessageBox.Show("Nece da se spoji na bazu");

            }
            InitializeComponent();
            
        }

        private void UposlenikCP_Load(object sender, EventArgs e)
        {

        }
    }
}
