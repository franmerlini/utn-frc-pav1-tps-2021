namespace BugTrackingSystem.Entidades
{
    public class EstadoAsistencia
    {
        public int IdEstadoAsistencia { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
