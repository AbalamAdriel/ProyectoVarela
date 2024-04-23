using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class ModificarEmpleados : Form
    {
        public ModificarEmpleados()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idempleado.Text))
            {
                MessageBox.Show("INTRODUCE ID.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                cn.Open();
                string query = "SELECT NOMBRE,DIRECCION,CORREO,CELULAR,PUESTO FROM EMPLEADOS WHERE IDEMPLEADO = @ID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@ID", txt_idempleado.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader["NOMBRE"].ToString();
                    txtDireccion.Text = reader["DIRECCION"].ToString();
                    txtCorreo.Text = reader["CORREO"].ToString();
                    txtCelular.Text = reader["CELULAR"].ToString();
                    txtPuesto.Text = reader["PUESTO"].ToString();
                }
                else
                {
                    MessageBox.Show("NO EXISTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_nombre.Text)
                    && string.IsNullOrEmpty(txt_direccion.Text)
                    && string.IsNullOrEmpty(txt_correo.Text)
                    && string.IsNullOrEmpty(txt_celular.Text)
                    && string.IsNullOrEmpty(txt_puesto.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_nombre.Text))
                {
                    txt_nombre.Text = txtNombre.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_direccion.Text))
                {
                    txt_direccion.Text = txtDireccion.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_correo.Text))
                {
                    txt_correo.Text = txtCorreo.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_celular.Text))
                {
                    txt_celular.Text = txtCelular.Text;
                    return;
                }
                if (string.IsNullOrEmpty(txt_puesto.Text))
                {
                    txt_puesto.Text = txtPuesto.Text;
                    return;
                }

                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "UPDATE EMPLEADOS SET NOMBRE = @nombre,DIRECCION = @direccion,CORREO = @correo,CELULAR=@celular,PUESTO=@puesto WHERE IDEMPLEADO = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", txt_idempleado.Text);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@direccion", txt_direccion.Text);
                    cmd.Parameters.AddWithValue("@correo", txt_correo.Text);
                    cmd.Parameters.AddWithValue("@celular", txt_celular.Text);
                    cmd.Parameters.AddWithValue("@puesto", txt_puesto.Text);
                    int filasActualizadas = cmd.ExecuteNonQuery();
                    if (filasActualizadas > 0)
                    {
                        MessageBox.Show("SE ACTUALIZÓ CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                 

                        txtNombre.Text = string.Empty;
                        txtDireccion.Text = string.Empty;
                        txtCorreo.Text = string.Empty;
                        txtCelular.Text = string.Empty;
                        txtPuesto.Text = string.Empty;
                        txt_idempleado.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        txt_direccion.Text = string.Empty;
                        txt_correo.Text = string.Empty;
                        txt_celular.Text = string.Empty;
                        txt_puesto.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE CLIENTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_idempleado.Text))
                {
                    MessageBox.Show("INTRODUZCA CÓDIGO DEL USUARIO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string verificarEmpleadoQuery = "SELECT COUNT(*) FROM EMPLEADOS WHERE IDEMPLEADO = @id";
                    SqlCommand verificarEmpleadoCmd = new SqlCommand(verificarEmpleadoQuery, cn);
                    verificarEmpleadoCmd.Parameters.AddWithValue("@id", txt_idempleado.Text);
                    int EmpleadoExistente = (int)verificarEmpleadoCmd.ExecuteScalar();

                    if (EmpleadoExistente > 0)
                    {
                        string query = "DELETE FROM EMPLEADOS WHERE IDEMPLEADO = @id";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@id", txt_idempleado.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("EMPLEADO ELIMINADO CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    
                        txtNombre.Text = string.Empty;
                        txtDireccion.Text = string.Empty;
                        txtCorreo.Text = string.Empty;
                        txtCelular.Text = string.Empty;
                        txtPuesto.Text = string.Empty;
                        txt_idempleado.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        txt_direccion.Text = string.Empty;
                        txt_correo.Text = string.Empty;
                        txt_celular.Text = string.Empty;
                        txt_puesto.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRÓ CLIENTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_celular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
