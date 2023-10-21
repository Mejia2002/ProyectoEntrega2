using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using Acceso_DATOS;

namespace Logica
{
    public class EmpleadoService
    {
        private string fileName = "empleado.txt";
        RepositorioEmpleado repositorio;

        private List<Empleado> empleados;
        public EmpleadoService()
        {
            repositorio = new RepositorioEmpleado(fileName);
            RefrescarLista();
        }
        void RefrescarLista()
        {
            empleados = repositorio.ConsultarTodos();
        }
        public string Guardar(Empleado empleado)
        {
            var msg = repositorio.Guardar(empleado.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Empleado> Consultar()
        {
            return empleados;
        }

        public Empleado BuscarId(string id)
        {
            foreach (var item in empleados)
            {
                if (item.Identificacion == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Eliminar(List<Empleado> list)
        {
            repositorio.Eliminar(list);
            RefrescarLista();
        }
    }
}
