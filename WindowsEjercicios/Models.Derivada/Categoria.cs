using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEjercicios;

namespace Entidades.Model.Derivadas
{
    public class Categoria
    {
        #region categorias
        public Categoria() { }

        public Categoria(string nombre, List<Producto> productos)
        {
            Nombre = nombre;
            this.productos = productos;
        }
        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public List<Producto> productos { get; set; }

        #endregion
    }
}