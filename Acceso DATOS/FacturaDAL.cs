using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Acceso_DATOS
{
    public class FacturaDAL : ConexionBD
    {


        public void InsertarFactura(Factura factura)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarFactura", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoFactura", factura.CodigoFactura);
                        cmd.Parameters.AddWithValue("@IdentificacionF", factura.IdentifiacionF);
                        cmd.Parameters.AddWithValue("@MesF", factura.MesF);
                        cmd.Parameters.AddWithValue("@AñoF", factura.AñoF);
                        cmd.Parameters.AddWithValue("@SueldoBaseF", factura.SueldoBaseF);
                        cmd.Parameters.AddWithValue("@BonificacionF", factura.BonificacionF);
                        cmd.Parameters.AddWithValue("@TotalPagadoF", factura.TotalPagadoF);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar la factura: {ex.Message}");
            }
        }

        public void ActualizarFactura(Factura factura)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarFactura", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoFactura", factura.CodigoFactura);
                        cmd.Parameters.AddWithValue("@IdentificacionF", factura.IdentifiacionF);
                        cmd.Parameters.AddWithValue("@MesF", factura.MesF);
                        cmd.Parameters.AddWithValue("@AñoF", factura.AñoF);
                        cmd.Parameters.AddWithValue("@SueldoBaseF", factura.SueldoBaseF);
                        cmd.Parameters.AddWithValue("@BonificacionF", factura.BonificacionF);
                        cmd.Parameters.AddWithValue("@TotalPagadoF", factura.TotalPagadoF);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la factura: {ex.Message}");
            }
        }

        public void EliminarFactura(Factura factura)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("EliminarFactura", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoFactura", factura.CodigoFactura);
                        cmd.Parameters.AddWithValue("@IdentificacionF", factura.IdentifiacionF);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la factura: {ex.Message}");
            }
        }

        public void BuscarFactura(Factura factura)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("BuscarFactura", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoFactura", factura.CodigoFactura);
                        cmd.Parameters.AddWithValue("@IdentificacionF", factura.IdentifiacionF);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Console.WriteLine($"La factura con CodigoFactura {factura.CodigoFactura} e Identificacion {factura.IdentifiacionF} existe.");

                                while (reader.Read())
                                {
                                    // Procesar los datos leídos si es necesario
                                }
                            }
                            else
                            {
                                Console.WriteLine($"La factura con CodigoFactura {factura.CodigoFactura} e Identificacion {factura.IdentifiacionF} no existe.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar la factura: {ex.Message}");
            }
        }
    }
}