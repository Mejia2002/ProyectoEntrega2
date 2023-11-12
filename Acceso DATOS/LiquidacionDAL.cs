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
    public class LiquidacionDAL: ConexionBD
    {

        public void InsertarLiquidacion(Liquidacion liquidacion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarLiquidacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoLiquidacion", liquidacion.CodigoLiquidacion);
                        cmd.Parameters.AddWithValue("@IdentificacionL", liquidacion.IdentificacionL.Identificacion);
                        cmd.Parameters.AddWithValue("@MesL", liquidacion.MesL);
                        cmd.Parameters.AddWithValue("@AñoL", liquidacion.AñoL);
                        cmd.Parameters.AddWithValue("@DiasTrabajados", liquidacion.DiasTrabajados);
                        cmd.Parameters.AddWithValue("@LiquidacionPorDia", liquidacion.LiquidacionPorDia);
                        cmd.Parameters.AddWithValue("@TotalLiquidacion", liquidacion.TotalLiquidacion);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"La liquidación con Código {liquidacion.CodigoLiquidacion}, Identificación del Empleado {liquidacion.IdentificacionL.Identificacion} ha sido insertada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine($"La liquidación con Código {liquidacion.CodigoLiquidacion}, Identificación del Empleado {liquidacion.IdentificacionL.Identificacion} ya existe. No se puede realizar la inserción.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar la liquidación: {ex.Message}");
            }
        }

        public void EliminarLiquidacion(Liquidacion liquidacion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("EliminarLiquidacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoLiquidacion", liquidacion.CodigoLiquidacion);
                        cmd.Parameters.AddWithValue("@IdentificacionL", liquidacion.IdentificacionL.Identificacion);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"La liquidación con Código {liquidacion.CodigoLiquidacion}, Identificación del Empleado {liquidacion.IdentificacionL.Identificacion} ha sido eliminada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine($"La liquidación con Código {liquidacion.CodigoLiquidacion}, Identificación del Empleado {liquidacion.IdentificacionL.Identificacion} no existe. No se puede realizar la eliminación.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la liquidación: {ex.Message}");
            }
        }

        public void BuscarLiquidacion(Liquidacion liquidacion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("BuscarLiquidacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoLiquidacion", liquidacion.CodigoLiquidacion);
                        cmd.Parameters.AddWithValue("@IdentificacionL", liquidacion.IdentificacionL.Identificacion);
                        cmd.Parameters.AddWithValue("@MesL", liquidacion.MesL);
                        cmd.Parameters.AddWithValue("@AñoL", liquidacion.AñoL);
                        cmd.Parameters.AddWithValue("@DiasTrabajados", liquidacion.DiasTrabajados);
                        cmd.Parameters.AddWithValue("@LiquidacionPorDia", liquidacion.LiquidacionPorDia);
                        cmd.Parameters.AddWithValue("@TotalLiquidacion", liquidacion.TotalLiquidacion);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"La liquidación con Código {reader["CodigoLiquidacion"]}, Identificación del Empleado {reader["IdentificacionL"]}, Mes {reader["MesL"]}, Año {reader["AñoL"]}, DiasTrabajados {reader["DiasTrabajados"]}, LiquidaciónPorDia {reader["LiquidacionPorDia"]} y TotalLiquidacion {reader["TotalLiquidacion"]} existe.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"La liquidación con Código {liquidacion.CodigoLiquidacion}, Identificación del Empleado {liquidacion.IdentificacionL.Identificacion}, Mes {liquidacion.MesL}, Año {liquidacion.AñoL}, DiasTrabajados {liquidacion.DiasTrabajados}, LiquidaciónPorDia {liquidacion.LiquidacionPorDia} y TotalLiquidacion {liquidacion.TotalLiquidacion} no existe.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar la liquidación: {ex.Message}");
            }
        }

        public void ActualizarLiquidacion(Liquidacion liquidacion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarLiquidacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CodigoLiquidacion", liquidacion.CodigoLiquidacion);
                        cmd.Parameters.AddWithValue("@IdentificacionL", liquidacion.IdentificacionL.Identificacion);
                        cmd.Parameters.AddWithValue("@MesL", liquidacion.MesL);
                        cmd.Parameters.AddWithValue("@AñoL", liquidacion.AñoL);
                        cmd.Parameters.AddWithValue("@DiasTrabajados", liquidacion.DiasTrabajados);
                        cmd.Parameters.AddWithValue("@LiquidacionPorDia", liquidacion.LiquidacionPorDia);
                        cmd.Parameters.AddWithValue("@TotalLiquidacion", liquidacion.TotalLiquidacion);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"La liquidación con Código {liquidacion.CodigoLiquidacion}, Identificación del Empleado {liquidacion.IdentificacionL.Identificacion} ha sido actualizada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine($"La liquidación con Código {liquidacion.CodigoLiquidacion}, Identificación del Empleado {liquidacion.IdentificacionL.Identificacion} no existe. No se puede realizar la actualización.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la liquidación: {ex.Message}");
            }
        }







    }
}
