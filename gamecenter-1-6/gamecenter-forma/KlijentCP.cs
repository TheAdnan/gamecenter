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
    public partial class KlijentCP : Form
    {
        public static Podaci p = new Podaci();
        public Klijent Klajent= new Klijent();
        
        
        public KlijentCP()
        {
            InitializeComponent();
        }

        public KlijentCP(String username)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            try
            { 
                //d.kreirajKonekciju("localhost", "gamecenter", "root", "");

                DAL.DAL.IgricaDAO igrica = d.getDAO.getIgricaDAO();
                p.sveIgrice = igrica.getAll();
                DAL.DAL.KlijentDAO klajent = d.getDAO.getKlijentDAO();
                Klajent = klajent.getByUsername(username);
            }
            catch
            {
            //     MessageBox.Show("Nece da se spoji na bazu");
                
            }
           
        }

        private void KlijentCP_Load(object sender, EventArgs e)
        {
            
            
       }
    }
}
