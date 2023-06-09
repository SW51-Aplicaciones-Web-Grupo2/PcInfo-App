using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            button4.Visible=false;
            label2.Visible=false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Sconexion = new SqlConnection(Conexion.cadena);
            string query = "SELECT c.Nombre FROM Usuario u JOIN Cliente c ON c.DNI=u.IDuser WHERE u.Usuario='"+textBox1.Text+"' AND u.Password='"+textBox2.Text+"' ";
            SqlCommand cmd = new SqlCommand(query, Sconexion);
            Sconexion.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Pass
                        string nombre = reader.GetString(reader.GetOrdinal("Nombre"));

                        // Realiza la lógica que necesites con los valores obtenidos
                        // Por ejemplo, puedes imprimirlos en la consola
                        label1.Text = nombre;
                    }
                }
                else
                {
                    label1.Text = "No se encontro registro lo siento";
                }
            }

            Sconexion.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            button4.Visible = true;
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Cliente (Nombre, Apellidos,DNI) VALUES (@Nombre,@Apellidos,@DNI) INSERT INTO Usuario(IDuser,Usuario,Password) VALUES (@DNI,@Usuario,@Password)";

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", textBox3.Text);
                    command.Parameters.AddWithValue("@Apellidos", textBox4.Text);
                    command.Parameters.AddWithValue("@DNI", textBox5.Text);
                    command.Parameters.AddWithValue("@Usuario", textBox6.Text);
                    command.Parameters.AddWithValue("@Password", textBox7.Text);


                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    connection.Close();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Inserción exitosa");
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        label1.Visible = true;
                        label3.Visible = true;
                        button2.Visible = true;
                        button1.Visible = true;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        button4.Visible = false;
                        label2.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el registro");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Productos";

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
