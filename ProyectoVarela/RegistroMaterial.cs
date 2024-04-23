using ProyectoVarela.Utilerias;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class RegistroMaterial : Form
    {      
        public RegistroMaterial()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_material.Text))
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                   if (string.IsNullOrEmpty(txt_tipo.Text))
                     {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    if(string.IsNullOrEmpty(txt_calibre.Text))
                     {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                     if(string.IsNullOrEmpty(txt_medida.Text))
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
                    string query = "INSERT INTO MATERIAL (IDMATERIAL,MATERIAL,TIPO,CALIBRE,MEDIDA,EXISTENCIA) VALUES (@IDMATERIAL,@MATERIAL,@TIPO,@CALIBRE,@MEDIDA,@EXISTENCIA)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@IDMATERIAL", txt_idmaterial.Text);
                    cmd.Parameters.AddWithValue("@MATERIAL", txt_material.Text);
                    cmd.Parameters.AddWithValue("@TIPO", txt_tipo.Text);
                    cmd.Parameters.AddWithValue("@CALIBRE", txt_calibre.Text);
                    cmd.Parameters.AddWithValue("@MEDIDA", txt_medida.Text);
                    cmd.Parameters.AddWithValue("@EXISTENCIA", txt_existencia.Text);

                    int fila = cmd.ExecuteNonQuery();
                    if (fila > 0)
                    {
                        MessageBox.Show("REGISTRO COMPLETADO.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        txt_idmaterial.Text = string.Empty;
                        txt_material.Text = string.Empty;
                        txt_tipo.Text = string.Empty;
                        txt_calibre.Text = string.Empty;
                        txt_medida.Text = string.Empty;
                        txt_existencia.Text = string.Empty;

                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegistroMaterial_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
