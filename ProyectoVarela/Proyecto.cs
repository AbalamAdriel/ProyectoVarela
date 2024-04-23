using System;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class Proyecto : Form
    {
        public Proyecto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProyecto consultarProyecto = new ConsultarProyecto();
            consultarProyecto.ShowDialog(this);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarProyectos Regproyect = new RegistrarProyectos();
            Regproyect.ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarProyecto proyecto = new ModificarProyecto();
            proyecto.ShowDialog(this);
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {

        }
    }
}
