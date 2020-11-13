using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace conectar_bd_mediante_codigo
{
    public partial class Form1 : Form
    {
        static MySqlConnection Conex = new MySqlConnection();
        static string serv = "Server=localhost;";
        static string db = "Database=agenda;";
        static string usuario = "UID=root;";
        static string pwd = "Password= ;";
        string CadenaDeConexion = serv + db + usuario + pwd;
        string id_contac = null;
        string nom = null;
        string apellido = null;
        string telefo = null;
        string direccion = null;
        string cp = null;
        string poblacion = null;
        string query = null;



        public Form1()
        {
            InitializeComponent();
            actualizar_tabla();
            guardar_en_combobox();
        }
        
        public void Conectar()
        {
            try
            {
                Conex.ConnectionString = CadenaDeConexion;
                Conex.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD");
                throw;
            }
        }
        public static void Desconectar()
        {
            Conex.Close();
        }

        public void insertar_contactos(String query)
        {
            Conectar();
            MySqlCommand insertar = new MySqlCommand(query, Conex);
            insertar.ExecuteNonQuery();
            Desconectar();
            actualizar_tabla();
            guardar_en_combobox();
        }

        public void actualizar_tabla()
        {
            MySqlDataAdapter adaptador;
            DataTable table = new DataTable();
            Conectar();
            try
            {
                adaptador = new MySqlDataAdapter("Select id_contacto,nombre,apellidos from contactos",Conex);
                adaptador.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch(Exception e)
            {
                MessageBox.Show("No se ha actualizado la tabla.");
            }
            Desconectar();
        }

        public void guardar_en_combobox()
        {
            MySqlCommand adaptador;
            Conectar();
            try
            {
                adaptador = new MySqlCommand("Select cp from contactos", Conex);
                MySqlDataReader reader = adaptador.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    
                    comboBox1.Items.Add(Convert.ToString(reader["cp"]));
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha a guardado en el combobox.");
            }
            Desconectar();
        }

        public void consulta(string consulta)
        {
            MySqlDataAdapter adaptador;
            DataTable table = new DataTable();
            Conectar();
            try
            {
                adaptador = new MySqlDataAdapter("Select id_contacto,nombre,apellidos from contactos where(cp='" + consulta+ "')", Conex);
                adaptador.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha actualizado la tabla.");
            }
            Desconectar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id_contac = textBox1.Text;
            nom = textBox2.Text;
            apellido = textBox3.Text;
            telefo = textBox4.Text;
            direccion = textBox5.Text;
            cp = textBox6.Text;
            poblacion = textBox7.Text;

            query = "INSERT INTO contactos(id_contacto,nombre,apellidos,telefono,direccion,cp,poblacion) VALUES (" + id_contac+ " ,'"+nom+"','"+apellido+"','"+telefo+"','"+direccion+"','"+cp+"','"+poblacion+"')";
            insertar_contactos(query);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string consulta_cp = Convert.ToString(comboBox1.SelectedItem);
            consulta(consulta_cp);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
