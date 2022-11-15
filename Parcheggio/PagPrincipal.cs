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
    public partial class PagPrincipal : Form
    {
        Usuario user;

        Primera primera;
        RegisVehiculo rV;
        CobroTiempo cT;
        LugaresDispo lD;

        public PagPrincipal(Usuario _user)
        {
            InitializeComponent();
            user = _user;

            label1.Text = $"Bienvenido\n{user.name}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            primera = new Primera();

            primera.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //rV = new RegisVehiculo(user);
            rV = new RegisVehiculo();
            rV.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cT = new CobroTiempo(user);
            cT = new CobroTiempo();
            cT.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //lD = new LugaresDispo(user);
            lD = new LugaresDispo();
            lD.Show();
            this.Hide();
        }
    }
}
