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

        

       

        

        
    }
}
