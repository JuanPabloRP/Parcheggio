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
    public partial class EliminarPuesto : Form
    {
        LugaresDispo Ld;
        Usuario user;
        public EliminarPuesto(Usuario _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCrearPuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearPuesto_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureback_Click(object sender, EventArgs e)
        {
            Ld = new LugaresDispo(user);
            Ld.Show();
            this.Hide();
        }
    }
}
