using Entidades.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEjercicios;

namespace Entidades.Model.Derivadas
{
    public class Cliente : Persona
    {
        #region constructores
        public Cliente() { }
        public Cliente(List<Factura> facturas, Usuario usuario, string nombre, string apellido, string dNI) : base(nombre, apellido, dNI)
        {
            this.facturas = facturas;
            this.usuario = usuario;
        }
        #endregion

        #region propiedades
        public List<Factura> facturas { get; set; }

        public Usuario usuario { get; set; }
        #endregion
    }
}