using OtrosCasos.Caso6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OtrosCasos.Caso6
{
    public class Clinica
    {
        public Clinica(int id, string nombre, Director director)
        {
            Id = id;
            Nombre = nombre;
            this.director = director;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Director director { get; set; }
    }
}