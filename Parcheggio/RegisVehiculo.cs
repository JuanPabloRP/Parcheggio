using Parcheggio.clases;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcheggio
{
    public partial class RegisVehiculo : Form
    {
        List<Cliente> cliente = Cliente.cliente;

        PagPrincipal Pp;
        Usuario user;
        public RegisVehiculo(Usuario user)
        {
            InitializeComponent();
            this.user = user;

            Archivo();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pp = new PagPrincipal(user);
            this.Hide();
            Pp.Show();
        }

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
                    cliente.Add(new Cliente(Convert.ToInt32(vec[0]), vec[1], vec[2], vec[3]));
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

            foreach (Cliente a in cliente)
            {
                PL.WriteLine($"{a.id}|{a.tipo}|{a.placa}|{a.color}");
            }
            PL.Close();

        }

        private void RegisVehiculo_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRogVeih_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int id = 0;
            bool idRepetido = false;



            if (txtplaca.Text.Trim() != "" && txtcolor.Text.Trim() != "")
            {
                do
                {
                    id = n.Next(1000000, 9999999);

                    if (cliente.Count > 0)
                    {
                        foreach (Cliente u in cliente)
                        {

                            if (id == u.id)
                            {
                                idRepetido = true;
                                break;
                            }
                        }
                    }

                } while (idRepetido == true);

                cliente.Add(new Cliente(id, Cbtipo.Text, txtplaca.Text, txtcolor.Text));
                llenando();
                MessageBox.Show("vehiculo registrado :)");
                txtcolor.Clear();
                txtplaca.Clear();
            }
            else
            {
                MessageBox.Show("Los campos estan vacios :(");
            }
        }
    }
}