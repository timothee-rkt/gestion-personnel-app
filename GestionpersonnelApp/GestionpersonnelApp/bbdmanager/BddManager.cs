using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionpersonnelApp.bbdmanager
{
    internal class BddManager
    {
            private static MySqlConnection connection;

            private BddManager() { }

            public static MySqlConnection GetConnection()
            {
                if (connection == null) 
                {
                    string connectionString = "server=localhost;user=admin_mtk86;password=Ai98wj76sd45&*;database=mediateck86;";
                    connection = new MySqlConnection(connectionString);
                }
                return connection;
            }
    }
}
