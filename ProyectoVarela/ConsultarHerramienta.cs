using ProyectoVarela.Utilerias;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class ConsultarHerramienta : Form
    {
        public ConsultarHerramienta()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
                {
                    cn.Open();
                    string query = "SELECT * FROM HERRAMIENTAS";
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

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroHerramienta herramienta = new RegistroHerramienta();
            herramienta.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarHerramientas modificarHerramientas = new ModificarHerramientas();
            modificarHerramientas.ShowDialog(this);
        }
    }
}
