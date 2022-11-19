using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parcheggio
{
    public partial class EditarPuesto : Form
    {
        LugaresDispo Ld;
        Usuario user;
        List<Lugar> lugares = Lugar.lugares;

        public EditarPuesto(Usuario _user)
        {
            InitializeComponent();
            user = _user;
            leerArc();
            llenarCombobox();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ld = new LugaresDispo(user);
            Ld.Show();
            this.Hide(); ;
        }


        //metodos propios

        //pa llenar el archivo plano 
        public void llenarArc()
        {

            StreamWriter sw = new StreamWriter("..\\..\\utils\\lugaresParcheggio.txt");

            foreach (Lugar l in lugares)
            {
                sw.WriteLine($"{l.id}|{l.puesto}|{l.disponible}");
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
            cbPuestoAEditar.Items.Clear();
            foreach (Lugar l in lugares)
            {
                try
                {
                   
                    if (Convert.ToInt32(l.disponible) == 1)
                    {
                        cbPuestoAEditar.Items.Add(l.puesto);
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("e:" + ex);
                }
            }
        }

        private void btnRegVeh_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int id = 0;
            bool idRepetido = false;
            bool lugarRepetido = false;

            if (txtPuestoNuevo.Text.Trim() != "" && cbPuestoAEditar.Text != "")
            {
                

                foreach (Lugar l in lugares)
                {
                    if (txtPuestoNuevo.Text.Equals(l.puesto))
                    {
                        lugarRepetido = true;
                        MessageBox.Show("Por favor ingrese otro puesto, el ingresado ya existe");
                        txtPuestoNuevo.Clear();
                        break;
                    }
                }



                if (lugarRepetido == false)
                {
                    foreach (Lugar l in lugares)
                    {
                        if (l.puesto.Equals(cbPuestoAEditar.Text))
                        {
                            l.puesto = txtPuestoNuevo.Text.Trim();
                        }
                    }

                    //lugares.Add(new Lugar(id, txtPuestoNuevo.Text.Trim(), 1));
                    llenarArc();
                    MessageBox.Show("Puesto editado :)");
                    txtPuestoNuevo.Clear();
                    cbPuestoAEditar.Items.Remove(cbPuestoAEditar.Text);
                    cbPuestoAEditar.SelectedIndex = -1;

                    llenarCombobox();
                }
                
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos :(");
            }
        }



        //innecesario 



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtplaca_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
