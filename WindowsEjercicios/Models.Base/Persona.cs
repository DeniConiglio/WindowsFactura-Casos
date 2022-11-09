using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Model.Base
{
    public abstract class Persona
    {
        #region constructor
        public Persona() { }
        public Persona(string nombre, string apellido, string dNI)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
        }

        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        #endregion
    }
}