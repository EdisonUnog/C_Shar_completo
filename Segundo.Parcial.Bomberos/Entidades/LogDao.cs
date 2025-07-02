using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    // limpio los parametros cuando es estarica
    public class LogDao
    {
        private SqlConnection sqlConnection;

        public LogDao()
        {
            sqlConnection = new SqlConnection("Server=.;Database=bomberos-db;Trusted_Connection=True");
        }

        // LOS PARAMETROS LOS LIMPIO CUANDO ES ESTATUCA
        public void InsertarLog(string mensaje)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO dbo.log (entrada, alumno) VALUES(@mensaje, 'Edison Uñog')", sqlConnection);
                command.Parameters.AddWithValue("@mensaje", mensaje);
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        public string LeerLog()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT entrada FROM dbo.log", sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                StringBuilder sb = new();
                if (reader.Read())
                {
                    sb.Append(reader.GetSqlString(0));  //reader["entrada"].ToString()
                }
                return sb.ToString();
            }
            finally
            {
                sqlConnection.Close();
            }
        }


    }
}
