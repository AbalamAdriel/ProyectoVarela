using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVarela
{
    public partial class FRMUsuarios : Form
    {
        public FRMUsuarios()
        {
            InitializeComponent();
        }

        private void btn_NuevoUsuario_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.ShowDialog(this);
        }

        private void btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            FRMEliminarUsuario formularioEliminarUsuario = new FRMEliminarUsuario();
            formularioEliminarUsuario.ShowDialog(this);
        }
    }
}
