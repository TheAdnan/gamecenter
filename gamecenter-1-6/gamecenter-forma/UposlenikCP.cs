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
        private TextBox username;
        private string p;

        public UposlenikCP()
        {
            InitializeComponent();
        }

        public UposlenikCP(TextBox username)
        {
            // TODO: Complete member initialization
            this.username = username;
        }

        public UposlenikCP(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
    }
}
