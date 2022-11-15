using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public static double IVA { get; set; }

        private decimal _PrecioBruto = 0;
        public decimal PrecioBruto
        {
            get
            {
                _PrecioBruto = Convert.ToDecimal(Margen) + PrecioCosto;
                return _PrecioBruto;
            }
        }
        private decimal _PrecioVenta = 0;
        public decimal PrecioVenta
        {
            get
            {
                _PrecioVenta = Convert.ToDecimal(1 + IVA) * PrecioBruto;
                return _PrecioVenta;
            }
        }
        public Empresa Proveedor { get; set; }
        public Categoria Categoria { get; set; }
        public Categoria SubCategoria { get; set; }

        public Producto(string nombre, decimal precioCosto, double margen, double iVA, decimal precioBruto, decimal precioVenta, Empresa proveedor, Categoria categoria, Categoria subCategoria)
        {
            Nombre = nombre;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iVA;
            _PrecioBruto = precioBruto;
            _PrecioVenta = precioVenta;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

        public Producto()
        {
        }
    }
}
