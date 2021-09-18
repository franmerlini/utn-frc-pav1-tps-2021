using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.Entidades
{
    class SueldoPerfilHistorico
    {
        public Perfil Perfil { get; set; }
        public DateTime Fecha { get; set; }
        public float Sueldo { get; set; }
        public bool Borrado { get; set; }
    }
}
