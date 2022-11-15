using LibVentas.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models
{
    public class Remito : DocumentoComercial
    {
        public Remito(DateTime fechaEntrega, string numero, string cliente, string direccion, string condicionIVA, string condicionVENTA, DateTime fecha, List<Item> detalle) : base(numero, cliente, direccion, condicionIVA, condicionVENTA, fecha, detalle)
        {
            FechaEntrega= fechaEntrega;
        }

        public DateTime FechaEntrega { get; set; }

    }
}
