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

        public Klijent Cojek = new Klijent();
        public List<Igrica> sveIgrice;
        public List<Platform> svePlatforme;
        
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
                InitializeComponent();
               // f.kreirajKonekciju("localhost", "gamecenter", "root", "");
                DAL.DAL.IgricaDAO igrica = f.getDAO.getIgricaDAO();
                sveIgrice = igrica.getAll();             
                DAL.DAL.PlatformDAO v = f.getDAO.getPlatformDAO();
                svePlatforme = v.getAll();
                DAL.DAL.KlijentDAO klajent = f.getDAO.getKlijentDAO();
                Cojek = klajent.getByUsername(username);
                games.DataSource = null;
                
                games.DataSource = sveIgrice;
                
                Cojek.PostaviSliku(Cojek.slika);
                slika_profil.Image = Cojek.Slika;
                xIme.Text = Cojek.Ime;
                xPrezime.Text = Cojek.Prezime;
                xKontakt.Text = Cojek.Kontakt;
                xMail.Text = Cojek.E_Mail;
                xUsername.Text = Cojek.Username;
                xJmbg.Text = Cojek.JMBG;
                if (Cojek.TipRegistracije.ToString() == "1")
                {
                    reg2.Text = "All time";
                }
                else if (Cojek.TipRegistracije.ToString() == "1")
                {
                    reg2.Text = "Godisnja registracija";
                }
                else reg2.Text = "Mjesecna registracija";
                platf_combo.DataSource = null;
                platf_combo.DataSource = svePlatforme;
                
            }
            catch
            {
            MessageBox.Show("Nece da se spoji na bazu");
                
            }
            
           
        }

        private void KlijentCP_Load(object sender, EventArgs e)
        {
            
            
       }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabovi_klijent.SelectedTab = profil_tab;
        }

        
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void racunari_button_Click(object sender, EventArgs e)
        {
            tabovi_klijent.SelectedTab = s_c_tab;
        }

        private void igrice_button_Click_1(object sender, EventArgs e)
        {
            tabovi_klijent.SelectedTab = igrice_tab;
        }
        

        private void games_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (games.SelectedIndex != -1)
                for (int i = 0; i < sveIgrice.Count; i++)
                {
                    if (games.SelectedItem.ToString() == sveIgrice[i].ToString())
                    {
                        ime_igrice.Text = sveIgrice[i].Naziv;

                        cijena_din.Text = sveIgrice[i].Cijena.ToString();

                        for (int k = 0; k < svePlatforme.Count; k++)
                        {
                            if (svePlatforme[k].ID == sveIgrice[i].Platforma)
                            {
                                platf_din.Text = svePlatforme[i].Naziv;
                            }
                        }
                        dost_din.Text = sveIgrice[i].Dostupnost.ToString();
                        kat_din.Text = sveIgrice[i].Kategorija;
                        sveIgrice[i].PostaviSliku(sveIgrice[i].slika);
                        slika_igrice.Image = sveIgrice[i].Slika;

                    }
                }
        }

        private void platf_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<String> igrice_filtrirano = new List<String>();
            for (int i = 0; i < sveIgrice.Count; i++)
            {
                for (int j = 0; j < svePlatforme.Count; j++)
                {
                    if ((svePlatforme[j].ID == sveIgrice[i].Platforma) && (platf_combo.SelectedItem.ToString() == svePlatforme[j].ToString()))
                    {
                        igrice_filtrirano.Add(sveIgrice[i].ToString());
                    }
                }
            }
            games.DataSource = igrice_filtrirano;
        }

        private void exit_button_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < sveIgrice.Count; i++)
            {
                if (games.SelectedItem.ToString() == sveIgrice[i].ToString())
                {
                    axWindowsMediaPlayer1.URL = @"D:\ETF\4. semestar\OOAD\gamecenter-1-6\video\" + sveIgrice[i].slika + ".mp4";
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabovi_klijent.SelectedTab = Home_tab;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabovi_klijent.SelectedTab = Home_tab;
        }

    }
}
