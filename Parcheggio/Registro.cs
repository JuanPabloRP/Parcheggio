using Parcheggio.clases;
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

    

    public partial class Registro : Form
    {

        List<Usuario> usuarios = new List<Usuario>();

        inicioDeSesion irInicarSesion;
        Primera primeraPagina;

        

        public Registro()
        {
            InitializeComponent();

            //this.MaximumSize(this.Height, this.Width);
            


            //para centrar algunos componentes
            List<Control> components = new List<Control>();
            components.Add(label1);
            components.Add(btnRegistrarse);
            components.Add(label6);
            components.Add(linkLabel1);

            centrarComponent(components);
            
        }

        //metodos propios

        //pa llenar el archivo plano con los datos del usuario
        public void llenarArc()
        {
            

            StreamWriter sw = new StreamWriter("C:\\Users\\USUARIO\\source\\repos\\Parcheggio\\Parcheggio\\utils\\usuariosParcheggio.txt", append: true);

            foreach (Usuario u in usuarios)
            {
                sw.WriteLine($"{u.id}|{u.name}|{u.username}|{u.password}|{u.confirmPassword}" );
            }
            sw.Close();

        }

        //si el componente se quiere centrar, este metodo lo hace
        public void centrarComponent(List<Control> components)
        {

            int x = 0;

            foreach (Control component in components)
            {
                //un poco de matematicas, restando los anchos y dividiendo entre 2    
                x = (this.Width / 2) - (component.Width / 2);
                component.Location = new System.Drawing.Point(x, component.Location.Y);
            }
            
            
        }
        
        
        //metodos de windows form con alguna funcionalidad
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int id = 0;
            bool idRepetido = false;
            bool usernameRepetido = false;

            if (txtName.Text.Trim() != "" && txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtConfirmPassword.Text.Trim() != "" )
            {
                if (txtPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    do
                    {
                        id = n.Next(1000000, 9999999);

                        if (usuarios.Count > 0)
                        {
                            foreach (Usuario u in usuarios)
                            {

                                if (id == u.id)
                                {
                                    idRepetido = true;
                                    break;
                                }

                                
                            }   
                        }
                        
                    } while (idRepetido == true);


                    foreach (Usuario u in usuarios)
                    {
                        if (txtUsername.Text.Equals(u.username))
                        {
                            usernameRepetido = true;
                            MessageBox.Show("Por favor ingrese otro nombre de usuario");
                            txtUsername.Clear();
                            break;
                        }
                    }

                    

                    if (usernameRepetido == false)
                    {
                        usuarios.Add(new Usuario(id, txtName.Text, txtUsername.Text, txtPassword.Text, txtConfirmPassword.Text));
                        llenarArc();
                        MessageBox.Show("Usuario registrado :)");
                        txtName.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                    }
                    

                    
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Los campos estan vacios :(");
            }
            

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            irInicarSesion = new inicioDeSesion();
            this.Hide();
            irInicarSesion.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            primeraPagina = new Primera();
            this.Hide();
            primeraPagina.Show();

            
        }



        //metodos de windows form sin ninguna funcionalidad (NO se pueden borrar)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
