using Entidades.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEjercicios;

namespace Entidades.Model.Derivadas
{
    public class Empleado : Persona
    {
        #region constructores
        public Empleado() { }
        public Empleado(string legajo, List<Factura> facturas, string nombre, string apellido, string dNI) : base(nombre, apellido, dNI)
        {
            Legajo = legajo;
            this.facturas = facturas;
        }

        #endregion

        #region propiedades
        public string Legajo { get; set; }
        public List<Factura> facturas { get; set; }
        #endregion
    }
}