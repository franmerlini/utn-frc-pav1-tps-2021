using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.Entidades
{
    class SueldoAsignacion
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public Asignacion Asignacion { get; set; }
        public float Monto { get; set; }
        public int Cantidad { get; set; }
    }
}
