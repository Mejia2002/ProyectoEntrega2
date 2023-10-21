using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Entidades
{
    public class GastoMensual
    {
        public GastoMensual()
        {
        }

        public GastoMensual(int mesGastoMensual, int añoGastoMensual, decimal totalGastoSueldos, decimal totalGastoInsumos, decimal gastoLiquidaciones, decimal totalGastado)
        {
            MesGastoMensual = mesGastoMensual;
            AñoGastoMensual = añoGastoMensual;
            TotalGastoSueldos = totalGastoSueldos;
            TotalGastoInsumos = totalGastoInsumos;
            GastoLiquidaciones = gastoLiquidaciones;
            TotalGastado = totalGastado;
        }

        public int MesGastoMensual { get; set; }
        public int AñoGastoMensual { get; set; }
        public decimal TotalGastoSueldos { get; set; }
        public decimal TotalGastoInsumos { get; set; }
        public decimal GastoLiquidaciones { get; set; }
        public decimal TotalGastado { get; set; }

        public override string ToString()
        {
            return $"{MesGastoMensual};{AñoGastoMensual};{TotalGastoSueldos};{TotalGastoInsumos};{GastoLiquidaciones};{TotalGastado}";
        }

    }


}
