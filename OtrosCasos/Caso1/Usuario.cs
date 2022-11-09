using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtrosCasos.Caso1
{
    public class Usuario
    {
        public Usuario() { }

        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        public string Nombre { get; set; }
        public string Password { get; set; }

        public Cliente cliente { get; set; }
    }
}