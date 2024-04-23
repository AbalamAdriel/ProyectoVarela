using ProyectoVarela.Utilerias;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(NumControl_Tbx.Text) ||
                string.IsNullOrEmpty(Contraseña_Tbx.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlHelper.userName = NumControl_Tbx.Text;
                SqlHelper.password = Contraseña_Tbx.Text;

                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    try
                    {
                        cn.Open();

                        string usuarioQuery = "SELECT COUNT(USUARIO) FROM Usuarios WHERE USUARIO = @usuario";
                        SqlCommand usuarioCmd = new SqlCommand(usuarioQuery, cn);
                        usuarioCmd.Parameters.AddWithValue("@usuario", NumControl_Tbx.Text);
                        int numControlCount = (int)usuarioCmd.ExecuteScalar();

                        // Verificar la contraseña
                        string contraseñaQuery = "SELECT COUNT(USUARIO) FROM Usuarios WHERE USUARIO = @usuario AND CONTRASENA = @contrasena";
                        SqlCommand contraseñaCmd = new SqlCommand(contraseñaQuery, cn);
                        contraseñaCmd.Parameters.AddWithValue("@usuario", NumControl_Tbx.Text);
                        contraseñaCmd.Parameters.AddWithValue("@contrasena", Contraseña_Tbx.Text);
                        int contraseñaCount = (int)contraseñaCmd.ExecuteScalar();

                        if (numControlCount > 0 && contraseñaCount > 0)
                        {
                            this.Hide();
                            Form1 menu = new Form1();
                            menu.ShowDialog();

                        }
                        else if (numControlCount > 0 && contraseñaCount == 0)
                        {
                            MessageBox.Show("CONTRASEÑA INCORRECTA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("TIENES QUE REGISTRARTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto");
                    }
                }
            }

        }

        private void NumControl_Tbx_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }

}
