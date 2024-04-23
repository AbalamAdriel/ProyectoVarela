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
    public partial class ModificarProyecto : Form
    {
        public ModificarProyecto()
        {
            InitializeComponent();
        }

        private void DatosMateriales()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT Id_Material, NombreMaterial, Cantidad_Necesaria FROM " +
                                        "MATERIALES_PROYECTOS WHERE Id_Proyecto = @Id_Proyecto;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                        DataTable dataTable = new DataTable();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dataTable);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["Id_Material"].ToString());
                            item.SubItems.Add(row["NombreMaterial"].ToString());
                            item.SubItems.Add(row["Cantidad_Necesaria"].ToString());
                            listViewMateriales.Items.Add(item);
                        }

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void DatosHerramientas()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                try
                {
                    conexion.Open();

                    string consulta = " SELECT Id_Herramienta, NombreHerramientas, Cantidad_Necesaria " +
                        "FROM HERRAMIENTAS_PROYECTOS WHERE Id_Proyecto = @Id_Proyecto;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                        DataTable dataTable = new DataTable();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dataTable);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["Id_Herramienta"].ToString());
                            item.SubItems.Add(row["NombreHerramientas"].ToString());
                            item.SubItems.Add(row["Cantidad_Necesaria"].ToString());
                            listViewHerramientas.Items.Add(item);
                        }

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void DatosProyecto()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT Nombre_Proyecto, NomCliente FROM PROYECTO WHERE Id_Proyecto=@Id_Proyecto;";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("Id_Proyecto", txtId_Proyecto.Text);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombreProyecto = reader["Nombre_Proyecto"].ToString();
                                string nomCliente = reader["NomCliente"].ToString();

                                txtNombreProyecto.Text = nombreProyecto;
                                txtNombreCliente.Text = nomCliente;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosProyecto();
            DatosMateriales();
            DatosHerramientas();
            CargarComboBoxMateriales();
            CargarComboBoxHerramientas();
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

        private void ModificarProyecto_Load(object sender, EventArgs e)
        {

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

        private void EliminarDatosObsoletos()
        {
            using (SqlConnection conexion = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                    conexion.Open();

                        string consulta = "DELETE FROM MATERIALES_PROYECTOS WHERE Id_Proyecto = @Id_Proyecto;" +
                                "DELETE FROM HERRAMIENTAS_PROYECTOS WHERE Id_Proyecto = @Id_Proyecto;" +
                                "DELETE FROM PROYECTO WHERE Id_Proyecto = @Id_Proyecto;";

                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id_Proyecto", txtId_Proyecto.Text);

                            comando.ExecuteNonQuery();
                        }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RegistrarProyectos pro = new RegistrarProyectos();

            if (pro.verificarExistencia())
            {
                EliminarDatosObsoletos();
                RegistrarProyecto();
                RegistrarMateriales();
                RegistrarHerramientas();
                pro.ActualizarExistencia();
            }
           
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

                        string consulta = "INSERT INTO HERRAMIENTAS_PROYECTOS (Id_Herramienta, NombreHerramientas, Cantidad_Necesaria, Id_Proyecto) " +
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

                    string consulta = "INSERT INTO PROYECTO (Id_Proyecto, NomCliente, Nombre_Proyecto) " +
                                "VALUES(@IdProyecto, @NombCliente, @Nombre_Proyecto);";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdProyecto", txtId_Proyecto.Text);
                        comando.Parameters.AddWithValue("@NombCliente", txtNombreCliente.Text);
                        comando.Parameters.AddWithValue("@Nombre_Proyecto", txtNombreProyecto.Text);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos a la base de datos: {ex.Message}");
                }
            }
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            if (listViewMateriales.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewMateriales.SelectedItems)
                {
                    listViewMateriales.Items.Remove(item);
                    
                }
            }
        }

        private void btnEliminarH_Click(object sender, EventArgs e)
        {
            if (listViewHerramientas.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewHerramientas.SelectedItems)
                {
                    listViewHerramientas.Items.Remove(item);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
