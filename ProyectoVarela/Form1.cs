using System;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {   
            ConsultarHerramienta registro = new ConsultarHerramienta();
            registro.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados modificar = new ConsultarEmpleados();
            modificar.ShowDialog(this);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            Prestamos prestamos = new Prestamos();
            prestamos.ShowDialog(this);
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            ConsultarMaterial consultar = new ConsultarMaterial();
            consultar.ShowDialog(this);
        }


        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            ConsultarProvedor prov = new ConsultarProvedor();
            prov.ShowDialog(this);
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FRMUsuarios formularioUsuarios = new FRMUsuarios();
            formularioUsuarios.ShowDialog(this);
        }
    }
}
