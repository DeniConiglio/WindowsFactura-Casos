using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtrosCasos.Caso5
{
    public class DatosContacto
    {

        public DatosContacto(string domicilio, string telefono, string email, Cliente cliente, Empleado empleado)
        {
            Domicilio = domicilio;
            Telefono = telefono;
            Email = email;
            this.cliente = cliente;
            this.empleado = empleado;
        }

        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Cliente cliente { get; set; }
        public Empleado empleado { get; set; }
    }
}