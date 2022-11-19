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
    public partial class CobroTiempo : Form
    {
        PagPrincipal Pp;
        Usuario user;
        
        List<Cliente> clientes = Cliente.clientes;
        List<Lugar> lugares = Lugar.lugares;


        public CobroTiempo(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            btnVerTodos.Hide();

            leerArcClientes();

            leerArcPuestos();

            llenarCombobox();
            
        }


        



        //Clientes
        
        //Pasar los datos de los clientes (vehiculos) de un archivo plano a una lista
        public void leerArcClientes()
        {
            StreamReader sr = new StreamReader("..\\..\\utils\\clientesParcheggio.txt");
            string linea;
            linea = sr.ReadLine();
            bool clienteRepetido = false;
            while (linea != null)
            {
                string[] vec = linea.Split('|');
                try
                {
                    foreach (Cliente c in clientes)
                    {
                        if (c.placa == vec[3])
                        {
                            clienteRepetido = true;
                        }
                    }

                    if (clienteRepetido == false)
                    {
                        clientes.Add(new Cliente(Convert.ToInt32(vec[0]), vec[1], vec[2], vec[3], vec[4], Convert.ToDateTime(vec[5])));
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

        //Pasar los datos de los clientes (vehiculos) de una lista al archivo plano
        public void llenandoArcClientes()
        {

            StreamWriter PL = new StreamWriter("..\\..\\utils\\clientesParcheggio.txt");

            foreach (Cliente a in clientes)
            {
                if (a.placa == cbVehiculos.Text.Trim())
                {
                    PL.WriteLine($"");
                }
                else{
                    PL.WriteLine($"{a.id}|{a.tipo}|{a.puesto}|{a.placa}|{a.color}|{a.fechaEntrada}");
                }
            }
            PL.Close();

        }



        //Lugares

        //Pasar los datos de los puestos del archivo plano a la lista
        public void leerArcPuestos()
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

        //Pasar los datos de los puestos de la lista a un archivo plano
        public void llenarArcPuestos()
        {

            StreamWriter sw = new StreamWriter("..\\..\\utils\\lugaresParcheggio.txt");

            foreach (Lugar l in lugares)
            {
                if (cbVehiculos.Text == l.puesto)
                {
                    l.disponible = 1;
                    sw.WriteLine($"{l.id}|{l.puesto}|{l.disponible}");
                }
                else
                {
                    sw.WriteLine($"{l.id}|{l.puesto}|{l.disponible}");
                }
            }
            sw.Close();
        }

        public void llenarCombobox()
        {
            foreach (Cliente c in clientes)
            {
                try { 
                    cbVehiculos.Items.Add(c.placa);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("e:" + ex);
                }
            }
        }

        

        public void sobreescribirArcCliente(string placa)
        {
            StreamReader sr = new StreamReader("..\\..\\utils\\clientesParcheggio.txt");
            string linea;
            linea = sr.ReadLine();
            bool clienteRepetido = false;
            while (linea != null)
            {
                string[] vec = linea.Split('|');
                try
                {
                    foreach (Cliente c in clientes)
                    {
                        if (c.placa == vec[3])
                        {
                            clienteRepetido = true;
                        }

                        if (c.placa == placa)
                        {
                            clientes.Remove(c);
                        }
                    }
                    

                    if (clienteRepetido == false && vec[3] != placa)
                    {
                        clientes.Add(new Cliente(Convert.ToInt32(vec[0]), vec[1], vec[2], vec[3], vec[4], Convert.ToDateTime(vec[5])));
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pp = new PagPrincipal(user);
            this.Hide();
            Pp.Show();
        }


        private void btnCobrar_Click(object sender, EventArgs e)
        {

            DateTime fechaSalida = DateTime.Now;
            double valorAPagar;
            bool existeCliente  = false;

            //MessageBox.Show("a");
            if (cbVehiculos.Text.Trim() != "")
            {
                //MessageBox.Show("b");
                if (clientes.Count == 0)
                {
                    //MessageBox.Show("xd");
                }
                else
                {
                    foreach (Cliente c in clientes)
                    {
                        //MessageBox.Show("c");
                        if (cbVehiculos.Text.Trim() == c.placa)
                        {
                            //MessageBox.Show("d");
                            foreach (Lugar l in lugares)
                            {
                                //MessageBox.Show("e");
                                if (l.puesto == c.puesto)
                                {
                                    //MessageBox.Show("f");
                                    l.disponible = 1;
                                    break;
                                }
                            }
                            //MessageBox.Show("g");
                            existeCliente = true;
                            valorAPagar = c.CalcularTotalAPagar(fechaSalida);
                            MessageBox.Show($"Valor: {valorAPagar} pesos");

                            
                            

                            
                            llenandoArcClientes();

                            llenarArcPuestos();

                            sobreescribirArcCliente(cbVehiculos.Text);

                            cbVehiculos.Items.Remove(cbVehiculos.Text);
                            cbVehiculos.SelectedIndex = -1;
                            break;
                        }
                        
                    }

                    if (existeCliente == false)
                    {
                        MessageBox.Show($"No existe vehiculo con la placa {cbVehiculos.Text}. :(");
                    }

                }
                
                //MessageBox.Show("h");
            }
            else
            {
                MessageBox.Show("Campo vacio, por ingrese la placa del vehiculo :(");
            }
            //MessageBox.Show("i");
        }


        private void CobroTiempo_Load(object sender, EventArgs e)
        {


        }
    }
}
