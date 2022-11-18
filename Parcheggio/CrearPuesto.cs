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
using System.Xml.Linq;

namespace Parcheggio
{
    public partial class CrearPuesto : Form
    {
        List<Lugar> lugares = Lugar.lugares;

        LugaresDispo lD;
        Usuario user;


        public CrearPuesto(Usuario _user)
        {
            InitializeComponent();
            leerArc();
        }




        //metodos propios

        //pa llenar el archivo plano con los datos del usuario
        public void llenarArc()
        {

            StreamWriter sw = new StreamWriter("..\\..\\utils\\lugaresParcheggio.txt");

            foreach (Lugar l in lugares)
            {
                sw.WriteLine($"{l.id}|{l.puesto}|{l.disponible}");
            }
            sw.Close();

        }

        public void leerArc()
        {
            StreamReader sr = new StreamReader("..\\..\\utils\\lugaresParcheggio.txt");
            string linea;
            linea = sr.ReadLine();

            while (linea != null)
            {
                string[] vec = linea.Split('|');
                try
                {
                    lugares.Add(new Lugar(Convert.ToInt32(vec[0]), vec[1], Convert.ToBoolean(vec[2])));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }

                linea = sr.ReadLine();
            }
            sr.Close();
        }




        private void btnCrearPuesto_Click(object sender, EventArgs e)
        {

            Random n = new Random();
            int id = 0;
            bool idRepetido = false;
            bool lugarRepetido = false;

            if (txtPuesto.Text.Trim() != "")
            {
                do
                {
                    id = n.Next(1000000, 9999999);

                    if (lugares.Count > 0)
                    {
                        foreach (Lugar l in lugares)
                        {

                            if (id == l.id)
                            {
                                idRepetido = true;
                                break;
                            }


                        }
                    }

                } while (idRepetido == true);


                foreach (Lugar l in lugares)
                {
                    if (txtPuesto.Text.Equals(l.puesto))
                    {
                        lugarRepetido = true;
                        MessageBox.Show("Por favor ingrese otro puesto, el ingresado ya existe");
                        txtPuesto.Clear();
                        break;
                    }
                }



                if (lugarRepetido == false)
                {
                    lugares.Add(new Lugar(id, txtPuesto.Text.Trim(), true));
                    llenarArc();
                    MessageBox.Show("Puesto añadido :)");
                    txtPuesto.Clear();
                    
                }

            }
            else
            {
                MessageBox.Show("Los campos estan vacios :(");
            }

        }

        private void pictureback_Click(object sender, EventArgs e)
        {
            lD = new LugaresDispo(user);
            lD.Show();
            this.Hide();
        }
    }
}
