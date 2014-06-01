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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "gamecenter", "root", "");

            DAL.DAL.UposlenikDAO sd = d.getDAO.getUposlenikDAO();
            Uposlenik u = sd.getByUsername(textBox1.Text);
            if (u != null)
                if (u.Password == textBox2.Text)
                {
                    d.terminirajKonekciju();
                    Hide();
                    (new afterlogin()).ShowDialog();
                    Show();
                }
            //MessageBox.Show(u.Count.ToString());
        }
    }
}
