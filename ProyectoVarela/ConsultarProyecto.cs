using ProyectoVarela.Utilerias;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class ConsultarProyecto : Form
    {
        public ConsultarProyecto()
        {
            InitializeComponent();
        }

        private void ConsultarProyecto_Load(object sender, EventArgs e)
        {
            
        }

        public void DatosMateriales()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                conexion.Open();

                string consulta = "SELECT Nombre_Proyecto, NomCliente,FechaInicio,FechaTerminacion, MP.Id_Material, MP.Cantidad_Necesaria, M.MATERIAL, M.TIPO, " +
                    "M.MEDIDA, M.CALIBRE, M.EXISTENCIA FROM PROYECTO P INNER JOIN MATERIALES_PROYECTOS MP ON P.Id_Proyecto = MP.Id_Proyecto " +
                    "INNER JOIN MATERIAL M ON MP.Id_Material = M.IDMATERIAL WHERE P.Id_Proyecto = @Id_Proyecto;";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridViewMateriales.DataSource = tabla;
                }
            }
        }

        public void DatosHerramientas()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                conexion.Open();

                string consulta = "SELECT Nombre_Proyecto, NomCliente,FechaInicio,FechaTerminacion, HP.Id_Herramienta, HP.Cantidad_Necesaria, H.NOMBRE, H.TIPOHERRAMIENTAS," +
                    "H.EXISTENCIAH FROM PROYECTO P INNER JOIN HERRAMIENTAS_PROYECTOS HP ON P.Id_Proyecto = HP.Id_Proyecto " +
                    "INNER JOIN HERRAMIENTAS H ON HP.Id_Herramienta = H.IDHERRAMIENTAS WHERE P.Id_Proyecto = @Id_Proyecto;";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridViewHerramientas.DataSource = tabla;
                }
            }
        }

        private void txtBuscarProyecto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId_Proyecto.Text))
            {
                MessageBox.Show("INTRODUCE ID.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Llamada a funciones o métodos después de validar que txtId_Proyecto no está vacío
                DatosMateriales();
                DatosHerramientas();
            }
        }

        private void dataGridViewMateriales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void dataGridViewMateriales_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           
        }

        private void dataGridViewMateriales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                DataGridViewRow row = dataGridViewMateriales.Rows[i];
                int existenciaValue = Convert.ToInt32(row.Cells["EXISTENCIA"].Value);
                int CantidadNecesariaValue = Convert.ToInt32(row.Cells["Cantidad_Necesaria"].Value);
                int identificador = 0;

                if (existenciaValue == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    identificador = 1;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = dataGridViewMateriales.DefaultCellStyle.BackColor;
                }

                if (CantidadNecesariaValue > existenciaValue && existenciaValue != 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (identificador == 0)
                {
                    row.DefaultCellStyle.BackColor = dataGridViewMateriales.DefaultCellStyle.BackColor;
                }
            }
        }

        private void dataGridViewHerramientas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                DataGridViewRow row = dataGridViewHerramientas.Rows[i];
                int existenciaValue = Convert.ToInt32(row.Cells["EXISTENCIAH"].Value);
                int CantidadNecesariaValue = Convert.ToInt32(row.Cells["Cantidad_Necesaria"].Value);
                int identificador = 0;

                if (existenciaValue == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    identificador = 1;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = dataGridViewHerramientas.DefaultCellStyle.BackColor;
                }

                if (CantidadNecesariaValue > existenciaValue && existenciaValue != 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if(identificador == 0)
                {
                    row.DefaultCellStyle.BackColor = dataGridViewHerramientas.DefaultCellStyle.BackColor;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ModificarProyecto proy = new ModificarProyecto();
            proy.ShowDialog(this);
        }

        private void btnRegistrarProyecto_Click(object sender, EventArgs e)
        {
            RegistrarProyectos proy = new RegistrarProyectos();
            proy.ShowDialog(this);
        }
    }
}
