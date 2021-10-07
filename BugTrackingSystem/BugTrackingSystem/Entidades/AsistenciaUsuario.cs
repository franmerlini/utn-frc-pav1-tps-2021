using System;

namespace BugTrackingSystem.Entidades
{
    public class AsistenciaUsuario
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraIngreso { get; set; }
        public string HoraSalida { get; set; }
        public EstadoAsistencia EstadoAsistencia { get; set; }
        public string Comentario { get; set; }
        public bool Borrado { get; set; }
    }
}
