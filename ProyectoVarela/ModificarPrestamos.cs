using ProyectoVarela.Entidades;
using ProyectoVarela.Utilerias;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class ModificarPrestamos : Form
    {
        private List<Prestamo> Prestamos
        {
            get;
            set;
        }

        private Prestamo PrestamoADevolver
        {
            get;
            set;
        }

        public ModificarPrestamos()
        {
            InitializeComponent();
            LlenarComboBoxEmpleados();
        }

        private void LlenarPrestamos()
        {
            Prestamos = new List<Prestamo>();

            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                cn.Open();

                string query = "SELECT P.IdPrestamo, P.IdHerramientas, P.IdEmpleado, P.FechaRegistro, " +
                    "P.FehaEntrega, P.Cantidad, H.Nombre AS NombreHerramienta, E.Nombre AS NombreEmpleado " +
                    "FROM Prestamos P INNER JOIN Herramientas H ON P.IdHerramientas = H.IDHERRAMIENTAS " +
                    "INNER JOIN Empleados E ON P.IdEmpleado = E.IdEmpleado " +
                    "WHERE P.Status = 'Activo' AND P.IdEmpleado = @IdEmpleado";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@IDEmpleado", (int)cboEmpleados.SelectedValue);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Prestamo prestamo = new Prestamo
                    {
                        IdPrestamo = reader.GetInt32(0),
                        IdHerramienta = reader.GetString(1),
                        IdEmpleado = reader.GetInt32(2),
                        FechaRegistro = reader.GetDateTime(3),
                        FechaEntrega = reader.GetDateTime(4),
                        Cantidad = reader.GetInt32(5),
                        NombreHerramienta = reader.GetString(6),
                        NombreEmpleado = reader.GetString(7)
                    };

                    Prestamos.Add(prestamo);
                }

                dataGridView1.DataSource = null;

                dataGridView1.DataSource = Prestamos;
            }
        }

        private void LlenarComboBoxEmpleados()
        {
            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                string query = "SELECT IdEmpleado, Nombre FROM Empleados ORDER BY Nombre";

                SqlDataAdapter da = new SqlDataAdapter(query, SqlHelper.GetConnectionString());

                cn.Open();

                DataSet ds = new DataSet();
                da.Fill(ds, "Empleados");

                cboEmpleados.DisplayMember = "Nombre";
                cboEmpleados.ValueMember = "IdEmpleado";
                cboEmpleados.DataSource = ds.Tables["Empleados"];
            }
        }

        private void mostrar_Btn_Click(object sender, EventArgs e)
        {
            LlenarPrestamos();
        }

        private void actualizar_Btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                cn.Open();

                string updateExistenciaQuery = "UPDATE Herramientas SET ExistenciaH = ExistenciaH + @Cantidad WHERE IdHerramientas = @IdHerramienta";

                SqlCommand cmdUpdateExistencia = new SqlCommand(updateExistenciaQuery, cn);

                cmdUpdateExistencia.Parameters.AddWithValue("@IdHerramienta", PrestamoADevolver.IdHerramienta);
                cmdUpdateExistencia.Parameters.AddWithValue("@Cantidad", PrestamoADevolver.Cantidad);

                int rowsAffected = cmdUpdateExistencia.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("NO SE PUDO REALIZAR LA DEVOLUCION.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string query = "UPDATE Prestamos SET Status = 'Completado' WHERE IDPrestamo = @IDPrestamo";

                SqlCommand cmdUpdatePrestamos = new SqlCommand(query, cn);

                cmdUpdatePrestamos.Parameters.AddWithValue("@IDPrestamo", PrestamoADevolver.IdPrestamo);

                rowsAffected = cmdUpdatePrestamos.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("MODIFICACIÓN REALIZADA.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LlenarPrestamos();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            PrestamoADevolver = (Prestamo)dataGridView1.SelectedRows[0].DataBoundItem;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            LlenarPrestamos();
        }
    }
}