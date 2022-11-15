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

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            rV = new RegisVehiculo(user);
            rV.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cT = new CobroTiempo(user);
            this.Hide();
            cT.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            lD = new LugaresDispo(user);
            lD.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            primera = new Primera();
            primera.Show();
            this.Hide();
        }
    }
}
