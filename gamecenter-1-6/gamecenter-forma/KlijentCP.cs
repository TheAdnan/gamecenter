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
        
        public Klijent Klajent= new Klijent();
        public static List<Igrica> sveIgrice;
        
        public KlijentCP()
        {
            InitializeComponent();
        }

        public KlijentCP(String username)
        {
            // TODO: Complete member initialization
            
            DAL.DAL f = DAL.DAL.Instanca;
            try
            { 
               // f.kreirajKonekciju("localhost", "gamecenter", "root", "");

                DAL.DAL.IgricaDAO igrica = f.getDAO.getIgricaDAO();
                sveIgrice = igrica.getAll();
                DAL.DAL.KlijentDAO klajent = f.getDAO.getKlijentDAO();
                Klajent = klajent.getByUsername(username);
                
            }
            catch
            {
            MessageBox.Show("Nece da se spoji na bazu");
                
            }
            InitializeComponent();
           
        }

        private void KlijentCP_Load(object sender, EventArgs e)
        {
            
            
       }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Klajent.Ime);
        }
    }
}
