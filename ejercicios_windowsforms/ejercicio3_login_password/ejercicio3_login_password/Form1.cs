using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3_login_password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = "";
            String password = "";
            bool comprobar_login;
            bool comprobar_espacios;

            login = textBox1.Text;
            password = textBox2.Text;

            comprobar_login = login.EndsWith("@gmail.com");
            comprobar_espacios = login.Contains(" ");

            if(comprobar_login == false)
            {
                MessageBox.Show("El formato del correo no es valido.");
            }
            else if(comprobar_espacios == true)
            {
                MessageBox.Show("El correo no puede tener espacios.");
            }
            else if(password.Length < 8)
            {
                MessageBox.Show("La contraseña debe contener minimo 8 caracteres.");
            }
            else{
                MessageBox.Show("Bienvenido, el inicio de sesion se ha completado correctamente.");
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
