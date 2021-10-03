namespace BugTrackingSystem.Entidades
{
    public class Descuento
    {
        public int IdDescuento { get; set; }
        public string Nombre { get; set; }
        public float Monto { get; set; }
        public bool Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
