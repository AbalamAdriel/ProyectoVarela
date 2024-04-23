using System;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsultarPrestamos consultar = new ConsultarPrestamos();
            consultar.ShowDialog(this);
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            RegistrarPrestamos registrar = new RegistrarPrestamos();
            registrar.ShowDialog(this);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarPrestamos modificar = new ModificarPrestamos();    
            modificar.ShowDialog(this);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}