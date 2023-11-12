using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DATOS
{
    public class GastroOtrosInsumosDAL: ConexionBD
    {
        public void InsertarGastosOtrosInsumos(GastoOtrosInsumos gastosOtrosInsumos)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarGastosOtrosInsumos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FechaCompra", gastosOtrosInsumos.FechaCompra);
                        cmd.Parameters.AddWithValue("@NombreProducto", gastosOtrosInsumos.NombreProducto);
                        cmd.Parameters.AddWithValue("@CostoProducto", gastosOtrosInsumos.CostoProducto);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"La compra para la Fecha {gastosOtrosInsumos.FechaCompra}, Nombre del Producto {gastosOtrosInsumos.NombreProducto} ha sido insertada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine($"La compra para la Fecha {gastosOtrosInsumos.FechaCompra}, Nombre del Producto {gastosOtrosInsumos.NombreProducto} ya existe. No se puede realizar la inserción.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar la compra: {ex.Message}");
            }
        }

        public void EliminarGastosOtrosInsumos(GastoOtrosInsumos gastosOtrosInsumos)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("EliminarGastosOtrosInsumos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FechaCompra", gastosOtrosInsumos.FechaCompra);
                        cmd.Parameters.AddWithValue("@NombreProducto", gastosOtrosInsumos.NombreProducto);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"La compra para la Fecha {gastosOtrosInsumos.FechaCompra}, Nombre del Producto {gastosOtrosInsumos.NombreProducto} ha sido eliminada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine($"La compra para la Fecha {gastosOtrosInsumos.FechaCompra}, Nombre del Producto {gastosOtrosInsumos.NombreProducto} no existe. No se puede realizar la eliminación.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la compra: {ex.Message}");
            }
        }

        public void BuscarGastosOtrosInsumos(GastoOtrosInsumos gastosOtrosInsumos)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("BuscarGastosOtrosInsumos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FechaCompra", gastosOtrosInsumos.FechaCompra);
                        cmd.Parameters.AddWithValue("@NombreProducto", gastosOtrosInsumos.NombreProducto);
                        cmd.Parameters.AddWithValue("@CostoProducto", gastosOtrosInsumos.CostoProducto);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"La compra para la Fecha {reader["FechaCompra"]}, Nombre del Producto {reader["NombreProducto"]}, y Costo {reader["CostoProducto"]} existe.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"La compra para la Fecha {gastosOtrosInsumos.FechaCompra}, Nombre del Producto {gastosOtrosInsumos.NombreProducto}, y Costo {gastosOtrosInsumos.CostoProducto} no existe.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar la compra: {ex.Message}");
            }
        }

        public void ActualizarGastosOtrosInsumos(GastoOtrosInsumos gastosOtrosInsumos)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarGastosOtrosInsumos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FechaCompra", gastosOtrosInsumos.FechaCompra);
                        cmd.Parameters.AddWithValue("@NombreProducto", gastosOtrosInsumos.NombreProducto);
                        cmd.Parameters.AddWithValue("@NuevoCostoProducto", gastosOtrosInsumos.CostoProducto);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"La compra para la Fecha {gastosOtrosInsumos.FechaCompra}, Nombre del Producto {gastosOtrosInsumos.NombreProducto} ha sido actualizada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine($"La compra para la Fecha {gastosOtrosInsumos.FechaCompra}, Nombre del Producto {gastosOtrosInsumos.NombreProducto} no existe. No se puede realizar la actualización.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la compra: {ex.Message}");
            }
        }

    }
}
