namespace BugTrackingSystem.Entidades
{
    public class Asignacion
    {
        public int IdAsignacion { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public bool Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
