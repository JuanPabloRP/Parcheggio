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
        Usuario user;
        public CobroTiempo(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CobroTiempo_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pp = new PagPrincipal(user);
            this.Hide();
            Pp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
