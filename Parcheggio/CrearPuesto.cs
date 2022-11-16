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

            foreach (Usuario u in usuarios)
            {
                sw.WriteLine($"{u.id}|{u.name}|{u.username}|{u.password}|{u.confirmPassword}");
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
                    usuarios.Add(new Usuario(Convert.ToInt32(vec[0]), vec[1], vec[2], vec[3], vec[4]));
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
