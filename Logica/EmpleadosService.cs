using Acceso_DATOS;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmpleadosService
    {
        Acceso_DATOS.EmpleadoDAL empleadoDAL = new Acceso_DATOS.EmpleadoDAL();

        public void GuardarEmpleado(Empleado empleado)
        {

            empleadoDAL.InsertarEmpleado(empleado);

        }

        public void ConsultarEmpleado(Empleado empleado)
        {
            empleadoDAL.BuscarEmpleado(empleado);
        }

        public void ModificarEmpleado(Empleado empleado)
        {
            empleadoDAL.ActualizarEmpleado(empleado);
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            empleadoDAL.EliminarEmpleadoPorIdentificacion(empleado);
        }



    }
}
