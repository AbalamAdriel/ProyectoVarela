using ProyectoVarela.Utilerias;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class ConsultarMaterial : Form
    {
        public ConsultarMaterial()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "SELECT * FROM MATERIAL";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            RegistroMaterial material = new RegistroMaterial();
            material.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            V material = new V();
            material.ShowDialog(this);
        }
    }
}
