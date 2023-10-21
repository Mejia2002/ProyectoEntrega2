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
        private string fileName = "factura.txt";
        RepositorioFactura repositorio;

        private List<Factura> facturas;
        public FacturaService()
        {
            repositorio = new RepositorioFactura(fileName);
            RefrescarLista();
        }
        void RefrescarLista()
        {
            facturas = repositorio.ConsultarTodos();
        }
        public string Guardar(Factura factura)
        {
            var msg = repositorio.Guardar(factura.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Factura> Consultar()
        {
            return facturas;
        }

        public Factura BuscarId(string id)
        {
            foreach (var item in facturas)
            {
                if (item.CodigoFactura == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Eliminar(List<Factura> list)
        {
            repositorio.Eliminar(list);
            RefrescarLista();
        }
    }
}
