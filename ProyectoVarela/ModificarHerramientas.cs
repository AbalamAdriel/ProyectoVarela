using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class ModificarHerramientas : Form
    {
        public ModificarHerramientas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idherramienta.Text))
            {
                MessageBox.Show("INTRODUCE ID.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                cn.Open();
                string query = "SELECT NOMBRE,TIPOHERRAMIENTAS,EXISTENCIAH FROM HERRAMIENTAS WHERE IDHERRAMIENTAS = @ID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@ID", txt_idherramienta.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader["NOMBRE"].ToString();
                    txtHerramienta.Text = reader["TIPOHERRAMIENTAS"].ToString();
                    txtExistencia.Text = reader["EXISTENCIAH"].ToString();
                }
                else
                {
                    MessageBox.Show("NO EXISTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btm_modificar_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrEmpty(txt_nombre.Text)
                    && string.IsNullOrEmpty(txt_tipo.Text)
                    && string.IsNullOrEmpty(txt_existencia.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_nombre.Text))
                {
                    txt_nombre.Text = txtNombre.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_tipo.Text))
                {
                    txt_tipo.Text = txtHerramienta.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_existencia.Text))
                {
                    txt_existencia.Text = txtExistencia.Text;
                    return;
                }
               

                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "UPDATE HERRAMIENTAS SET NOMBRE = @nombre,TIPOHERRAMIENTAS = @tipo,EXISTENCIAH = @existencia WHERE IDHERRAMIENTAS = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", txt_idherramienta.Text);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@tipo", txt_tipo.Text);
                    cmd.Parameters.AddWithValue("@existencia", txt_existencia.Text);
                    int filasActualizadas = cmd.ExecuteNonQuery();

                    if (filasActualizadas > 0)
                    {
                        MessageBox.Show("SE ACTUALIZÓ CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                       

                        txtNombre.Text = string.Empty;
                        txtHerramienta.Text = string.Empty;
                        txtExistencia.Text = string.Empty;
                        txt_idherramienta.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        txt_tipo.Text = string.Empty;
                        txt_existencia.Text = string.Empty;
                       
                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE CLIENTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_idherramienta.Text))
                {
                    MessageBox.Show("INTRODUZCA CÓDIGO DEL USUARIO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string verificarEmpleadoQuery = "SELECT COUNT(*) FROM HERRAMIENTAS WHERE IDHERRAMIENTAS = @id";
                    SqlCommand verificarEmpleadoCmd = new SqlCommand(verificarEmpleadoQuery, cn);
                    verificarEmpleadoCmd.Parameters.AddWithValue("@id", txt_idherramienta.Text);
                    int EmpleadoExistente = (int)verificarEmpleadoCmd.ExecuteScalar();

                    if (EmpleadoExistente > 0)
                    {
                        string query = "DELETE FROM HERRAMIENTAS WHERE IDHERRAMIENTAS = @id";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@id", txt_idherramienta.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("HERRAMIENTA ELIMINADO CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                       
                        txtNombre.Text = string.Empty;
                        txtHerramienta.Text = string.Empty;
                        txtExistencia.Text = string.Empty;
                        txt_idherramienta.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        txt_tipo.Text = string.Empty;
                        txt_existencia.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRÓ HERRAMIENTA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void ModificarHerramientas_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}

