using LibVentas.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models
{
    public class ClienteIndividuo : Persona
    {
        public ClienteIndividuo()
        {
        }

        public ClienteIndividuo(string nombre, string email, string apellido, string telefono, string direccion) : base(nombre, email, apellido, telefono, direccion)
        {
        }


    }
}
