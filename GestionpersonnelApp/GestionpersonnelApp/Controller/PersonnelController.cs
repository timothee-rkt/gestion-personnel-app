using System;
using System.Collections.Generic;
using GestionpersonnelApp.dal;
using GestionpersonnelApp.modele;

namespace GestionpersonnelApp.Controller
{
    /// <summary>
    /// Contrôleur pour la gestion des membres du personnel.
    /// </summary>
    public class PersonnelController
    {
        /// <summary>
        /// Ajoute un membre du personnel.
        /// </summary>
        /// <param name="nom">Nom du personnel.</param>
        /// <param name="prenom">Prénom du personnel.</param>
        /// <param name="adresse">Adresse du personnel.</param>
        /// <param name="telephone">Téléphone du personnel.</param>
        /// <param name="email">Email du personnel.</param>
        /// <param name="idService">Identifiant du service.</param>
        /// <param name="message">Message de retour.</param>
        /// <returns>True si l'ajout a réussi, sinon False.</returns>
        public static bool Ajouter(string nom, string prenom, string adresse, string telephone, string email, int idService, out string message)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(adresse) ||
                string.IsNullOrWhiteSpace(telephone) || string.IsNullOrWhiteSpace(email))
            {
                message = "Tous les champs doivent être remplis.";
                return false;
            }
            Personnel p = new Personnel(nom, prenom, adresse, telephone, email, idService);
            bool success = ConnexionDAL.AjouterPersonnel(p);
            message = success ? "Ajout effectué avec succès." : "Erreur lors de l’ajout.";
            return success;
        }

        /// <summary>
        /// Modifie un membre du personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel.</param>
        /// <param name="nom">Nom du personnel.</param>
        /// <param name="prenom">Prénom du personnel.</param>
        /// <param name="adresse">Adresse du personnel.</param>
        /// <param name="telephone">Téléphone du personnel.</param>
        /// <param name="email">Email du personnel.</param>
        /// <param name="idService">Identifiant du service.</param>
        /// <param name="message">Message de retour.</param>
        /// <returns>True si la modification a réussi, sinon False.</returns>
        public static bool Modifier(int idPersonnel, string nom, string prenom, string adresse, string telephone, string email, int idService, out string message)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(adresse) ||
                string.IsNullOrWhiteSpace(telephone) || string.IsNullOrWhiteSpace(email))
            {
                message = "Tous les champs doivent être remplis.";
                return false;
            }
            Personnel p = new Personnel(nom, prenom, adresse, telephone, email, idService)
            {
                IdPersonnel = idPersonnel
            };
            bool success = ConnexionDAL.ModifierPersonnel(p);
            message = success ? "Modification effectuée avec succès." : "Erreur lors de la modification.";
            return success;
        }

        /// <summary>
        /// Supprime un membre du personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel à supprimer.</param>
        /// <param name="message">Message de retour.</param>
        /// <returns>True si la suppression a réussi, sinon False.</returns>
        public static bool Supprimer(int idPersonnel, out string message)
        {
            bool success = ConnexionDAL.SupprimerPersonnel(idPersonnel);
            message = success ? "Suppression effectuée avec succès." : "Erreur lors de la suppression.";
            return success;
        }


        /// <summary>
        /// Récupère la liste de tous les membres du personnel.
        /// </summary>
        /// <returns>Liste des membres du personnel.</returns>
        public static List<Personnel> ObtenirTous()
        {
            return ConnexionDAL.GetAllPersonnels();
        }

        /// <summary>
        /// Récupère la liste des services.
        /// </summary>
        /// <returns>Dictionnaire des services (id, nom).</returns>
        public static Dictionary<int, string> ObtenirServices()
        {
            return ConnexionDAL.GetServices();
        }
    }
}