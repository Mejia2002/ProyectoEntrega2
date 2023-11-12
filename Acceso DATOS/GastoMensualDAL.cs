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
    public class GastoMensualDAL : ConexionBD
    {
        public void InsertarGastoMensual(GastoMensual gastoMensual)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarGastoMensual", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MesGastoMensual", gastoMensual.MesGastoMensual);
                        cmd.Parameters.AddWithValue("@AñoGastoMensual", gastoMensual.AñoGastoMensual);
                        cmd.Parameters.AddWithValue("@TotalGastoSueldos", gastoMensual.TotalGastoSueldos);
                        cmd.Parameters.AddWithValue("@TotalGastoInsumos", gastoMensual.TotalGastoInsumos);
                        cmd.Parameters.AddWithValue("@GastoLiquidaciones", gastoMensual.GastoLiquidaciones);
                        cmd.Parameters.AddWithValue("@TotalGastado", gastoMensual.TotalGastado);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar la ganancia: {ex.Message}");
            }
        }

        public void ActualizarGastoMensual(GastoMensual gastoMensual)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarGastoMensual", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MesGastoMensual", gastoMensual.MesGastoMensual);
                        cmd.Parameters.AddWithValue("@AñoGastoMensual", gastoMensual.AñoGastoMensual);
                        cmd.Parameters.AddWithValue("@NuevoTotalGastoSueldos", gastoMensual.TotalGastoSueldos);
                        cmd.Parameters.AddWithValue("@NuevoTotalGastoInsumos", gastoMensual.TotalGastoInsumos);
                        cmd.Parameters.AddWithValue("@NuevoGastoLiquidaciones", gastoMensual.GastoLiquidaciones);
                        cmd.Parameters.AddWithValue("@NuevoTotalGastado", gastoMensual.TotalGastado);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"El gasto mensual para el Mes {gastoMensual.MesGastoMensual} y Año {gastoMensual.AñoGastoMensual} ha sido actualizado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine($"El gasto mensual para el Mes {gastoMensual.MesGastoMensual} y Año {gastoMensual.AñoGastoMensual} no existe. No se puede realizar la actualización.");
                            // Puedes lanzar una excepción, devolver un código de error, etc.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el gasto mensual: {ex.Message}");
            }
        }

        public void EliminarGastoMensual(GastoMensual gastoMensual)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("EliminarGastoMensual", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MesGastoMensual", gastoMensual.MesGastoMensual);
                        cmd.Parameters.AddWithValue("@AñoGastoMensual", gastoMensual.AñoGastoMensual);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"El gasto mensual para el Mes {gastoMensual.MesGastoMensual} y Año {gastoMensual.AñoGastoMensual} ha sido eliminado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine($"El gasto mensual para el Mes {gastoMensual.MesGastoMensual} y Año {gastoMensual.AñoGastoMensual} no existe. No se puede realizar la eliminación.");
                            // Puedes lanzar una excepción, devolver un código de error, etc.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el gasto mensual: {ex.Message}");
            }
        }


        public void BuscarGastoMensual(GastoMensual gastoMensual)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("BuscarGastoMensual", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MesGastoMensual", gastoMensual.MesGastoMensual);
                        cmd.Parameters.AddWithValue("@AñoGastoMensual", gastoMensual.AñoGastoMensual);
                        cmd.Parameters.AddWithValue("@TotalGastoSueldos", gastoMensual.TotalGastoSueldos);
                        cmd.Parameters.AddWithValue("@TotalGastoInsumos", gastoMensual.TotalGastoInsumos);
                        cmd.Parameters.AddWithValue("@GastoLiquidaciones", gastoMensual.GastoLiquidaciones);
                        cmd.Parameters.AddWithValue("@TotalGastado", gastoMensual.TotalGastado);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"El gasto mensual para el Mes {reader["MesGastoMensual"]}, Año {reader["AñoGastoMensual"]}, TotalGastoSueldos {reader["TotalGastoSueldos"]}, TotalGastoInsumos {reader["TotalGastoInsumos"]}, GastoLiquidaciones {reader["GastoLiquidaciones"]} y TotalGastado {reader["TotalGastado"]} existe.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"El gasto mensual para el Mes {gastoMensual.MesGastoMensual}, Año {gastoMensual.AñoGastoMensual}, TotalGastoSueldos {gastoMensual.TotalGastoSueldos}, TotalGastoInsumos {gastoMensual.TotalGastoInsumos}, GastoLiquidaciones {gastoMensual.GastoLiquidaciones} y TotalGastado {gastoMensual.TotalGastado} no existe.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar el gasto mensual: {ex.Message}");
            }
        }

    }

}

