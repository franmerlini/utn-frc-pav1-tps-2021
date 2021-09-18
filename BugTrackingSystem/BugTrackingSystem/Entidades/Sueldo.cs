using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.Entidades
{
    class Sueldo
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public float SueldoBruto { get; set; }
        public bool Borrado { get; set; }
    }
}
