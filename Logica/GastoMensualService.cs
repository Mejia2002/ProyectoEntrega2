using Acceso_DATOS;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GastoMensualService
    {
        Acceso_DATOS.GastoMensualDAL gastoMensualDAL = new Acceso_DATOS.GastoMensualDAL();


        public void GuardarGastoMensual(GastoMensual gastoMensual)
        {

            gastoMensualDAL.InsertarGastoMensual(gastoMensual);

        }

        public void ConsultarGastoMensual(GastoMensual gastoMensual)
        {
            gastoMensualDAL.BuscarGastoMensual(gastoMensual);
        }

        public void ModificarGastoMensual(GastoMensual gastoMensual)
        {
            gastoMensualDAL.EliminarGastoMensual(gastoMensual);
        }

        public void EliminarGastoMensual(GastoMensual gastoMensual)
        {
            gastoMensualDAL.EliminarGastoMensual(gastoMensual);
        }




    }
}
