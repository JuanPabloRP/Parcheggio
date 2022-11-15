using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcheggio
{
    public partial class CobroTiempo : Form
    {
        PagPrincipal Pp;

        public CobroTiempo()
        {
            InitializeComponent();
        }

        private void CobroTiempo_Load(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pp = new PagPrincipal(null);
            this.Hide();
            Pp.Show();
        }
    }
}
