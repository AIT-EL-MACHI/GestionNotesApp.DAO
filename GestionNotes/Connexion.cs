using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes
{
    public static class Connexion
    {
        private static string connectionString = "Server=localhost;Database=GestionNotes;Trusted_Connection=True;";
        public static SqlConnection GetConnection() => new SqlConnection(connectionString);
    }
}
