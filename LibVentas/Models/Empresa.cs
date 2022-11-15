using LibVentas.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas
{
    public abstract class Empresa : DatosContacto
    {
        public Empresa()
        {
        }
        public Empresa(string nombre, string cuit, Persona contacto, string email, string direccion, string telefono) : base(email, direccion, telefono)
        {
            Nombre = nombre;
            CUIT = cuit;
            Contacto = contacto;
        }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public Persona Contacto { get; set; }


        


    }
}
