using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionpersonnelApp.dal
{
    internal class ConnexionDAL
    {

        private static string connectionString = "server=localhost;user=admin_mtk86;password=Ai98wj76sd45&*;database=mediateck86;";

        public static string GetConnectionString() 
        {
            return connectionString;
        }
    }
}

