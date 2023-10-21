using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public Factura()
        {
        }

        public Factura(string codigoFactura, int mesF, int añoF, decimal sueldoBaseF, decimal bonificacionF, decimal totalPagadoF)
        {
            CodigoFactura = codigoFactura;
           
            MesF = mesF;
            AñoF = añoF;
            SueldoBaseF = sueldoBaseF;
            BonificacionF = bonificacionF;
            TotalPagadoF = totalPagadoF;
        }

        public string CodigoFactura { get; set; }
        public Empleado IdentifiacionF { get; set; }
        public int MesF { get; set; }
        public int AñoF { get; set; }
        public decimal SueldoBaseF { get; set; }
        public decimal BonificacionF { get; set; }
        public decimal TotalPagadoF { get; set; }

        public override string ToString()
        {
            return $"{CodigoFactura};{IdentifiacionF.Identificacion};{MesF};{AñoF};{SueldoBaseF};{BonificacionF};{TotalPagadoF}";
        }

    }

}
