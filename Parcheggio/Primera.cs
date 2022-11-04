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
    public partial class Primera : Form
    {
        public Primera()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            inicioDeSesion PI = new inicioDeSesion();
            this.Hide();
            PI.Show();  

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro Reg = new Registro();
            this.Hide();
            Reg.Show();
        }
    }
}
