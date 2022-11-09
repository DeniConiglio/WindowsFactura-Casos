using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Model.Derivadas
{
    public class Usuario
    {
        #region constructores
        public Usuario() { }

        public Usuario(Cliente cliente)
        {
            this.cliente = cliente;
        }
        #endregion

        #region propiedades
        public Cliente cliente { get; set; }
        #endregion
    }
}