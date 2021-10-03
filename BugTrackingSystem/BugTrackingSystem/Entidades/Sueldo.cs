using System;

namespace BugTrackingSystem.Entidades
{
    public class Sueldo
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public float SueldoBruto { get; set; }
        public bool Borrado { get; set; }
    }
}
