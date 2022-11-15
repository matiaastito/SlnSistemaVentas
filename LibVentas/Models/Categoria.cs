using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models
{
    public class Categoria
    {
        public Categoria()
        {
        }

        public Categoria(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }


    }
}
