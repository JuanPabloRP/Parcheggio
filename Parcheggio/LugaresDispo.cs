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
    public partial class LugaresDispo : Form
    {
        Usuario user;

        PagPrincipal pP;

        public LugaresDispo(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void LugaresDispo_Load(object sender, EventArgs e)
        {

        }

        private void pictureback_Click(object sender, EventArgs e)
        {
            pP = new PagPrincipal(user);
            pP.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
