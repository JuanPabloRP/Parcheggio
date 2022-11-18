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
    public partial class EditarPuesto : Form
    {
        LugaresDispo Ld;
        Usuario user;
        public EditarPuesto(Usuario _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtplaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ld = new LugaresDispo(user);
            Ld.Show();
            this.Hide(); ;
        }
    }
}
