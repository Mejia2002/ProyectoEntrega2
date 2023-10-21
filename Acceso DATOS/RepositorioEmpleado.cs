using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Acceso_DATOS
{
    public class RepositorioEmpleado : Archivo
    {
        public RepositorioEmpleado(string fileName) : base(fileName)
        {
        }

        public List<Empleado> ConsultarTodos()
        {
            try
            {
                List<Empleado> lista = new List<Empleado>();

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

        public Empleado BuscarId(string id)
        {
            var lista = ConsultarTodos();
            foreach (var item in lista)
            {
                if (item.Identificacion == id)
                {
                    return item;
                }

            }
            return null;
        }

        private Empleado Mapear(string datos)
        {
            var linea = datos.Split(';');
            Empleado empleado = new Empleado
            {

                Nombre = linea[0],
                Correo = linea[1],
                Identificacion = linea[2],
                Telefono = linea[3],
                SalarioBase = Convert.ToDecimal(linea[4]),
                Bonifiacion = Convert.ToDecimal(linea[5]),
                MesE = Convert.ToInt32(linea[6]),
                AñoE = Convert.ToInt32(linea[7]),
                SalarioTotal = Convert.ToDecimal(linea[8]),


            };
            return empleado;
        }

    }
}
