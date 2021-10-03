using System;

namespace BugTrackingSystem.Entidades
{
    public class SueldoDescuento
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public Descuento Descuento { get; set; }
        public int Cantidad { get; set; }
        public float Monto { get; set; }
        public bool Borrado { get; set; }
    }
}
