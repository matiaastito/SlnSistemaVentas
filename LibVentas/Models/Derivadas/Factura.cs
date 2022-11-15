using LibVentas.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models
{
    public class Factura : DocumentoComercial
    {
        public Factura(string tipo, string numero, string cliente, string direccion, string condicionIVA, string condicionVENTA, DateTime fecha, List<Item> detalle) : base(numero, cliente, direccion, condicionIVA, condicionVENTA, fecha, detalle)
        {
            Tipo= tipo;
        }

        public string Tipo { get; set; }
        

    }
}
