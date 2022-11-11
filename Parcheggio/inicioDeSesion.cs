using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcheggio.clases;

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

        }
        private void pictureback_Click(object sender, EventArgs e)
        {
            back = new Primera();
            back.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            irRegis = new Registro();
            irRegis.Show();
            this.Hide();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {

            bool res = false;
            foreach (Usuario user in Usuario.usuarios)
            {
                res = user.validar(txtusuario.Text, txtcontra.Text);
                if (res == true)
                {
                    break;
                }
            }

            if (res == true)
            {
                MessageBox.Show("Bienvenido :)");
                irpagPrincipal = new PagPrincipal();
                irpagPrincipal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña es incorrecta");
            }

            txtusuario.Text = "";
            txtcontra.Clear();         
        }
    }
}
