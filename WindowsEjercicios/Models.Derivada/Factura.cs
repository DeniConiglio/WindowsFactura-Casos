using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Model.Derivadas
{
    public class Factura
    {
        #region constructores
        public Factura() { }

        public Factura(Cliente cliente, List<DetalleFactura> detalleFacturas, Empleado empleado)
        {
            this.cliente = cliente;
            this.detalleFacturas = detalleFacturas;
            this.empleado = empleado;
        }

        #endregion

        #region propiedades
        public Cliente cliente { get; set; }
        public List<DetalleFactura> detalleFacturas { get; set; }
        public Empleado empleado { get; set; }
        #endregion
    }
}