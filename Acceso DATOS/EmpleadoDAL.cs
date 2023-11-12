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
    public class EmpleadoDAL : ConexionBD
    {
        public void InsertarEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertarEmpleado", connection))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                        cmd.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                        cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("@SalarioBase", empleado.SalarioBase);
                        cmd.Parameters.AddWithValue("@Bonificacion", empleado.Bonifiacion);
                        cmd.Parameters.AddWithValue("@MesE", empleado.MesE);
                        cmd.Parameters.AddWithValue("@AñoE", empleado.AñoE);
                        cmd.Parameters.AddWithValue("@SalarioTotal", empleado.SalarioTotal);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar empleado: {ex.Message}");
            }
        }

        // Método para eliminar un empleado por identificación
        public void EliminarEmpleadoPorIdentificacion(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("EliminarEmpleadoPorIdentificacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar empleado: {ex.Message}");
            }
        }

        // Método para actualizar un empleado
        public void ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarEmpleado", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                        cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("@SalarioBase", empleado.SalarioBase);
                        cmd.Parameters.AddWithValue("@Bonificacion", empleado.Bonifiacion);
                        cmd.Parameters.AddWithValue("@MesE", empleado.MesE);
                        cmd.Parameters.AddWithValue("@AñoE", empleado.AñoE);
                        cmd.Parameters.AddWithValue("@SalarioTotal", empleado.SalarioTotal);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar empleado: {ex.Message}");
            }
        }

        // Método para buscar un empleado por nombre, correo, identificación o teléfono
        public DataTable BuscarEmpleado(Empleado empleado)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("BuscarEmpleado", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                        cmd.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                        cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar empleado: {ex.Message}");
            }

            return dataTable;
        }


    }
}
