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

namespace Parcheggio
{

    

    public partial class Registro : Form
    {

        List<Usuario> usuarios = new List<Usuario>();

        inicioDeSesion irInicarSesion;
        Primera primeraPagina;

        private int svg;

        public Registro()
        {
            InitializeComponent();
            int x1 = 0, x2;

            //un poco de matematicas, restando los anchos y dividiendo entre 2
            x1 = (this.Width / 2) - (label1.Width / 2);

            label1.Location = new System.Drawing.Point(x1, label1.Location.Y);

            x2 = (this.Width / 2) - (btnRegistrarse.Width / 2);
            btnRegistrarse.Location = new System.Drawing.Point(x2, btnRegistrarse.Location.Y);



        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void label6_Click(object sender, EventArgs e)
        {

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
    }
}
