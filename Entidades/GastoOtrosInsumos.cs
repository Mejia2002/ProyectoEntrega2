using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GastoOtrosInsumos
    {
        public DateTime FechaCompra { get; set; }
        public string NombreProducto;
        public decimal CostoProducto;

        public GastoOtrosInsumos()
        {
        }

        public GastoOtrosInsumos(DateTime fechaCompra, string nombreProducto, decimal costoProducto)
        {
            FechaCompra = fechaCompra;
            NombreProducto = nombreProducto;
            CostoProducto = costoProducto;
        }
        public override string ToString()
        {
            return $"{FechaCompra};{NombreProducto};{CostoProducto}";
        }
    }
}
