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
    public partial class CrearPuesto : Form
    {
        List<Lugar> lugares = Lugar.lugares;

        public CrearPuesto()
        {
            InitializeComponent();
        }



        private void btnCrearPuesto_Click(object sender, EventArgs e)
        {

        }


        //metodos propios

        //pa llenar el archivo plano con los datos del usuario
        public void llenarArc()
        {

            StreamWriter sw = new StreamWriter("..\\..\\utils\\usuariosParcheggio.txt");

            foreach (Lugar l in lugares)
            {
                sw.WriteLine($"{l.id}");
            }
            sw.Close();

        }

        public void leerArc()
        {
            StreamReader sr = new StreamReader("..\\..\\utils\\usuariosParcheggio.txt");
            string linea;
            linea = sr.ReadLine();

            while (linea != null)
            {
                string[] vec = linea.Split('|');
                try
                {
                    lugares.Add(new Lugar(Convert.ToInt32(vec[0])));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }

                linea = sr.ReadLine();
            }
            sr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
