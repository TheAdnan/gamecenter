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
                d.kreirajKonekciju("localhost", "gamecenter", "root", "");

                DAL.DAL.UposlenikDAO sd = d.getDAO.getUposlenikDAO();
                Uposlenik u = sd.getByUsername(username.Text);
                if (u != null)
                {
                    if (u.Password == password.Text)
                    {

                        Hide();
                        (new afterlogin()).ShowDialog();
                        Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Neuspješno loginovaniranje!");
                    }
                }
                else MessageBox.Show("Neuspješno loginovaniranje!");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "gamecenter", "root", "");
            DAL.DAL.UposlenikDAO sd = d.getDAO.getUposlenikDAO();
            Uposlenik u = sd.getByUsername(username.Text);
            if (u != null)
            {
                if (u.Password == password.Text)
                {

                    Hide();
                    (new afterlogin()).ShowDialog();
                    Show();
                    
                }
                else
                {
                    MessageBox.Show("Neuspješno loginovaniranje!");
                }
            }
            else MessageBox.Show("Neuspješno loginovaniranje!");
           
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }

        private void izadji_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
