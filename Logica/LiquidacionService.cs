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
        private string fileName = "liquidacion.txt";
        RepositorioLiquidacion repositorio;

        private List<Liquidacion> liquidaciones;
        public LiquidacionService()
        {
            repositorio = new RepositorioLiquidacion(fileName);
            RefrescarLista();
        }
        void RefrescarLista()
        {
            liquidaciones = repositorio.ConsultarTodos();
        }
        public string Guardar(Liquidacion liquidacion)
        {
            var msg = repositorio.Guardar(liquidacion.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Liquidacion> Consultar()
        {
            return liquidaciones;
        }

        public Liquidacion BuscarId(string id)
        {
            foreach (var item in liquidaciones)
            {
                if (item.CodigoLiquidacion == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Eliminar(List<Liquidacion> list)
        {
            repositorio.Eliminar(list);
            RefrescarLista();
        }
    }
}
