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
    public partial class RegisVehiculo : Form
    {

        PagPrincipal Pp;
        Usuario user;
        public RegisVehiculo(Usuario user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pp = new PagPrincipal(user);
            this.Hide();
            Pp.Show();
        }

        private void RegisVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void txtplaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcolor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
