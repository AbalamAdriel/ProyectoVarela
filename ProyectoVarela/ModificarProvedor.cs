using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class ModificarProvedor : Form
    {
        public ModificarProvedor()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_idprovedor.Text))
                {
                    MessageBox.Show("INTRODUCE ID.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "SELECT NOMBRE,CELULAR,DIRECCION,EMPRESA FROM PROVEDORES WHERE IDPROVEDORES = @ID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@ID", txt_idprovedor.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtDireccion.Text = reader["NOMBRE"].ToString();
                        textBox1.Text = reader["CELULAR"].ToString();
                        textBox2.Text = reader["DIRECCION"].ToString();
                        textBox3.Text = reader["EMPRESA"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            {

                {
                    if (string.IsNullOrEmpty(txt_nombre.Text)
                        && string.IsNullOrEmpty(txt_celular.Text)
                        && string.IsNullOrEmpty(txt_direccion.Text)
                        && string.IsNullOrEmpty(txt_empresa.Text))
                    {
                        MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_nombre.Text))
                    {
                        txt_nombre.Text = txtDireccion.Text;
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_celular.Text))
                    {
                        txt_celular.Text = textBox1.Text;
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_direccion.Text))
                    {
                        txt_direccion.Text = textBox2.Text;
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_empresa.Text))
                    {
                        txt_empresa.Text = textBox3.Text;
                        return;
                    }
                    

                    using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                    {
                        cn.Open();
                        string query = "UPDATE PROVEDORES SET NOMBRE = @nombre,DIRECCION = @direccion,CELULAR=@celular,EMPRESA=@empresa WHERE IDPROVEDORES = @id";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@id", txt_idprovedor.Text);
                        cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                        cmd.Parameters.AddWithValue("@celular", txt_celular.Text);
                        cmd.Parameters.AddWithValue("@direccion", txt_direccion.Text);
                        cmd.Parameters.AddWithValue("@empresa", txt_empresa.Text);
                        int filasActualizadas = cmd.ExecuteNonQuery();
                        if (filasActualizadas > 0)
                        {
                            MessageBox.Show("SE ACTUALIZÓ CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            

                            lbl_nombre.Text = string.Empty;
                            lbl_direccion.Text = string.Empty;
                            lbl_empresa.Text = string.Empty;
                            lbl_celular.Text = string.Empty;
                            txt_idprovedor.Text = string.Empty;
                            txt_nombre.Text = string.Empty;
                            txt_direccion.Text = string.Empty;
                            txt_empresa.Text = string.Empty;
                            txt_celular.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("NO EXISTE CLIENTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_idprovedor.Text))
                {
                    MessageBox.Show("INTRODUZCA CÓDIGO DEL PROVEDOR.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string verificarEmpleadoQuery = "SELECT COUNT(*) FROM PROVEDORES WHERE IDPROVEDORES = @id";
                    SqlCommand verificarEmpleadoCmd = new SqlCommand(verificarEmpleadoQuery, cn);
                    verificarEmpleadoCmd.Parameters.AddWithValue("@id", txt_idprovedor.Text);
                    int EmpleadoExistente = (int)verificarEmpleadoCmd.ExecuteScalar();

                    if (EmpleadoExistente > 0)
                    {
                        string query = "DELETE FROM PROVEDORES WHERE IDPROVEDORES = @id";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@id", txt_idprovedor.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("PROVEEDOR ELIMINADO CORRECTAMENTE.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                       
                        lbl_nombre.Text = string.Empty;
                        lbl_direccion.Text = string.Empty;
                        lbl_empresa.Text = string.Empty;
                        lbl_celular.Text = string.Empty;
                        txt_idprovedor.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        txt_direccion.Text = string.Empty;
                        txt_empresa.Text = string.Empty;
                        txt_celular.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRÓ CLIENTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
