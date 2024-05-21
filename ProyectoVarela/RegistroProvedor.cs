using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class RegistroProvedor : Form
    {
        public RegistroProvedor()
        {
            InitializeComponent();
        }

        private void RegistroProvedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrEmpty(txt_nombre.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if(string.IsNullOrEmpty(txt_celular.Text))
                     {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if(string.IsNullOrEmpty(txt_direccion.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if(string.IsNullOrEmpty(txt_empresa.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "INSERT INTO PROVEDORES (IDPROVEDORES,NOMBRE,CELULAR,DIRECCION,EMPRESA, ID_USER) VALUES (@IDPROVEDORES,@NOMBRE,@CELULAR,@DIRECCION,@EMPRESA,@ID_USER)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@IDPROVEDORES", txt_idprovedor.Text);
                    cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@CELULAR", txt_celular.Text);
                    cmd.Parameters.AddWithValue("@DIRECCION", txt_direccion.Text);
                    cmd.Parameters.AddWithValue("@EMPRESA", txt_empresa.Text);
                    cmd.Parameters.AddWithValue("@ID_USER", UserSession.UserId);

                    int fila = cmd.ExecuteNonQuery();
                    if (fila > 0)
                    {
                        MessageBox.Show("REGISTRO COMPLETADO.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                       
                        txt_idprovedor.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        txt_direccion.Text = string.Empty;
                        txt_empresa.Text = string.Empty;
                        txt_celular.Text = string.Empty;
                    }

                }
                

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
