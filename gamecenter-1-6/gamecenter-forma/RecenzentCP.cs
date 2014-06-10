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
    public partial class RecenzentCP : Form
    {
       // private TextBox username;
        //private string user;
        public static Podaci p = new Podaci();
        public Recenzent  Reco = new Recenzent();
        public RecenzentCP()
        {
            InitializeComponent();
        }

        public RecenzentCP(TextBox username)
        {
            // TODO: Complete member initialization
            
        }
        
        public RecenzentCP(string user)
        {
            DAL.DAL f = DAL.DAL.Instanca;
            try
            {
                // f.kreirajKonekciju("localhost", "gamecenter", "root", "");

                DAL.DAL.IgricaDAO igrica = f.getDAO.getIgricaDAO();
                p.sveIgrice = igrica.getAll();

                DAL.DAL.RecenzentDAO recenzent = f.getDAO.getRecenzentDAO();
                Reco = recenzent.getByUsername(user);

            }
            catch
            {
                MessageBox.Show("Nece da se spoji na bazu");

            }
            InitializeComponent();

            
        }

        private void RecenzentCP_Load(object sender, EventArgs e)
        {

        }
    }
}
