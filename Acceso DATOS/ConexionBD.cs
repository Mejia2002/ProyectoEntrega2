using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;


namespace Acceso_DATOS
{
    public class ConexionBD
    {

        protected static readonly string ConnectionString = "Data Source=DESKTOP-FD02KA0\\SQLEXPRESS;Initial Catalog=FinanzaDB;Integrated Security=True";

        private SqlConnection Connection;

        public SqlConnection AbrirConexion()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();
                Console.WriteLine("Conexión abierta correctamente.");
                return Connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                return null;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                    Console.WriteLine("Conexión cerrada correctamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
            }
        }

        public bool ConexionEstaAbierta()
        {
            return Connection != null && Connection.State == System.Data.ConnectionState.Open;
        }






    }
}
