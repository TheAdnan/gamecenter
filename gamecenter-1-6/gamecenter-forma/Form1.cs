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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DAL.DAL d = DAL.DAL.Instanca;
                try
                {
                    d.kreirajKonekciju("localhost", "gamecenter", "root", "");
                    DAL.DAL.UposlenikDAO sd = d.getDAO.getUposlenikDAO();
                    DAL.DAL.RecenzentDAO rd = d.getDAO.getRecenzentDAO();
                    DAL.DAL.KlijentDAO kd = d.getDAO.getKlijentDAO();
                    Uposlenik u = sd.getByUsername(username.Text);
                    Klijent k = kd.getByUsername(username.Text);
                    Recenzent r = rd.getByUsername(username.Text);
                    if (u != null)
                    {
                        if (u.Password == password.Text)
                        {

                            Hide();
                            (new UposlenikCP()).ShowDialog();
                            Show();

                        }
                        else MessageBox.Show("Neuspješno loginovaniranje!");

                    }
                    // else MessageBox.Show("Neuspješno loginovaniranje!");
                    else if (k != null)
                    {
                        if (k.Password == password.Text)
                        {

                            Hide();
                            (new KlijentCP()).ShowDialog();
                            Show();

                        }
                        else MessageBox.Show("Neuspješno loginovaniranje!");

                    }
                    // else MessageBox.Show("Neuspješno loginovaniranje!");
                    else if (r != null)
                    {
                        if (r.Password == password.Text)
                        {

                            Hide();
                            (new RecenzentCP()).ShowDialog();
                            Show();

                        }
                        else MessageBox.Show("Neuspješno loginovaniranje!");

                    }
                    else MessageBox.Show("Neuspješno loginovaniranje!");
                }
                catch
                {
                    MessageBox.Show("Niste spojeni na bazu!");
                }
                e.KeyChar = (char)0;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            try
            {
                d.kreirajKonekciju("localhost", "gamecenter", "root", "");
                DAL.DAL.UposlenikDAO sd = d.getDAO.getUposlenikDAO();
                DAL.DAL.RecenzentDAO rd = d.getDAO.getRecenzentDAO();
                DAL.DAL.KlijentDAO kd = d.getDAO.getKlijentDAO();
                Uposlenik u = sd.getByUsername(username.Text);
                Klijent k = kd.getByUsername(username.Text);
                Recenzent r = rd.getByUsername(username.Text);
                if (u != null)
                {
                    if (u.Password == password.Text)
                    {

                        Hide();
                        (new UposlenikCP()).ShowDialog();
                        Show();

                    }
                    else MessageBox.Show("Neuspješno loginovaniranje!");

                }
                // else MessageBox.Show("Neuspješno loginovaniranje!");
                else if (k != null)
                {
                    if (k.Password == password.Text)
                    {

                        Hide();
                        (new KlijentCP()).ShowDialog();
                        Show();

                    }
                    else MessageBox.Show("Neuspješno loginovaniranje!");

                }
                // else MessageBox.Show("Neuspješno loginovaniranje!");
                else if (r != null)
                {
                    if (r.Password == password.Text)
                    {

                        Hide();
                        (new RecenzentCP()).ShowDialog();
                        Show();

                    }
                    else MessageBox.Show("Neuspješno loginovaniranje!");

                }
                else MessageBox.Show("Neuspješno loginovaniranje!");
            }
            catch
            {
                MessageBox.Show("Niste spojeni na bazu!");
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }

        private void izadji_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
