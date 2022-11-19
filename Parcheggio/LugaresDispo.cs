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

            verPuestos();
        }

        

        private void pictureback_Click(object sender, EventArgs e)
        {
            pP = new PagPrincipal(user);
            pP.Show();
            this.Hide();
        }


        //pa ver los puestos xd - si quiere usa este metodo o hace uno propio
        
        public void verPuestos()
        {
            foreach (string l in File.ReadLines("..\\..\\utils\\lugaresParcheggio.txt"))
            {
                string[] vec = l.Split('|');

                try
                {
                    if (Convert.ToInt32(vec[2]) == 1)
                    {
                        cbPuestoDisponibles.Items.Add(vec[1]);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("e:" + ex);
                }
            }
        }
        

        //ir eliminar
        private void button1_Click_1(object sender, EventArgs e)
        {
            EliminarPuesto eliminarPuesto = new EliminarPuesto(user);
            this.Hide();
            eliminarPuesto.Show();
        }

        
        //ir editar
        private void button4_Click(object sender, EventArgs e)
        {
            EditarPuesto editarPuesto = new EditarPuesto(user);
            this.Hide();
            editarPuesto.Show();
        }

        //ir añadir
        private void button2_Click(object sender, EventArgs e)
        {
            CrearPuesto cP = new CrearPuesto(user);
            this.Hide();
            cP.Show();
        }



        //chimbadas innecesarias o que no vamos a usar

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
