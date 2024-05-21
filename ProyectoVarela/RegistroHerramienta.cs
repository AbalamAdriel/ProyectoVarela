using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{

    public partial class RegistroHerramienta : Form
    {
        public RegistroHerramienta()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            {

                if (string.IsNullOrEmpty(txt_nombre.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if(string.IsNullOrEmpty(txt_tipo.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if(string.IsNullOrEmpty(txt_existencia.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "INSERT INTO HERRAMIENTAS (IDHERRAMIENTAS,NOMBRE,TIPOHERRAMIENTAS,EXISTENCIAH,ID_USER) VALUES (@IDHERRAMIENTAS,@NOMBRE,@TIPOHERRAMIENTAS,@EXISTENCIA,@ID_USER)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@IDHERRAMIENTAS", txt_idherramienta.Text);
                    cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@TIPOHERRAMIENTAS", txt_tipo.Text);
                    cmd.Parameters.AddWithValue("@EXISTENCIA", txt_existencia.Text);
                    cmd.Parameters.AddWithValue("@ID_USER", UserSession.UserId);

                    int fila = cmd.ExecuteNonQuery();
                    if (fila > 0)
                    {
                        MessageBox.Show("REGISTRO COMPLETADO.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        
                        txt_idherramienta.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        txt_tipo.Text = string.Empty;
                        txt_existencia.Text = string.Empty;

                    }
                }

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistroHerramienta_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }
    }
}
