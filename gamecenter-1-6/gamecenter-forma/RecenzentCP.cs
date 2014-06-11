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
     
        public Recenzent  Reco = new Recenzent();
        
        public List<Igrica> sveIgrice;
        public List<Platform> svePlatforme;
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
                InitializeComponent();
                DAL.DAL.IgricaDAO igrica = f.getDAO.getIgricaDAO();
                sveIgrice = igrica.getAll();
                
                DAL.DAL.PlatformDAO v = f.getDAO.getPlatformDAO();
                svePlatforme = v.getAll();
                DAL.DAL.RecenzentDAO recenzent = f.getDAO.getRecenzentDAO();
                Reco = recenzent.getByUsername(user);
                games.DataSource = null;
                games.DataSource = sveIgrice;
                Reco.PostaviSliku(Reco.slika);
                slika_profil.Image = Reco.Slika;
                xIme.Text = Reco.Ime;
                xPrezime.Text = Reco.Prezime;
                xKontakt.Text = Reco.Kontakt;
                xMail.Text = Reco.E_Mail;
                xUsername.Text = Reco.Username;
                xJmbg.Text = Reco.JMBG;
                platf_combo.DataSource = null;
                platf_combo.DataSource = svePlatforme;

            }
            catch
            {
                MessageBox.Show("Nece da se spoji na bazu");

            }
            

            
        }

        private void RecenzentCP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabovi_rec.SelectedTab = profil_tab;
        }

        private void home_tab_Click(object sender, EventArgs e)
        {
            
        }

        private void igrice_button_Click(object sender, EventArgs e)
        {
            tabovi_rec.SelectedTab = igrice_tab;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabovi_rec.SelectedTab = home_tab;
        }

        
            private void games_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (games.SelectedIndex != -1)
            {
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
         }
            private void platf_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

            private void editujIgru_Click(object sender, EventArgs e)
            {
                Igrica x = new Igrica();
                for (int i = 0; i < sveIgrice.Count; i++)
                {
                    if (games.SelectedItem.ToString() == sveIgrice[i].ToString())
                    {
                        x.Naziv = sveIgrice[i].Naziv;
                        x.Kategorija = sveIgrice[i].Kategorija;
                        x.Platforma = sveIgrice[i].Platforma;
                        x.Sifra = sveIgrice[i].Sifra;
                        x.Trailer = sveIgrice[i].Trailer;
                        x.Dostupnost = sveIgrice[i].Dostupnost;
                        x.Cijena = sveIgrice[i].Cijena;
                        x.slika = sveIgrice[i].slika;
                        x.PostaviSliku(x.slika);
                    }
                }
                if (editujIgru.Text == "Potvrdi")
                {
                    editujIgru.Text = "Edituj igricu";
                    p_u.Visible = false;
                    k_u.Visible = false;
                    d_u.Visible = false;
                    c_u.Visible = false;
                    platf_din.Text = p_u.Text;
                    kat_din.Text = k_u.Text;
                    dost_din.Text = d_u.Text;
                    cijena_din.Text = c_u.Text;


                    DAL.DAL f = DAL.DAL.Instanca;
                    try
                    {
                        x.Kategorija = k_u.Text;
                        x.Platforma = Convert.ToInt32(p_u.Text);
                        x.Dostupnost = Convert.ToInt32(d_u.Text);
                        x.Cijena = Convert.ToDouble(c_u.Text);
                        DAL.DAL.IgricaDAO juza = f.getDAO.getIgricaDAO();

                        juza.update(x);



                        sveIgrice = juza.getAll();
                        games.DataSource = null;
                        games.DataSource = sveIgrice;

                    }
                    catch
                    {
                        MessageBox.Show("greška");

                    }

                }
                else
                {
                    editujIgru.Text = "Potvrdi";
                    p_u.Visible = true;
                    k_u.Visible = true;
                    d_u.Visible = true;
                    c_u.Visible = true;
                    p_u.Text = platf_din.Text;
                    k_u.Text = kat_din.Text;
                    d_u.Text = dost_din.Text;
                    c_u.Text = cijena_din.Text;

                }
            
            }

            private void button9_Click(object sender, EventArgs e)
            {
                (new DodajIgricu()).ShowDialog();
                DAL.DAL f = DAL.DAL.Instanca;
                try
                {
                    DAL.DAL.IgricaDAO aj = f.getDAO.getIgricaDAO();
                    sveIgrice = aj.getAll();
                    games.DataSource = null;
                    games.DataSource = sveIgrice;
                }
                catch
                {
                    MessageBox.Show("DAYUM");
                }
            }

            private void button8_Click(object sender, EventArgs e)
            {
                DAL.DAL f = DAL.DAL.Instanca;

                try
                {
                    DAL.DAL.IgricaDAO juza = f.getDAO.getIgricaDAO();
                    for (int i = 0; i < sveIgrice.Count; i++)
                    {
                        if (games.SelectedItem.ToString() == sveIgrice[i].ToString())
                        {
                            juza.delete(sveIgrice[i]);
                            sveIgrice.RemoveAt(i);
                            games.DataSource = null;
                            games.DataSource = sveIgrice;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Greška");
                }
            }

            private void slika_profil_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
                tabovi_rec.SelectedTab = home_tab;
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
        }
    }

