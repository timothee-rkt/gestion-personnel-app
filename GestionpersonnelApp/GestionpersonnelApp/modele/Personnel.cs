using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionpersonnelApp.modele

{

    /// <summary>
    /// Représente un membre du personnel.
    /// </summary>
    internal class Personnel
    {
        public int Id { get; set; }
        /// <summary>Nom du personnel</summary>
        public string Nom { get; set; }
        /// <summary>Prénom du personnel</summary>
        public string Prenom { get; set; }
        /// <summary>Adresse du personnel</summary>
        public string Adresse { get; set; }
        /// <summary>Téléphone du personnel</summary>
        public string Telephone { get; set; }
        /// <summary>Email du personnel</summary>
        public string Email { get; set; }
        /// <summary>Service du personnel</summary>
        public string Service { get; set; } 

    }
}
