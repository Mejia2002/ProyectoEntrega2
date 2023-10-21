using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DATOS
{
    public class RepositorioLiquidacion : Archivo
    {
        public RepositorioLiquidacion(string fileName) : base(fileName)
        {
        }

        public List<Liquidacion> ConsultarTodos()
        {
            try
            {
                List<Liquidacion> lista = new List<Liquidacion>();

                StreamReader sr = new StreamReader(fileName);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private Liquidacion Mapear(string datos)
        {
            if (datos == "" || datos == null)
            {
                return null;
            }
            var linea = datos.Split(';');
            Liquidacion liquidacion = new Liquidacion
            {
                IdentificacionL = new RepositorioEmpleado("empleados.txt").BuscarId(linea[0]),
                MesL = Convert.ToInt32(linea[1]),
                AñoL = Convert.ToInt32(linea[2]),
                DiasTrabajados = Convert.ToInt32(linea[3]),
                LiquidacionPorDia = Convert.ToDecimal(linea[4]),
                TotalLiquidacion = Convert.ToDecimal(linea[4])

            };
            return liquidacion;
        }
    }
}
