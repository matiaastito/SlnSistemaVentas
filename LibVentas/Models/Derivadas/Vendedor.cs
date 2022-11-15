using LibVentas.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models
{
    public class Vendedor : Persona
    {
        public Vendedor()
        {
        }

        public Vendedor(string dni, string nombre, string email, string apellido, string telefono, string direccion) : base(nombre, email, apellido, telefono, direccion)
        {
            DNI= dni;
        }

        public string DNI { get; set; }
        

    }
}
