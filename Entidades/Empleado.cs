using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public Empleado(string nombre, string correo, string identificacion, string telefono, decimal salarioBase, decimal bonifiacion, int mesE, int añoE, decimal salarioTotal)
        {
            Nombre = nombre;
            Correo = correo;
            Identificacion = identificacion;
            Telefono = telefono;
            SalarioBase = salarioBase;
            Bonifiacion = bonifiacion;
            MesE = mesE;
            AñoE = añoE;
            SalarioTotal = salarioTotal;
        }
        public Empleado()
        {
        }

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Bonifiacion { get; set; }
        public int MesE { get; set; }
        public int AñoE { get; set; }
        public decimal SalarioTotal { get; set; }
 

        public override string ToString()
        {
            return $"{Nombre};{Correo};{Identificacion};{Telefono};{SalarioBase};{Bonifiacion};{MesE};{AñoE};{SalarioTotal}";
        }
    }
  



}
