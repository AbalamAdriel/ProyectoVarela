using System;

namespace ProyectoVarela.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo
        {
            get;
            set;
        }

        public string IdHerramienta
        {
            get;
            set;
        }

        public string NombreHerramienta
        {
            get;
            set;
        }

        public int IdEmpleado
        {
            get;
            set;
        }

        public string NombreEmpleado
        {
            get;
            set;
        }

        public DateTime FechaRegistro
        {
            get;
            set;
        }

        public DateTime FechaEntrega
        {
            get;
            set;
        }

        public int Cantidad
        {
            get;
            set;
        }
    }
}