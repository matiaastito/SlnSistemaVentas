using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models.Base
{
    public abstract class DocumentoComercial
    {
        public string Numero { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVENTA { get; set; }
        public DateTime Fecha { get; set; }
        public List <Item> Detalle { get; set; }

        private decimal _Total = 0;
        public decimal Total { get {
                foreach (var monto in Detalle)
                {
                    _Total += monto.Importe;
                } return _Total;
            } }

        protected DocumentoComercial(string numero, string cliente, string direccion, string condicionIVA, string condicionVENTA, DateTime fecha, List<Item> detalle)
        {
            Numero = numero;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIVA;
            CondicionVENTA = condicionVENTA;
            Fecha = fecha;
            Detalle = detalle;
        }
    }
}
