using System;

namespace BugTrackingSystem.Entidades
{
    public class SueldoAsignacion
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public Asignacion Asignacion { get; set; }
        public decimal Monto { get; set; }
        public int Cantidad { get; set; }
    }
}
