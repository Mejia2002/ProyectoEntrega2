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
    public class FacturaService
    {
        Acceso_DATOS.FacturaDAL facturaDAL = new Acceso_DATOS.FacturaDAL();

        public void GuardarFactura(Factura factura)
        {

             facturaDAL.InsertarFactura(factura);

        }

        public void ConsultarFactura(Factura factura)
        {
            facturaDAL.BuscarFactura(factura);
        }

        public void ModificarFactura(Factura factura)
        {
            facturaDAL.ActualizarFactura(factura);
        }

        public void EliminarFactura(Factura factura)
        {
            facturaDAL.EliminarFactura(factura);
        }

    }
}
