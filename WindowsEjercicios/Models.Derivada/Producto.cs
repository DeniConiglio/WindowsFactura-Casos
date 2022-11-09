using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Model.Derivadas
{
    public class Producto
    {

        #region constructores
        public Producto() { }
        public Producto(string nombre, decimal precio, List<DetalleFactura> detalleFacturas, Categoria categoria)
        {
            Nombre = nombre;
            Precio = precio;
            this.detalleFacturas = detalleFacturas;
            this.categoria = categoria;
        }
        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public List<DetalleFactura> detalleFacturas { get; set; }
        public Categoria categoria { get; set; }

        #endregion
    }
}