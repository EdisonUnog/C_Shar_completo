using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AccesoDatos
    {
        private static string cadenaConexion;
        private static SqlCommand command;
        private static SqlConnection conexion;

        static AccesoDatos()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=20240701-SP;Integrated Security=True";
            command = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            command.Connection = conexion;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void Open()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
        }

        public static void Close()
        {
            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }


        public static void ActualizarSerie(Serie item)
        {
            string nombre = "Edison UñogA323";
            try
            {
                Open();
                command.Parameters.Clear();
                command.CommandText = $"UPDATE series SET alumno = @alumno WHERE nombre = @nombre";
                command.Parameters.AddWithValue("@alumno", nombre);
                command.Parameters.AddWithValue("@nombre", item.Nombre);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger.Log($"Error encontrado: {ex.Message}");
                throw new BackLogException("Algo salio mal", ex);
            }
            finally { Close(); }
        }


        public static List<Serie> ObtenerBacklog()
        {
            List<Serie> lista = new List<Serie>();
            try
            {
                Open();
                //command.CommandText = "SELECT nombre, genero FROM series";
                command.CommandText = "SELECT * FROM series";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Serie(reader["nombre"].ToString(), reader["genero"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Error encontrado: {ex.Message}");
                throw new BackLogException("Algo salio mal", ex);
            }
            finally { Close(); }
            return lista;
        }



    }
}
