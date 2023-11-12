using Acceso_DATOS;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GastoOtrosInsumosService
    {
        Acceso_DATOS.GastroOtrosInsumosDAL gastroOtrosInsumosDAL = new Acceso_DATOS.GastroOtrosInsumosDAL();

        public void GuardarGastoOtrosInsumos(GastoOtrosInsumos gastoOtrosInsumos)
        {

            gastroOtrosInsumosDAL.InsertarGastosOtrosInsumos(gastoOtrosInsumos);

        }

        public void ConsultarGastoOtrosInsumosl(GastoOtrosInsumos gastoOtrosInsumos)
        {
            gastroOtrosInsumosDAL.BuscarGastosOtrosInsumos(gastoOtrosInsumos);
        }

        public void ModificarGasOtrosInsumos(GastoOtrosInsumos gastoOtrosInsumos)
        {
            gastroOtrosInsumosDAL.ActualizarGastosOtrosInsumos(gastoOtrosInsumos);
        }

        public void EliminarGastoMensual(GastoOtrosInsumos gastoOtrosInsumos)
        {
            gastroOtrosInsumosDAL.EliminarGastosOtrosInsumos(gastoOtrosInsumos);
        }




    }
}
