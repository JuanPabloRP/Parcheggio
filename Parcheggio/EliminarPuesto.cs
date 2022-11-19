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
    public partial class EliminarPuesto : Form
    {

        List<Lugar> lugares = Lugar.lugares;

        LugaresDispo Ld;
        Usuario user;


        public EliminarPuesto(Usuario _user)
        {
            InitializeComponent();
            user = _user;

            leerArc();
        }

        private void pictureback_Click(object sender, EventArgs e)
        {
            Ld = new LugaresDispo(user);
            Ld.Show();
            this.Hide();
        }

        private void txteliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool eliminado = false;
            foreach (Lugar place in lugares)
            {
                if (txteliminar.Text.Equals(place.puesto) && (place.disponible == 1))
                {
                    eliminado = true;
                    lugares.Remove(place);
                    MessageBox.Show("El puesto ha sido eliminado correctamente");
                    txteliminar.Clear();
                    llenarArc();
                    break;
                }
            }

            
            if (eliminado == false)
            {
                MessageBox.Show("El puesto no se pudo eliminar (posiblemente no existe)");
            }


        }
        public void llenarArc()
        {

            StreamWriter sw = new StreamWriter("..\\..\\utils\\lugaresParcheggio.txt");

            foreach (Lugar l in lugares)
            {
                if (txteliminar.Text == l.puesto)
                {
                    l.disponible = 0;
                    sw.WriteLine($"{l.id}|{l.puesto}|{l.disponible}");
                }
                else
                {
                    sw.WriteLine($"{l.id}|{l.puesto}|{l.disponible}");
                }


            }
            sw.Close();

        }

        //pa leer los datos del archivo plano
        public void leerArc()
        {
            StreamReader sr = new StreamReader("..\\..\\utils\\lugaresParcheggio.txt");
            string linea;
            linea = sr.ReadLine();
            bool puestoRepetido = false;
            while (linea != null)
            {
                string[] vec = linea.Split('|');
                try
                {
                    foreach (Lugar l in lugares)
                    {
                        if (l.puesto == vec[1])
                        {
                            puestoRepetido = true;
                        }
                    }

                    if (puestoRepetido == false)
                    {
                        lugares.Add(new Lugar(Convert.ToInt32(vec[0]), vec[1], Convert.ToInt32(vec[2])));
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }

                linea = sr.ReadLine();
            }
            sr.Close();
        }
    }
 }

