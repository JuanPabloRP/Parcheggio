using Parcheggio.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcheggio
{
    public partial class RegisVehiculo : Form
    {
        List<Cliente> clientes = Cliente.clientes;
        List<Lugar> lugares = Lugar.lugares;

        PagPrincipal Pp;
        Usuario user;
        

        public RegisVehiculo(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            
            Archivo();

            leerArc();

            llenarCombobox();
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Pp = new PagPrincipal(user);
            this.Hide();
            Pp.Show();
        }


        //Clientes
        public void Archivo()
        {
            StreamReader pla = new StreamReader("..\\..\\utils\\clientesParcheggio.txt");
            string linea;
            linea = pla.ReadLine();

            while (linea != null)
            {
                string[] vec = linea.Split('|');
                try
                {
                    clientes.Add(new Cliente(Convert.ToInt32(vec[0]), vec[1], vec[2], vec[3], vec[4],Convert.ToDateTime(vec[5]) ));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }

                linea = pla.ReadLine();
            }
            pla.Close();
        }

        public void llenando()
        {

            StreamWriter PL = new StreamWriter("..\\..\\utils\\clientesParcheggio.txt");

            foreach (Cliente a in clientes)
            {
                PL.WriteLine($"{a.id}|{a.tipo}|{a.puesto}|{a.placa}|{a.color}|{a.fechaEntrada}");
            }
            PL.Close();

        }


        //Lugares
        //pa llenar el archivo plano 
        public void llenarArc()
        {

            StreamWriter sw = new StreamWriter("..\\..\\utils\\lugaresParcheggio.txt");

            foreach (Lugar l in lugares)
            {   
                if(cbPuestoVehi.Text == l.puesto)
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


        public void llenarCombobox()
        {
            
            foreach (Lugar l in lugares)
            {
                try
                {
                    if (Convert.ToInt32(l.disponible) == 1)
                    {
                        cbPuestoVehi.Items.Add(l.puesto);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("e:" + ex);
                }
                }
            
            
        }




        private void btnRogVeih_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int id = 0;
            bool idRepetido = false, placaRepetida = false;
            DateTime fechaEntrada;
            

            if (txtplaca.Text.Trim() != "" && txtcolor.Text.Trim() != "")
            {
                do
                {
                    id = n.Next(1000000, 9999999);

                    if (clientes.Count > 0)
                    {
                        foreach (Cliente u in clientes)
                        {

                            if (id == u.id)
                            {
                                idRepetido = true;
                                break;
                            }
                        }
                    }

                } while (idRepetido == true);

                foreach (Cliente c in clientes)
                {
                    if(txtplaca.Text == c.placa)
                    {
                        placaRepetida = true;
                        break;
                    }
                }


                if (placaRepetida == false)
                {
                    if(cbPuestoVehi.Text != "")
                    {
                        fechaEntrada = DateTime.Now;
                        clientes.Add(new Cliente(id, Cbtipo.Text, cbPuestoVehi.Text, txtplaca.Text, txtcolor.Text, fechaEntrada));

                        llenando();
                        llenarArc();

                        cbPuestoVehi.Items.Remove(cbPuestoVehi.Text);
                        cbPuestoVehi.SelectedIndex = -1;

                        MessageBox.Show("vehiculo registrado :)");
                        txtcolor.Clear();
                        txtplaca.Clear();
                    }
                    else
                    {
                        MessageBox.Show($"No hay lugares de estacionamiento disponibles :(");
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show($"El vehiculo con placa {txtplaca.Text} ya está estacionado :(");
                }
                
            }
            else
            {
                MessageBox.Show("Los campos estan vacios :(");
            }
        }




        private void RegisVehiculo_Load(object sender, EventArgs e)
        {
            
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cbPuestoVehi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




        /*
        public void cambiarEstadoPuesto()
        {
            string lineaLeida;
            foreach (string l in File.ReadLines("..\\..\\utils\\lugaresParcheggio.txt"))
            {
                string[] vec = l.Split('|');

                try
                {
                    if (Cbtipo.Text == vec[1])
                    {
                        lineaLeida = l;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("e:" + ex);
                }
            }


            StreamWriter sw = new StreamWriter("..\\..\\utils\\usuariosParcheggio.txt");


            foreach (string line in vec)
            {
                //vec[2] = "0";
                //sw.WriteLine($"{vec[0]}|{vec[1]}|{vec[2]}");
            }
            sw.Close();

        }
        */


    }
}