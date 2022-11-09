using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEjercicios;

namespace Entidades.Model.Derivadas
{
    public class DetalleFactura
    {
        #region constructores
        public DetalleFactura() { }

        public DetalleFactura(Factura factura, Producto producto)
        {
            this.factura = factura;
            this.producto = producto;
        }
        #endregion

        #region propiedades
        public Factura factura { get; set; }
        public Producto producto { get; set; }
        #endregion


    }
}