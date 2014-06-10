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
    public partial class RecenzentCP : Form
    {
        private TextBox username;
        private string p;

        public RecenzentCP()
        {
            InitializeComponent();
        }

        public RecenzentCP(TextBox username)
        {
            // TODO: Complete member initialization
            this.username = username;
        }

        public RecenzentCP(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        private void RecenzentCP_Load(object sender, EventArgs e)
        {

        }
    }
}
