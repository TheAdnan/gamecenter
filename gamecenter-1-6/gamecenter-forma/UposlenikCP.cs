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
        //private TextBox userame;
        //private string username;

        public UposlenikCP()
        {
            InitializeComponent();
        }

        public UposlenikCP(TextBox userame)
        {
            // TODO: Complete member initialization
            
        }
        
        public Uposlenik Cojek = new Uposlenik();
        public List<Klijent> sviKlijenti;
        public List<Igrica> sveIgrice;
        public List<Platform> svePlatforme;
        
        public UposlenikCP(string username)
        {
            DAL.DAL f = DAL.DAL.Instanca;
            try
            {
                // f.kreirajKonekciju("localhost", "gamecenter", "root", "");
                InitializeComponent();
                DAL.DAL.IgricaDAO igrica = f.getDAO.getIgricaDAO();
                sveIgrice = igrica.getAll();
                DAL.DAL.KlijentDAO klijent = f.getDAO.getKlijentDAO();
                sviKlijenti = klijent.getAll();
                DAL.DAL.PlatformDAO v = f.getDAO.getPlatformDAO();
                svePlatforme = v.getAll();
                DAL.DAL.UposlenikDAO uposlenik = f.getDAO.getUposlenikDAO();
                Cojek = uposlenik.getByUsername(username);
                games.DataSource = null;
                users.DataSource = null;
                games.DataSource = sveIgrice;
                users.DataSource = sviKlijenti;
                Cojek.PostaviSliku(Cojek.slika);
                slika_profil.Image = Cojek.Slika;
                xIme.Text = Cojek.Ime;
                xPrezime.Text = Cojek.Prezime;
                xKontakt.Text = Cojek.Kontakt;
                xMail.Text = Cojek.E_Mail;
                xUsername.Text = Cojek.Username;
                xJmbg.Text = Cojek.JMBG;
                platf_combo.DataSource = null;
                platf_combo.DataSource = svePlatforme;
                
                }
                
            
            catch
            {
                MessageBox.Show("Nece da se spoji na bazu");

            }
            
            
        }
        
        private void UposlenikCP_Load(object sender, EventArgs e)
        {

        }

        Image slika1 = Image.FromFile(@"D:\ETF\4. semestar\OOAD\gamecenter-1-6\slike-za-gamecenter\computer-i.png");
        Image slika2 = Image.FromFile(@"D:\ETF\4. semestar\OOAD\gamecenter-1-6\slike-za-gamecenter\computer-o.png");
        private void racunar1_Click_1(object sender, EventArgs e)
        {
            if (racunar1.Image == slika2)
            {
                
                racunar1.Image = slika1;
                racunar1.SizeMode = PictureBoxSizeMode.StretchImage;
               
            }
            else
            {
                racunar1.Image = slika2;
                racunar1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void racunar2_Click(object sender, EventArgs e)
        {
            if (racunar2.Image == slika2)
            {
                racunar2.Image = slika1;
                racunar2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                racunar2.Image = slika2;
                racunar2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void racunar3_Click(object sender, EventArgs e)
        {
            if (racunar3.Image == slika2)
            {
                racunar3.Image = slika1;
                racunar3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                racunar3.Image = slika2;
                racunar3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void racunar4_Click(object sender, EventArgs e)
        {
            if (racunar4.Image == slika2)
            {
                racunar4.Image = slika1;
                racunar4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                racunar4.Image = slika2;
                racunar4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void racunar5_Click(object sender, EventArgs e)
        {
            if (racunar5.Image == slika2)
            {
                racunar5.Image = slika1;
                racunar5.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                racunar5.Image = slika2;
                racunar5.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void racunar6_Click(object sender, EventArgs e)
        {
            if (racunar6.Image == slika2)
            {
                racunar6.Image = slika1;
                racunar6.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                racunar6.Image = slika2;
                racunar6.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void racunar7_Click(object sender, EventArgs e)
        {
            if (racunar7.Image == slika2)
            {
                racunar7.Image = slika1;
                racunar7.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                racunar7.Image = slika2;
                racunar7.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void racunar8_Click(object sender, EventArgs e)
        {
            if (racunar8.Image == slika2)
            {
                racunar8.Image = slika1;
                racunar8.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                racunar8.Image = slika2;
                racunar8.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void igrice_button_Click(object sender, EventArgs e)
        {
            tabovi_uposlenik.SelectedTab = igrice_tab;
        }

        private void korisnici_button_Click(object sender, EventArgs e)
        {
            tabovi_uposlenik.SelectedTab = korisnici_tab;
        }

        private void racunari_button_Click(object sender, EventArgs e)
        {
            tabovi_uposlenik.SelectedTab = racunari_tab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabovi_uposlenik.SelectedTab = profil_tab;
        }

        private void home_tab_Click(object sender, EventArgs e)
        {

        }

        private void igrice_tab_Click(object sender, EventArgs e)
        {
            
        }

        private void slika_profil_Click(object sender, EventArgs e)
        {

        }

        private void games_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(games.SelectedIndex != -1)
            for (int i = 0; i < sveIgrice.Count; i++)
            {
                if (games.SelectedItem.ToString() == sveIgrice[i].ToString())
                {
                    ime_igrice.Text = sveIgrice[i].Naziv;

                    cijena_din.Text = sveIgrice[i].Cijena.ToString() + " KM";
                    
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


        private void platf_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> igrice_filtrirano = new List<String>();
            for(int i=0; i<sveIgrice.Count; i++){
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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void Uhome_Click(object sender, EventArgs e)
        {
            tabovi_uposlenik.SelectedTab = home_tab;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabovi_uposlenik.SelectedTab = home_tab;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabovi_uposlenik.SelectedTab = home_tab;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabovi_uposlenik.SelectedTab = home_tab;
        }

        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (users.SelectedIndex != -1)
                for (int i = 0; i < sviKlijenti.Count; i++)
                {
                    if (users.SelectedItem.ToString() == sviKlijenti[i].ToString())
                    {
                        Uime.Text = sviKlijenti[i].Ime;
                        Uprezime.Text = sviKlijenti[i].Prezime;
                        Ukontakt.Text = sviKlijenti[i].Kontakt;
                        Ujmbg.Text = sviKlijenti[i].JMBG;
                        Umail.Text = sviKlijenti[i].E_Mail;
                        Utip_reg.Text = sviKlijenti[i].TipRegistracije.ToString();
                        Uuser.Text = sviKlijenti[i].Username;
                        sviKlijenti[i].PostaviSliku(sviKlijenti[i].slika);
                        slikajuzera.Image = sviKlijenti[i].Slika;

                    }
                }
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            Klijent x = new Klijent();
            for (int i = 0; i < sviKlijenti.Count; i++)
            {
                if (users.SelectedItem.ToString() == sviKlijenti[i].ToString())
                {
                    x.Username = sviKlijenti[i].Username;
                    x.ID = sviKlijenti[i].ID;
                    x.Prezime = sviKlijenti[i].Prezime;
                    x.Password = sviKlijenti[i].Password;
                    x.JMBG = sviKlijenti[i].JMBG;
                    x.Kontakt = sviKlijenti[i].Kontakt;
                    x.slika = sviKlijenti[i].slika;
                    x.PostaviSliku(x.slika);
                    x.TipRegistracije = sviKlijenti[i].TipRegistracije;
                    x.E_Mail = sviKlijenti[i].E_Mail;
                }

            }
                if (editUser.Text == "Edituj korisnika")
                {
                    editUser.Text = "Potvrdi";
                    
                    Ime_unos.Visible = true;
                    prezime_unos.Visible = true;
                    mail_unos.Visible = true;
                    jmb_user.Visible = true;
                    username_unos.Visible = true;
                    kontakt_unos.Visible = true;
                    tip_unos.Visible = true;
                    Ime_unos.Text = Uime.Text;
                    prezime_unos.Text = Uprezime.Text;
                    kontakt_unos.Text= Ukontakt.Text;
                    jmb_user.Text = Ujmbg.Text;
                    mail_unos.Text = Umail.Text;
                    tip_unos.Text = Utip_reg.Text;
                    username_unos.Text = Uuser.Text;
                    
                }
                else
                {
                    
                    
                    editUser.Text = "Edituj korisnika";

                    Ime_unos.Visible = false;
                    prezime_unos.Visible = false;
                    mail_unos.Visible = false;
                    jmb_user.Visible = false;
                    username_unos.Visible = false;
                    kontakt_unos.Visible = false;
                    tip_unos.Visible = false;
                    Uime.Text = Ime_unos.Text;
                    Uprezime.Text = prezime_unos.Text;
                    Ukontakt.Text = kontakt_unos.Text;
                    Ujmbg.Text = jmb_user.Text;
                    Umail.Text = mail_unos.Text;
                    Utip_reg.Text = tip_unos.Text;
                    Uuser.Text = username_unos.Text;

                    DAL.DAL f = DAL.DAL.Instanca;
                    try
                    {
                        DAL.DAL.KlijentDAO juza = f.getDAO.getKlijentDAO();
                        x.Ime = Uime.Text;
                        x.Prezime = Uprezime.Text;
                        x.Kontakt = Ukontakt.Text;
                        x.JMBG = Ujmbg.Text;
                        x.E_Mail = Umail.Text;
                        x.Username = Uuser.Text;
                        juza.update(x);
                        sviKlijenti = juza.getAll();
                        users.DataSource = null;
                        users.DataSource = sviKlijenti;
                          
                      }

                catch
                    {
                        MessageBox.Show("greška");

                    }

                    }
                    
                    
                    

}
     

        private void addUser_Click(object sender, EventArgs e)
        {
            (new DodajKorisnika()).ShowDialog();
            DAL.DAL f = DAL.DAL.Instanca;
            try
            {
                DAL.DAL.KlijentDAO klijent = f.getDAO.getKlijentDAO();
                sviKlijenti = klijent.getAll();
                users.DataSource = null;
                users.DataSource = sviKlijenti;
            }
            catch
            {
                MessageBox.Show("DAYUM");
            }
            
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            DAL.DAL f = DAL.DAL.Instanca;

            try
            {
                DAL.DAL.KlijentDAO juza = f.getDAO.getKlijentDAO();
                for (int i = 0; i < sviKlijenti.Count; i++)
                {
                    if (users.SelectedItem.ToString() == sviKlijenti[i].ToString())
                    {
                        juza.delete(sviKlijenti[i]);
                        sviKlijenti.RemoveAt(i);
                        users.DataSource = null;
                        users.DataSource = sviKlijenti;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Greška");
            }
        }

        private void button7_Click(object sender, EventArgs e)
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
            if(editujIgru.Text == "Potvrdi")
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
                    x.Platforma = Convert.ToInt32(1);
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
                        sviKlijenti.RemoveAt(i);
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click_1(object sender, EventArgs e)
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

        

        

       

        

        
    }
}
