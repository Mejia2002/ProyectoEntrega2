using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DATOS
{
    public class GananciaDAL : ConexionBD
    {
        public void InsertarGanancia(Ganancia ganancia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarGanancia", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MesGanancia", ganancia.MesGanancia);
                        cmd.Parameters.AddWithValue("@AñoGanancia", ganancia.AñoGanancia);
                        cmd.Parameters.AddWithValue("@IngresoMensual", ganancia.IngresoMensual);
                        cmd.Parameters.AddWithValue("@TotalGastoG", ganancia.TotalGastoG);
                        cmd.Parameters.AddWithValue("@TotalGanancia", ganancia.TotalGanancia);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar la ganancia: {ex.Message}");
            }
        }

        public void ActualizarGanancia(Ganancia ganancia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarGanancia", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MesGanancia", ganancia.MesGanancia);
                        cmd.Parameters.AddWithValue("@AñoGanancia", ganancia.AñoGanancia);
                        cmd.Parameters.AddWithValue("@NuevoIngresoMensual", ganancia.IngresoMensual);
                        cmd.Parameters.AddWithValue("@NuevoTotalGastoG", ganancia.TotalGastoG);
                        cmd.Parameters.AddWithValue("@NuevoTotalGanancia", ganancia.TotalGanancia);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la ganancia: {ex.Message}");
            }
        }

        public void EliminarGanancia(Ganancia ganancia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("EliminarGanancia", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MesGanancia", ganancia.MesGanancia);
                        cmd.Parameters.AddWithValue("@AñoGanancia", ganancia.AñoGanancia);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la ganancia: {ex.Message}");
            }
        }

        public void BuscarGanancia(Ganancia ganancia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("BuscarGanancia", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MesGanancia", ganancia.MesGanancia);
                        cmd.Parameters.AddWithValue("@AñoGanancia", ganancia.AñoGanancia);
                        cmd.Parameters.AddWithValue("@IngresoMensual", ganancia.IngresoMensual);
                        cmd.Parameters.AddWithValue("@TotalGastoG", ganancia.TotalGastoG);
                        cmd.Parameters.AddWithValue("@TotalGanancia", ganancia.TotalGanancia);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Console.WriteLine($"La ganancia existe.");

                                while (reader.Read())
                                {
                                    Ganancia ganancia1 = new Ganancia
                                    {
                                        MesGanancia = Convert.ToInt32(reader["MesGanancia"]),
                                        AñoGanancia = Convert.ToInt32(reader["AñoGanancia"]),
                                        IngresoMensual = Convert.ToDecimal(reader["IngresoMensual"]),
                                        TotalGastoG = Convert.ToDecimal(reader["TotalGastoG"]),
                                        TotalGanancia = Convert.ToDecimal(reader["TotalGanancia"])
                                    };

                                };
                                
                            }
                            else
                            {
                                Console.WriteLine($"La ganancia no existe.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar la ganancia: {ex.Message}");
            }
        }
    }
}
