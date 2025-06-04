using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionpersonnelApp.modele
{

    /// <summary>
    /// Représente une absence d'un membre du personnel.
    /// </summary>
    internal class Absence
    {
        /// <summary>
        /// Identifiant unique de l'absence.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identifiant du personnel concerné par l'absence.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Date de début de l'absence.
        /// </summary>
        public DateTime DateDeDebut { get; set; }

        /// <summary>
        /// Date de fin de l'absence.
        /// </summary>
        public DateTime DateDeFin { get; set; }

        /// <summary>
        /// Identifiant du motif de l'absence.
        /// </summary>
        public int IdMotif { get; set; }

    }
}
