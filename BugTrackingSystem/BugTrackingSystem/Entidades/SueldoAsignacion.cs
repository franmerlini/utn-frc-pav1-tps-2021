using System;

namespace BugTrackingSystem.Entidades
{
    public class SueldoAsignacion
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public Asignacion Asignacion { get; set; }
        public float Monto { get; set; }
        public int Cantidad { get; set; }
        public bool Borrado { get; set; }
    }
}
