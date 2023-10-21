using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liquidacion
    {
        public Liquidacion()
        {
        }

        public Liquidacion(string codigoLiquidacion, int mesL, int añoL, int diasTrabajados, decimal liquidacionPorDia, decimal totalLiquidacion)
        {
            CodigoLiquidacion = codigoLiquidacion;
            MesL = mesL;
            AñoL = añoL;
            DiasTrabajados = diasTrabajados;
            LiquidacionPorDia = liquidacionPorDia;
            TotalLiquidacion = totalLiquidacion;
        }

        public string CodigoLiquidacion { get; set; }
        public Empleado IdentificacionL { get; set; }
        public int MesL { get; set; }
        public int AñoL { get; set; }
        public int DiasTrabajados { get; set; }
        public decimal LiquidacionPorDia { get; set; }
        public decimal TotalLiquidacion { get; set; }

        public override string ToString()
        {
            return $"{CodigoLiquidacion};{IdentificacionL.Identificacion};{MesL};{AñoL};{DiasTrabajados};{LiquidacionPorDia};{TotalLiquidacion}";
        }
    }

}
