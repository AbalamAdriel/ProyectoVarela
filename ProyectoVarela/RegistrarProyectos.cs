using ProyectoVarela.Utilerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoVarela
{
    public partial class RegistrarProyectos : Form
    {
        public RegistrarProyectos()
        {
            InitializeComponent();
        }


        private void RegistrarMateriales()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {

                try
                {
                    conexion.Open();

                    foreach (ListViewItem item in listViewMateriales.Items)
                    {

                        string id_material = item.SubItems[0].Text;
                        string nombreM = item.SubItems[1].Text;
                        int cantidadM = Convert.ToInt32(item.SubItems[2].Text);

                        string consulta = "INSERT INTO MATERIALES_PROYECTOS (Id_Material, NombreMaterial, Cantidad_Necesaria, Id_Proyecto) " +
                                    "VALUES(@Id_Material, @NombreMaterial, @Cantidad_Necesaria, @Id_Proyecto);";
                         
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id_Material", id_material);
                            comando.Parameters.AddWithValue("@NombreMaterial", nombreM);
                            comando.Parameters.AddWithValue("@Cantidad_Necesaria", cantidadM);
                            comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos agregados a la base de datos correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }

        private void RegistrarHerramientas()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {

                try
                {
                    conexion.Open();

                    foreach (ListViewItem item in listViewHerramientas.Items)
                    {

                        string id_herramienta = item.SubItems[0].Text;
                        string nomHerramienta = item.SubItems[1].Text;
                        int cantidadH = Convert.ToInt32(item.SubItems[2].Text);

                        string consulta = "INSERT INTO HERRAMIENTAS_PROYECTOS (Id_Herramienta, Nombre, Cantidad_Necesaria, Id_Proyecto) " +
                                    "VALUES(@Id_Herramienta, @NomHerramienta, @Cantidad_Necesaria, @Id_Proyecto);";

                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id_Herramienta", id_herramienta);
                            comando.Parameters.AddWithValue("@NomHerramienta", nomHerramienta);
                            comando.Parameters.AddWithValue("@Cantidad_Necesaria", cantidadH);
                            comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                            comando.ExecuteNonQuery();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }

        private void RegistrarProyecto()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {

                try
                {
                    conexion.Open();

                        string consulta = "INSERT INTO PROYECTO (Id_Proyecto, NomCliente, Nombre_Proyecto, FechaInicio, FechaTerminacion) " +
                                    "VALUES(@IdProyecto, @NombCliente, @Nombre_Proyecto, @FechaInicio, @FechaTerminacion);";

                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@IdProyecto", txtId_Proyecto.Text);
                            comando.Parameters.AddWithValue("@NombCliente", txtNombreCliente.Text);
                            comando.Parameters.AddWithValue("@Nombre_Proyecto", txtNombreProyecto.Text);
                            comando.Parameters.AddWithValue("@FechaInicio", FechaInicio.Value);
                            comando.Parameters.AddWithValue("@FechaTerminacion", FechaTerminacion.Value);

                        comando.ExecuteNonQuery();
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }


        public void ActualizarExistencia()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {

                try
                {
                    conexion.Open();

                    string consulta = "UPDATE MATERIAL SET EXISTENCIA = GREATEST(0, EXISTENCIA - ISNULL(\r\n    (SELECT SUM(mp.Cantidad_Necesaria)\r\n    FROM MATERIALES_PROYECTOS mp\r\n    WHERE mp.Id_Material = MATERIAL.IDMATERIAL\r\n    AND mp.Id_Proyecto = @IdProyecto GROUP BY Id_Material), 0))\r\nWHERE EXISTS (\r\n    SELECT 1\r\n    FROM MATERIALES_PROYECTOS mp2\r\n    WHERE mp2.Id_Material = MATERIAL.IDMATERIAL\r\n    AND mp2.Id_Proyecto = @IdProyecto\r\n);";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdProyecto", txtId_Proyecto.Text);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }

        public bool verificarExistencia()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                
                    conexion.Open();

                    string consulta = "SELECT COUNT(*) FROM MATERIAL WHERE EXISTENCIA = 0;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        int countExistenciaCero = (int)comando.ExecuteScalar();

                        if (countExistenciaCero > 0)
                        {
                            MessageBox.Show("No se puede crear el proyecto. Existencia de materiales es 0.");
                            return false;
                        }
                    }
                
            }
            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (verificarExistencia())
            {
                RegistrarProyecto();
                RegistrarMateriales();
                RegistrarHerramientas();
                ActualizarExistencia();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }



        public void CargarComboBoxMateriales()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                conexion.Open();

                string consulta = "SELECT IDMATERIAL, MATERIAL FROM MATERIAL;";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idMaterial = reader["MATERIAL"].ToString();

                            cbMateriales.Items.Add(idMaterial);
                        }
                    }
                }
            }
        }

        public void CargarComboBoxHerramientas()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                conexion.Open();

                string consulta = "SELECT IDHERRAMIENTAS, NOMBRE FROM HERRAMIENTAS;";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idHerramienta = reader["NOMBRE"].ToString();

                            cbHerramientas.Items.Add(idHerramienta);
                        }
                    }
                }
            }
        }

        private void RegistrarProyectos_Load(object sender, EventArgs e)
        {
            CargarComboBoxMateriales();
            CargarComboBoxHerramientas();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAnadirMateriales_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbMateriales.Text) || string.IsNullOrEmpty(txtCantidadM.Text))
            {
                return;
            }

            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT IDMATERIAL, MATERIAL FROM MATERIAL WHERE MATERIAL = @NomMaterial;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NomMaterial", cbMateriales.Text);

                        SqlDataReader reader = comando.ExecuteReader();
                        reader.Read();

                                ListViewItem item = new ListViewItem(reader["IDMATERIAL"].ToString());
                                item.SubItems.Add(reader["MATERIAL"].ToString());
                                item.SubItems.Add(txtCantidadM.Text);


                                listViewMateriales.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }

        private void btnAnadirHerramienta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbHerramientas.Text) || string.IsNullOrEmpty(txtCantidadH.Text))
            {
                return;
            }

            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT IDHERRAMIENTAS, NOMBRE FROM HERRAMIENTAS WHERE NOMBRE = @NomHerramienta;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NomHerramienta", cbHerramientas.Text);

                        SqlDataReader reader = comando.ExecuteReader();
                        reader.Read();

                        ListViewItem item = new ListViewItem(reader["IDHERRAMIENTAS"].ToString());
                        item.SubItems.Add(reader["NOMBRE"].ToString());
                        item.SubItems.Add(txtCantidadH.Text);


                        listViewHerramientas.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un problema: {ex.Message}");
                }
            }
        }

        private void listViewMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
