using GestionpersonnelApp.dal;
using System;

namespace GestionpersonnelApp.Controller
{
    internal class Authcontroller
    {
        public static bool SeConnecter(string login, string motDePasse, out string message)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(motDePasse))
            {
                message = "Tous les champs ne sont pas remplis...";
                return false;
            }

            if (ConnexionDAL.AuthentifierResponsable(login, motDePasse))
            {
                message = "Connexion réussie.";
                return true;
            }
            else
            {
                message = "Identifiants incorrects";
                return false;
            }
        }
    }
}