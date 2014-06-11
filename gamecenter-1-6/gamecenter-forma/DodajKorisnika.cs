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
    public partial class DodajKorisnika : Form
    {
        public DodajKorisnika()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            DAL.DAL f = DAL.DAL.Instanca;
            try
            {
                // f.kreirajKonekciju("localhost", "gamecenter", "root", "");
                InitializeComponent();
                Klijent x = new Klijent(0, Ime_unos.Text,prezime_unos.Text, jmb_user.Text, kontakt_unos.Text, "default", mail_unos.Text, username_unos.Text, tip_unos.Text, 1);
                DAL.DAL.KlijentDAO klijent = f.getDAO.getKlijentDAO();
                long i = klijent.create(x);

            }
            catch
            {
                MessageBox.Show("Nije uspjelo dodavanje!");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajKorisnika_Load(object sender, EventArgs e)
        {
            
        }

        private void Ime_unos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
