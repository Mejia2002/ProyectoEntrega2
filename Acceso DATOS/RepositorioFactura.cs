using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Acceso_DATOS
{
    public class RepositorioFactura : Archivo
    {
        public RepositorioFactura(string fileName) : base(fileName)
        {
        }

        public List<Factura> ConsultarTodos()
        {
            try
            {
                List<Factura> lista = new List<Factura>();

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

        private Factura Mapear(string datos)
        {
            if (datos == "" || datos == null)
            {
                return null;
            }
            var linea = datos.Split(';');
            Factura factura = new Factura
            {
                CodigoFactura = linea[0],
                IdentifiacionF = new RepositorioEmpleado("empleado.txt").BuscarId(linea[1]),
                MesF = Convert.ToInt32(linea[2]),
                AñoF = Convert.ToInt32(linea[3]),
                SueldoBaseF = Convert.ToDecimal(linea[4]),
                BonificacionF = Convert.ToDecimal(linea[5]),
                TotalPagadoF = Convert.ToDecimal(linea[6]),




            };
            return factura;
        }
    }
}
