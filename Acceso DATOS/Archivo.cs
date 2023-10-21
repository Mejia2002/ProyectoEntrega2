using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Acceso_DATOS
{
    public class Archivo
    {
        protected string fileName;
        public Archivo(string fileName)
        {
            this.fileName = fileName;
        }
        public void Eliminar<T>(List<T> lista)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName);
                foreach (var item in lista)
                {
                    sw.WriteLine(item.ToString());
                }

                sw.Close();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public String Guardar(string datos)
        {

            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine(datos);
            sw.Close();
            return "datos guardados";
 
        }

    }
}
