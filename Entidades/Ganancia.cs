using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ganancia
    {
        public Ganancia()
        {
        }

        public Ganancia(int mesGanancia, int añoGanancia, decimal ingresoMensual, decimal totalGastoG, decimal totalGanancia)
        {
            MesGanancia = mesGanancia;
            AñoGanancia = añoGanancia;
            IngresoMensual = ingresoMensual;
            TotalGastoG = totalGastoG;
            TotalGanancia = totalGanancia;
        }

        public int MesGanancia { get; set; }
        public int AñoGanancia { get; set; }
        public decimal IngresoMensual { get; set; }
        public decimal TotalGastoG { get; set; }
        public decimal TotalGanancia { get; set; }

        public override string ToString()
        {
            return $"{MesGanancia};{AñoGanancia};{IngresoMensual};{TotalGastoG};{TotalGanancia}";
        }
    }
}
