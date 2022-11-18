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
    public partial class inicioDeSesion : Form
    {
        List<Usuario> usuarios = Usuario.usuarios;

        Usuario user;

        Primera back;
        Registro irRegis;
        PagPrincipal irpagPrincipal;
        RegisVehiculo regvehi; 
        public inicioDeSesion()
        {
            InitializeComponent();
            leerArc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            irRegis = new Registro();
            irRegis.Show();
            this.Hide();
        }

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
        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            bool ok = false;

            foreach (Usuario usua in usuarios)
            {
                if (txtusuario.Text.Trim() == usua.username)
                {
                    if (txtcontra.Text.Trim() == usua.password)
                    {
                        user = usua;
                        ok = true;
                        break;
                    }
                    else
                    {
                        ok = false;                       
                    }
                }
                else
                {
                    ok = false;
                }
            }
            if (ok)
            {
                irpagPrincipal = new PagPrincipal(user);
                irpagPrincipal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("El usuario o la contraseña estan incorrectas");
            }
        }

        private void pictureback_Click_1(object sender, EventArgs e)
        {
            back = new Primera();
            back.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}