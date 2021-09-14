using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.Entidades
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string contrasena;
        private string email;
        private Perfil perfil;

        public Usuario()
        {
        }

        public Usuario(string nombre, string contrasena)
        {
            this.Nombre = nombre;
            this.Contrasena = contrasena;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Email { get => email; set => email = value; }
        internal Perfil Perfil { get => perfil; set => perfil = value; }
    }
}
