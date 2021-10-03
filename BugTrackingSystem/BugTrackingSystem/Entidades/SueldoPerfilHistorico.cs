using System;

namespace BugTrackingSystem.Entidades
{
    public class SueldoPerfilHistorico
    {
        public Perfil Perfil { get; set; }
        public DateTime Fecha { get; set; }
        public float Sueldo { get; set; }
        public bool Borrado { get; set; }
    }
}
