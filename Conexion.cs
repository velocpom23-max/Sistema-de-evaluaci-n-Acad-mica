using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Data.SqlClient;

namespace SistemaEvaluacionesAcademicas
{
    public class Conexion
    {
        private static string cadenaConexion =
            @"Server=.\SQLEXPRESS;Database=SistemaEvaluaciones;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

