using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionpersonnelApp.modele
{
    /// <summary>
    /// Représente un responsable.
    /// </summary>
    internal class Responsable
    {
            /// <summary>
            /// Identifiant unique du responsable.
            /// </summary>
            public int Id { get; set; }

         /// <summary>
        /// Identifiant de connexion du responsable.
        /// /// </summary>
        public string Login { get; set; }


            /// <summary>
            /// Mot de passe du responsable.
            /// </summary>
            public string Pwd { get; set; }


    }
}

