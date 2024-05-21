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
    public partial class FRMEliminarUsuario : Form
    {
        public FRMEliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            PlaceHolderNombre();

            if (UsuarioExiste(txtbox_usuario.Text))
            {
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string verificarEmpleadoQuery = "SELECT COUNT(*) FROM USUARIOS WHERE USUARIO = @id";
                    SqlCommand verificarEmpleadoCmd = new SqlCommand(verificarEmpleadoQuery, cn);
                    verificarEmpleadoCmd.Parameters.AddWithValue("@id", txtbox_usuario.Text);
                    int EmpleadoExistente = (int)verificarEmpleadoCmd.ExecuteScalar();

                    string queryContext = "INSERT INTO UsuarioContexto (SesionID) VALUES (@SesionID)";
                    SqlCommand cmdContext = new SqlCommand(queryContext, cn);
                    cmdContext.Parameters.AddWithValue("@SesionID", UserSession.UserId);
                    cmdContext.ExecuteNonQuery();

                    string query = "DELETE FROM USUARIOS WHERE USUARIO = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", txtbox_usuario.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("USUARIO ELIMINADO CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }
            txtbox_usuario.Text = "";
        }
        private void PlaceHolder()
        {
            if (string.IsNullOrEmpty(txtbox_usuario.Text))
            {
                txtbox_usuario.Text = "Nombre de usuario...";
                txtbox_usuario.ForeColor = Color.LightGray;
            }
        }

        private void PlaceHolderNombre()
        {
            if (txtbox_usuario.Text == "Nombre de usuario...")
            {
                txtbox_usuario.Text = string.Empty;
                txtbox_usuario.ForeColor = Color.Black;
            }
        }

        private void txtbox_usuario_Enter(object sender, EventArgs e)
        {
            PlaceHolderNombre();
        }

        private void txtbox_usuario_Click(object sender, EventArgs e)
        {
            PlaceHolderNombre();
        }

        private void txtbox_usuario_Leave(object sender, EventArgs e)
        {
            PlaceHolder();
        }

        public bool UsuarioExiste(string usuario)
        {
            using (SqlConnection conn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario", conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count > 0; // Verdadero si el usuario ya existe
            }
        }
    }
}
