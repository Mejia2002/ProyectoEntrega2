using Acceso_DATOS;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logica
{
    public class LiquidacionService
    {
        Acceso_DATOS.LiquidacionDAL liquidacionDAL = new Acceso_DATOS.LiquidacionDAL();

        public void GuardarLiquidacion(Liquidacion liquidacion)
        {

            liquidacionDAL.InsertarLiquidacion(liquidacion);

        }

        public void ConsultarLiquidacion(Liquidacion liquidacion)
        {
            liquidacionDAL.BuscarLiquidacion(liquidacion);
        }

        public void ModificarLiquidacion(Liquidacion liquidacion)
        {
            liquidacionDAL.ActualizarLiquidacion(liquidacion);
        }

        public void EliminarGastoMensual(Liquidacion liquidacion)
        {
            liquidacionDAL.EliminarLiquidacion(liquidacion);
        }


    }
}
