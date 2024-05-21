using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            {
                if
                    (string.IsNullOrEmpty(txt_idempleado.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if( string.IsNullOrEmpty(txt_nombre.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if( string.IsNullOrEmpty(txt_direccion.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if( string.IsNullOrEmpty(txt_correo.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if(string.IsNullOrEmpty(txt_celular.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if( string.IsNullOrEmpty(txt_puesto.Text)) 

                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "INSERT INTO EMPLEADOS (IDEMPLEADO,NOMBRE,DIRECCION,CORREO,CELULAR,PUESTO,ID_USER) VALUES (@IDEMPLEADO,@NOMBRE,@DIRECCION,@CORREO,@CELULAR,@PUESTO,@ID_USER)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@IDEMPLEADO", txt_idempleado.Text);
                    cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@DIRECCION", txt_direccion.Text);
                    cmd.Parameters.AddWithValue("@CORREO", txt_correo.Text);
                    cmd.Parameters.AddWithValue("@CELULAR", txt_celular.Text);
                    cmd.Parameters.AddWithValue("@PUESTO", txt_puesto.Text);
                    cmd.Parameters.AddWithValue("@ID_USER", UserSession.UserId);

                    int fila = cmd.ExecuteNonQuery();
                    if (fila > 0)
                    {
                        MessageBox.Show("REGISTRO COMPLETADO.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                     
                        txt_idempleado.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        txt_direccion.Text = string.Empty;
                        txt_correo.Text = string.Empty;
                        txt_celular.Text = string.Empty;
                        txt_puesto.Text = string.Empty;
                    }

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}


