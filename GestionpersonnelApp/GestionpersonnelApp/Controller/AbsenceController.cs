using System;
using GestionpersonnelApp.dal;
using GestionpersonnelApp.modele;

namespace GestionpersonnelApp.Controller
{
    /// <summary>
    /// Contrôleur pour la gestion des absences.
    /// </summary>
    public static class AbsenceController
    {
        /// <summary>
        /// Ajoute une nouvelle absence.
        /// </summary>
        /// <param name="dateDebut">Date de début de l'absence.</param>
        /// <param name="dateFin">Date de fin de l'absence.</param>
        /// <param name="idMotif">Identifiant du motif de l'absence.</param>
        /// <param name="idPersonnel">Identifiant du personnel concerné.</param>
        /// <param name="message">Message de retour indiquant le succès ou l'échec de l'opération.</param>
        /// <returns>True si l'ajout a réussi, sinon False.</returns>
        public static bool Ajouter(DateTime dateDebut, DateTime dateFin, int idMotif, int idPersonnel, out string message)
        {
            if (dateFin < dateDebut)
            {
                message = "La date de fin doit être postérieure à la date de début.";
                return false;
            }

            Absence a = new Absence(idPersonnel, dateDebut, dateFin, idMotif)
            {
                DateDebut = dateDebut,
                DateFin = dateFin,
                IdMotif = idMotif,
                IdPersonnel = idPersonnel
            };

            bool success = ConnexionDAL.AjouterAbsence(a);
            message = success ? "Absence ajoutée avec succès." : "Erreur lors de l'ajout de l'absence.";
            return success;
        }

        /// <summary>
        /// Modifie une absence existante.
        /// </summary>
        /// <param name="ancienne">L'absence à modifier.</param>
        /// <param name="dateDebut">Nouvelle date de début de l'absence.</param>
        /// <param name="dateFin">Nouvelle date de fin de l'absence.</param>
        /// <param name="idMotif">Nouveau motif de l'absence.</param>
        /// <param name="idPersonnel">Identifiant du personnel concerné.</param>
        /// <param name="message">Message de retour indiquant le succès ou l'échec de l'opération.</param>
        /// <returns>True si la modification a réussi, sinon False.</returns>
        public static bool Modifier (Absence ancienne, DateTime dateDebut, DateTime dateFin, int idMotif, int idPersonnel, out string message)
        {
            if (dateFin < dateDebut)
            {
                message = "La date de fin doit être postérieure à la date de début.";
                return false;
            }

            Absence nouvelle = new Absence(idPersonnel, dateDebut, dateFin, idMotif)        
            {
                DateDebut = dateDebut,
                DateFin = dateFin,
                IdMotif = idMotif,
                IdPersonnel = idPersonnel
            };

            bool success = ConnexionDAL.ModifierAbsence(ancienne, nouvelle);
            message = success ? "Absence modifiée avec succès." : "Erreur lors de la modification de l'absence.";
            return success;
        }
        public static bool Supprimer (Absence absence, out string message)
        {
            if (absence == null)
            {
                message = "Aucune absence sélectionnée.";
                return false;
            }

            bool success = ConnexionDAL.SupprimerAbsence(absence);
            message = success ? "Suppression effectuée avec succès." : "Erreur lors de la suppression de l'absence.";
            return success;
        }
    }
}