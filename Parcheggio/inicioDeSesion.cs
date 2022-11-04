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
    public partial class inicioDeSesion : Form
    {
        Primera back;
        Registro irRegis;
        PagPrincipal irpagPrincipal;
        public inicioDeSesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtusuario.Text != "" && txtcontra.Text != "")
            {
                irpagPrincipal = new PagPrincipal();
                irpagPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
            }
        }

        private void pictureback_Click(object sender, EventArgs e)
        {
            back = new Primera();
            back.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            irRegis = new Registro();
            irRegis.Show();
        }
    }
}
