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
    public partial class DodajIgricu : Form
    {
        public DodajIgricu()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            DAL.DAL f = DAL.DAL.Instanca;
            try
            {
                // f.kreirajKonekciju("localhost", "gamecenter", "root", "");
                //InitializeComponent();
                Igrica x = new Igrica(0, xNaziv.Text, false, Convert.ToInt32(xDostupnost.Text), Convert.ToDouble(xCijena.Text), Convert.ToInt16(xPlatforma.Text), xKategorija.Text, "default");
                
                DAL.DAL.IgricaDAO aj = f.getDAO.getIgricaDAO();
                aj.create(x);
                MessageBox.Show("Uspjesno je dodan!");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Nije uspjelo dodavanje!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
