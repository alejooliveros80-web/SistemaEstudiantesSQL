using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPractico_Csharp
{
    public class Conexion
    {
        // Se coloca LENOVO2026\\SQLEXPRESS con doble barra y taller_practico como base de datos
        private static string cadenaConexion = "Server=LENOVO2026\\SQLEXPRESS;Database=taller_practico;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}