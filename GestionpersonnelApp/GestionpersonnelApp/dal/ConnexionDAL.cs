using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using GestionpersonnelApp.modele;

namespace GestionpersonnelApp.dal
{
    /// <summary>
    /// Fournit les méthodes d'accès aux données pour la gestion du personnel, des absences, des services et des motifs.
    /// </summary>
    internal class ConnexionDAL
    {
        private static string connectionString = "server=localhost;user=root;password=;database=mediatek86;";

        /// <summary>
        /// Retourne la chaîne de connexion à la base de données.
        /// </summary>
        /// <returns>La chaîne de connexion MySQL.</returns>
        public static string GetConnectionString() => connectionString;

        /// <summary>
        /// Authentifie un responsable à partir de son login et mot de passe.
        /// </summary>
        /// <param name="login">Le login du responsable.</param>
        /// <param name="password">Le mot de passe du responsable.</param>
        /// <returns>True si l'authentification réussit, sinon False.</returns>
        public static bool AuthentifierResponsable(string login, string password)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM responsable WHERE login = @login AND password = @password";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Ajoute un membre du personnel à la base de données.
        /// </summary>
        /// <param name="p">L'objet Personnel à ajouter.</param>
        /// <returns>True si l'ajout a réussi, sinon False.</returns>
        public static bool AjouterPersonnel(Personnel p)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = @"INSERT INTO personnel (nom, prenom, adresse, telephone, email, id_service)
                                 VALUES (@nom, @prenom, @adresse, @telephone, @email, @idService)";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", p.Nom);
                cmd.Parameters.AddWithValue("@prenom", p.Prenom);
                cmd.Parameters.AddWithValue("@adresse", p.Adresse);
                cmd.Parameters.AddWithValue("@telephone", p.Telephone);
                cmd.Parameters.AddWithValue("@email", p.Email);
                cmd.Parameters.AddWithValue("@idService", p.IdService);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Modifie les informations d'un membre du personnel.
        /// </summary>
        /// <param name="p">L'objet Personnel contenant les nouvelles informations.</param>
        /// <returns>True si la modification a réussi, sinon False.</returns>
        public static bool ModifierPersonnel(Personnel p)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = @"UPDATE personnel SET nom = @nom, prenom = @prenom, adresse = @adresse, telephone = @telephone, email = @email, id_service = @idService
                                 WHERE idpersonnel = @id";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", p.Nom);
                cmd.Parameters.AddWithValue("@prenom", p.Prenom);
                cmd.Parameters.AddWithValue("@adresse", p.Adresse);
                cmd.Parameters.AddWithValue("@telephone", p.Telephone);
                cmd.Parameters.AddWithValue("@email", p.Email);
                cmd.Parameters.AddWithValue("@idService", p.IdService);
                cmd.Parameters.AddWithValue("@id", p.IdPersonnel);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Supprime un membre du personnel de la base de données.
        /// </summary>
        /// <param name="idPersonnel">L'identifiant du personnel à supprimer.</param>
        /// <returns>True si la suppression a réussi, sinon False.</returns>
        public static bool SupprimerPersonnel(int idPersonnel)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "DELETE FROM personnel WHERE idpersonnel = @id";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idPersonnel);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Récupère la liste des absences d'un membre du personnel.
        /// </summary>
        /// <param name="idPersonnel">L'identifiant du personnel.</param>
        /// <returns>Une liste d'objets Absence.</returns>
        public static List<Absence> GetAbsencesByPersonnel(int idPersonnel)
        {
            List<Absence> absences = new();
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT datedebut, datefin, idmotif, idpersonnel FROM absence WHERE idpersonnel = @id";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idPersonnel);
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    absences.Add(new Absence(idPersonnel, reader.GetDateTime("datedebut"), reader.GetDateTime("datefin"), reader.GetInt32("idmotif"))
                    {
                        DateDebut = reader.GetDateTime("datedebut"),
                        DateFin = reader.GetDateTime("datefin"),
                        IdMotif = reader.GetInt32("idmotif"),
                        IdPersonnel = reader.GetInt32("idpersonnel")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
            return absences;
        }

        /// <summary>
        /// Ajoute une absence à la base de données.
        /// </summary>
        /// <param name="a">L'objet Absence à ajouter.</param>
        /// <returns>True si l'ajout a réussi, sinon False.</returns>
        public static bool AjouterAbsence(Absence a)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = @"INSERT INTO absence (datedebut, datefin, idmotif, idpersonnel)
                                 VALUES (@datedebut, @datefin, @idmotif, @idpersonnel)";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@datedebut", a.DateDebut);
                cmd.Parameters.AddWithValue("@datefin", a.DateFin);
                cmd.Parameters.AddWithValue("@idmotif", a.IdMotif);
                cmd.Parameters.AddWithValue("@idpersonnel", a.IdPersonnel);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Modifie une absence existante dans la base de données.
        /// </summary>
        /// <param name="ancienne">L'absence à modifier (ancienne valeur).</param>
        /// <param name="nouvelle">L'objet Absence contenant les nouvelles valeurs.</param>
        /// <returns>True si la modification a réussi, sinon False.</returns>
        public static bool ModifierAbsence(Absence ancienne, Absence nouvelle)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = @"UPDATE absence SET datedebut = @newDatedebut, datefin = @newDatefin, idmotif = @newIdmotif
                                 WHERE datedebut = @oldDatedebut AND datefin = @oldDatefin AND idmotif = @oldIdmotif AND idpersonnel = @idpersonnel";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newDatedebut", nouvelle.DateDebut);
                cmd.Parameters.AddWithValue("@newDatefin", nouvelle.DateFin);
                cmd.Parameters.AddWithValue("@newIdmotif", nouvelle.IdMotif);
                cmd.Parameters.AddWithValue("@oldDatedebut", ancienne.DateDebut);
                cmd.Parameters.AddWithValue("@oldDatefin", ancienne.DateFin);
                cmd.Parameters.AddWithValue("@oldIdmotif", ancienne.IdMotif);
                cmd.Parameters.AddWithValue("@idpersonnel", ancienne.IdPersonnel);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Supprime une absence de la base de données.
        /// </summary>
        /// <param name="a">L'objet Absence à supprimer.</param>
        /// <returns>True si la suppression a réussi, sinon False.</returns>
        public static bool SupprimerAbsence(Absence a)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = @"DELETE FROM absence WHERE datedebut = @datedebut AND datefin = @datefin AND idmotif = @idmotif AND idpersonnel = @idpersonnel";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@datedebut", a.DateDebut);
                cmd.Parameters.AddWithValue("@datefin", a.DateFin);
                cmd.Parameters.AddWithValue("@idmotif", a.IdMotif);
                cmd.Parameters.AddWithValue("@idpersonnel", a.IdPersonnel);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Récupère la liste des services.
        /// </summary>
        /// <returns>Un dictionnaire associant l'identifiant du service à son nom.</returns>
        public static Dictionary<int, string> GetServices()
        {
            Dictionary<int, string> services = new();
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT idservice, nom FROM services";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    services.Add(reader.GetInt32("idService"), reader.GetString("nom"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
            return services;
        }

        /// <summary>
        /// Récupère la liste de tous les membres du personnel.
        /// </summary>
        /// <returns>Une liste d'objets Personnel.</returns>
        public static List<Personnel> GetAllPersonnels()
        {
            List<Personnel> personnels = new();
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT idpersonnel, nom, prenom, adresse, telephone, email, id_service FROM personnel";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    personnels.Add(new Personnel(
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetString("adresse"),
                        reader.GetString("telephone"),
                        reader.GetString("email"),
                        reader.GetInt32("id_service")
                    )
                    {
                        IdPersonnel = reader.GetInt32("idpersonnel")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
            return personnels;
        }

        /// <summary>
        /// Récupère la liste de tous les motifs.
        /// </summary>
        /// <returns>Une liste d'objets Motif.</returns>
        public static List<Motif> GetAllMotifs()
        {
            List<Motif> motifs = new();
            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT idmotif, libelle FROM motif";
                using MySqlCommand cmd = new MySqlCommand(query, conn);
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    motifs.Add(new Motif
                    {
                        Idmotif = reader.GetInt32("idmotif"),
                        Libelle = reader.GetString("libelle")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
            return motifs;
        }
    }
}