using ProyectoVarela.Utilerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
            txtbox_contrasenia.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 0, 0, 0);

        }

        private void PlaceHolderNombre()
        {
            if (txtbox_usuario.Text == "Nombre de usuario...")
            {
                txtbox_usuario.Text = string.Empty;
                txtbox_usuario.ForeColor = Color.Black;
            }
        }

        private void PlaceHolderContrasena()
        {
            if (txtbox_contrasenia.Text == "Contraseña...")
            {
                txtbox_contrasenia.Text = string.Empty;
                txtbox_contrasenia.ForeColor = Color.Black;
                txtbox_contrasenia.UseSystemPasswordChar = false;
            }
        }
        private void PlaceHolder()
        {
            if (string.IsNullOrEmpty(txtbox_usuario.Text))
            {
                txtbox_usuario.Text = "Nombre de usuario...";
                txtbox_usuario.ForeColor = Color.LightGray;
            }
            if (string.IsNullOrEmpty(txtbox_contrasenia.Text))
            {
                txtbox_contrasenia.Text = "Contraseña...";
                txtbox_contrasenia.ForeColor = Color.LightGray;
                txtbox_contrasenia.UseSystemPasswordChar = true;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            PlaceHolderNombre();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            PlaceHolder();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            PlaceHolderNombre();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            PlaceHolder();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            PlaceHolderContrasena();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            PlaceHolderContrasena();
        }

        public bool UsuarioExiste(string usuario)
        {
            using (SqlConnection conn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario", conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Verdadero si el usuario ya existe
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PlaceHolderNombre();
            PlaceHolderContrasena();

            if (UsuarioExiste(txtbox_usuario.Text))
            {
                MessageBox.Show("El usuario ya existe");
            }
            else
            {
                if (string.IsNullOrEmpty(txtbox_usuario.Text) ||
                   string.IsNullOrEmpty(txtbox_contrasenia.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PlaceHolder();
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString()))
                    {
                        connection.Open();
                        string query = "INSERT INTO USUARIOS VALUES (@Usuario, @Contrasena)";

                        using (SqlCommand commando = new SqlCommand(query, connection))
                        {
                            commando.Parameters.AddWithValue("@Usuario", txtbox_usuario.Text);
                            commando.Parameters.AddWithValue("@Contrasena", txtbox_contrasenia.Text);

                            commando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("REGISTRO EXITOSO.", "", MessageBoxButtons.OK);
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR EN LA BASE DE DATOS.");
                }
            }


            txtbox_usuario.Text = "";
            txtbox_contrasenia.Text = "";

        }
    }
}
