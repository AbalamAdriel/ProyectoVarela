using ProyectoVarela.Entidades;
using ProyectoVarela.Utilerias;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProyectoVarela
{
    public partial class ConsultarPrestamos : Form
    {
        private List<Prestamo> Prestamos
        {
            get;
            set;
        }

        public ConsultarPrestamos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, System.EventArgs e)
        {
            bool resultIdEmpleado = int.TryParse(txtIdEmpleado.Text, out int idEmpleado);

            if (!resultIdEmpleado || idEmpleado <= 0)
            {
                MessageBox.Show("IDEMPLEADO INVALIDO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dataGridViewPrestamos.DataSource = null;

            Prestamos = new List<Prestamo>();

            using (SqlConnection cn = new SqlConnection(SqlHelper.GetConnectionString()))
            {
                string query = "SELECT P.IdPrestamo, P.IdHerramientas, P.IdEmpleado, P.FechaRegistro, " +
                    "P.FehaEntrega, P.Cantidad, H.Nombre AS NombreHerramienta, E.Nombre AS NombreEmpleado " +
                    "FROM Prestamos P INNER JOIN Herramientas H ON P.IdHerramientas = H.IDHERRAMIENTAS " +
                    "INNER JOIN Empleados E ON P.IdEmpleado = E.IdEmpleado " +
                    "WHERE P.IdEmpleado = @IdEmpleado";

                cn.Open();

                SqlCommand cmdPrestamos = new SqlCommand(query, cn);

                cmdPrestamos.Parameters.AddWithValue("@IdEmpleado", txtIdEmpleado.Text);

                SqlDataReader reader = cmdPrestamos.ExecuteReader();

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

                dataGridViewPrestamos.DataSource = Prestamos;
            }
        }

        private void regresar_Btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, System.EventArgs e)
        {
            if(dataGridViewPrestamos.Rows.Count > 0) 
            { 
                SaveFileDialog guardar = new SaveFileDialog();

                guardar.Filter = "PDF (*.pdf)|*.pdf";
                guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

                DialogResult result = guardar.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (File.Exists(guardar.FileName))
                    {
                        try
                        {
                            File.Delete(guardar.FileName);
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("No se pudo validar la informacion");

                            return;
                        }
                    }
                    
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dataGridViewPrestamos.ColumnCount);

                        pdfTable.DefaultCell.Padding = 2;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn col in dataGridViewPrestamos.Columns) 
                        { 
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                            pdfTable.AddCell(pCell);
                        }

                        foreach(DataGridViewRow viewRow in dataGridViewPrestamos.Rows)
                        {
                            foreach (DataGridViewCell dcell in viewRow.Cells)
                            {
                                pdfTable.AddCell(dcell.Value.ToString());
                            }
                        }

                        using (FileStream fileStream = new FileStream(guardar.FileName, FileMode.Create))
                        {
                            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

                            PdfWriter.GetInstance(pdfDocument, fileStream);
                            
                            pdfDocument.Open();
                            pdfDocument.Add(pdfTable);
                            pdfDocument.Close();
                        }

                        System.Diagnostics.Process.Start(guardar.FileName);
                    }
                    catch (Exception) 
                    {
                        MessageBox.Show("Error al transferir informacion");
                    }
                }
            }   
        }
    }
}