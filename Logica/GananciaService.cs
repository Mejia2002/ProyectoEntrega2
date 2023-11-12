using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GananciaService
    {
        Acceso_DATOS.GananciaDAL gananciaDAL = new Acceso_DATOS.GananciaDAL();


        public void GuardarGanancia(Ganancia ganancia)
        {

             gananciaDAL.InsertarGanancia(ganancia);

        }

        public void ConsultarGanancia(Ganancia ganancia)
        {
             gananciaDAL.BuscarGanancia(ganancia);
        }

        public void ModificarGanancia(Ganancia ganancia)
        {
             gananciaDAL.ActualizarGanancia(ganancia);
        }

        public void EliminarGanancia(Ganancia ganancia)
        {
             gananciaDAL.EliminarGanancia(ganancia);
        }



    }
}
