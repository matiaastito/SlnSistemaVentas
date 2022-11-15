using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models.Base
{
    public abstract class DatosContacto
    {
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        protected DatosContacto(string email, string direccion, string telefono)
        {
            Email = email;
            Direccion = direccion;
            Telefono = telefono;
        }

        protected DatosContacto()
        {
        }
    }
}
