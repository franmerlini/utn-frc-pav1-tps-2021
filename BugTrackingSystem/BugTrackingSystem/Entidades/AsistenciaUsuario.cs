using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.Entidades
{
    public class AsistenciaUsuario
    {
        public int IdAsistenciaUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime HoraSalida { get; set; }
        public EstadoAsistencia EstadoAsistencia { get; set; }
        public string Comentario { get; set; }
        public bool Borrado { get; set; }

    }
}
