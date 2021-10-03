namespace BugTrackingSystem.Entidades
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
