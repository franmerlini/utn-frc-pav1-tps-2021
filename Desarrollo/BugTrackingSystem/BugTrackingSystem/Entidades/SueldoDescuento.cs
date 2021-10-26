using System;

namespace BugTrackingSystem.Entidades
{
    public class SueldoDescuento
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public Descuento Descuento { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
    }
}
