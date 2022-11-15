using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models.Base
{
    public class Persona : DatosContacto
    {
        public Persona()
        {
        }

        public Persona(string nombre, string apellido, string email, string direccion, string telefono) : base(email, direccion, telefono)
        {
            Nombre= nombre;
            Apellido= apellido; 
        }


        public string Nombre { get; set; }
        public string Apellido { get; set; }


 
    }
}
