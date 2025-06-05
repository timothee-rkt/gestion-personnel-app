using GestionpersonnelApp.dal;
using GestionpersonnelApp.modele;
using System.Collections.Generic;

namespace GestionpersonnelApp.Controller
{
    /// <summary>
    /// Contrôleur pour la gestion des motifs d'absence.
    /// </summary>
    internal class MotifController
    {
        /// <summary>
        /// Récupère la liste de tous les motifs d'absence.
        /// </summary>
        /// <returns>Liste des motifs.</returns>
        public static List<Motif> ObtenirTous()
        {
            return ConnexionDAL.GetAllMotifs();
        }
    }
}
