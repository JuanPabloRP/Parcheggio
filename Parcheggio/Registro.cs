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
    public partial class Registro : Form
    {

        inicioDeSesion irInicarSesion;

        public Registro()
        {
            InitializeComponent();
            int x1 = 0, x2;

            //un poco de matematicas, restando los anchos y dividiendo entre 2
            x1 = (this.Width / 2) - (label1.Width / 2);

            label1.Location = new System.Drawing.Point(x1, label1.Location.Y);

            x2 = (this.Width / 2) - (btnRegistrarse.Width / 2);
            btnRegistrarse.Location = new System.Drawing.Point(x2, btnRegistrarse.Location.Y);

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            irInicarSesion = new inicioDeSesion();

            irInicarSesion.Show();
            this.Hide();
        }
    }
}
