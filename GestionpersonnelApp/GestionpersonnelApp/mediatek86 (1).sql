-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 05 juin 2025 à 14:20
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(43, '2005-06-25 00:00:00', '0000-00-00 00:00:00', 0),
(23, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(22, '2003-10-26 00:00:00', '0000-00-00 00:00:00', 0),
(26, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(25, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(31, '2001-03-25 00:00:00', '0000-00-00 00:00:00', 0),
(26, '2012-06-24 00:00:00', '0000-00-00 00:00:00', 0),
(26, '2011-08-25 00:00:00', '0000-00-00 00:00:00', 0),
(29, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(12, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(1, '2005-06-25 00:00:00', '0000-00-00 00:00:00', 0),
(2, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(3, '2003-10-26 00:00:00', '0000-00-00 00:00:00', 0),
(4, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(5, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(6, '2001-03-25 00:00:00', '0000-00-00 00:00:00', 0),
(7, '2012-06-24 00:00:00', '0000-00-00 00:00:00', 0),
(8, '2011-08-25 00:00:00', '0000-00-00 00:00:00', 0),
(9, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(10, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(1, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(12, '2011-05-24 00:00:00', '0000-00-00 00:00:00', 0),
(13, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(14, '2004-07-26 00:00:00', '0000-00-00 00:00:00', 0),
(15, '2012-02-24 00:00:00', '0000-00-00 00:00:00', 0),
(16, '0000-00-00 00:00:00', '2002-10-25 00:00:00', 0),
(17, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(18, '2008-03-24 00:00:00', '0000-00-00 00:00:00', 0),
(19, '0000-00-00 00:00:00', '2008-10-25 00:00:00', 0),
(20, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(21, '2011-10-25 00:00:00', '2004-12-25 00:00:00', 0),
(22, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(188, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0),
(42, '2025-11-02 18:05:46', '2026-02-23 15:50:09', 0),
(9, '2024-08-07 08:56:57', '2026-04-20 14:24:33', 0),
(3, '2025-12-11 01:16:49', '2024-09-08 16:47:05', 0),
(42, '2025-09-20 15:57:15', '2026-02-09 15:51:11', 0),
(12, '2024-12-21 07:07:54', '2025-01-25 21:00:59', 0),
(47, '2025-05-26 13:22:12', '2025-01-16 01:52:35', 0),
(32, '2025-05-13 00:54:05', '2026-02-21 23:16:53', 0),
(46, '2025-11-16 22:51:56', '2025-09-03 17:56:45', 0),
(35, '2024-12-14 17:47:43', '2026-01-02 21:18:31', 0),
(42, '2025-07-16 08:34:15', '2025-01-13 00:44:43', 0),
(27, '2025-06-26 02:19:42', '2026-01-13 01:04:08', 0),
(34, '2025-05-12 08:44:54', '2025-05-20 22:39:57', 0),
(45, '2024-07-21 02:20:55', '2024-09-03 17:04:56', 0),
(23, '2024-06-11 01:22:23', '2024-12-02 06:54:56', 0),
(16, '2025-05-08 06:25:34', '2024-09-18 15:37:09', 0),
(43, '2026-04-08 00:43:26', '2025-07-08 08:16:06', 0),
(31, '2025-05-21 03:02:23', '2025-02-25 07:21:06', 0),
(26, '2025-09-01 01:05:55', '2026-01-04 03:49:49', 0),
(37, '2024-07-18 23:23:42', '2026-03-20 18:07:56', 0),
(11, '2025-10-26 19:57:55', '2025-03-08 16:30:19', 0),
(42, '2024-09-28 13:09:25', '2025-08-25 10:43:05', 0),
(4, '2025-04-26 03:47:13', '2025-01-09 06:32:39', 0),
(9, '2024-11-04 15:08:53', '2025-04-30 07:20:47', 0),
(32, '2024-06-07 11:56:51', '2025-09-14 17:44:31', 0),
(36, '2024-11-21 15:02:25', '2026-01-28 20:23:44', 0),
(4, '2024-08-26 15:52:43', '2026-02-21 10:01:25', 0),
(3, '2025-06-25 02:14:58', '2024-09-08 05:31:42', 0),
(21, '2024-11-10 00:24:11', '2025-10-04 11:19:19', 0),
(30, '2024-12-04 11:23:00', '2025-05-01 17:00:54', 0),
(21, '2025-02-26 00:41:17', '2026-01-29 07:37:07', 0),
(38, '2024-10-31 04:52:25', '2026-03-24 15:33:03', 0),
(47, '2025-01-20 06:55:06', '2024-07-19 09:47:40', 0),
(22, '2025-11-13 23:25:13', '2024-07-26 22:10:57', 0),
(7, '2024-08-31 13:58:14', '2024-06-30 22:27:41', 0),
(41, '2026-04-21 14:34:15', '2026-04-19 08:44:05', 0),
(42, '2025-12-16 11:04:12', '2026-05-13 06:38:15', 0),
(13, '2024-11-04 05:27:56', '2024-06-09 09:03:33', 0),
(24, '2024-06-20 21:01:48', '2024-07-03 08:22:37', 0),
(1, '2026-02-09 16:58:10', '2024-12-30 12:35:59', 0),
(42, '2026-04-23 17:11:31', '2024-12-14 20:58:31', 0),
(40, '2025-08-02 19:06:12', '2025-02-06 07:56:52', 0),
(15, '2025-07-20 17:39:54', '2024-09-17 04:21:11', 0),
(36, '2025-04-24 19:31:01', '2025-09-30 17:56:42', 0),
(14, '2025-07-08 05:51:38', '2025-05-06 14:48:08', 0),
(44, '2026-03-22 12:56:44', '2026-02-13 18:20:41', 0),
(45, '2024-06-23 03:44:23', '2025-11-21 22:21:14', 0),
(29, '2025-11-04 03:28:23', '2024-08-13 10:54:23', 0),
(8, '2024-10-15 20:10:54', '2024-08-09 15:13:24', 0),
(23, '2025-05-10 00:42:24', '2025-01-13 16:39:07', 0),
(48, '2025-08-18 11:25:45', '2024-07-01 06:19:59', 0);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`) VALUES
(1, 'Booker', 'Raymond', '05 73 11 12 66', 'tortor@outlook.com'),
(2, 'Dean', 'Samson', '09 72 97 82 54', 'vulputate.nisi@google.com'),
(3, 'Blanchard', 'Jerome', '06 84 65 41 43', 'curabitur.massa@google.com'),
(4, 'Rojas', 'Branden', '05 53 70 82 58', 'dictum@google.com'),
(5, 'Bruce', 'Wayne', '09 61 07 41 15', 'id.libero@google.com'),
(6, 'Bartlett', 'Olga', '08 01 02 30 31', 'a@icloud.com'),
(7, 'Romero', 'Destiny', '09 66 47 11 74', 'nam.porttitor.scelerisque@yahoo.com'),
(8, 'Vang', 'Jenette', '02 36 26 18 43', 'quisque@google.com'),
(9, 'Ingram', 'Harrison', '01 30 20 86 14', 'neque@protonmail.com'),
(10, 'Lynch', 'Gabriel', '05 68 45 89 97', 'praesent@google.com');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) DEFAULT NULL,
  `pwd` varchar(64) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', '4390fcf27704f55e33fff23de1576aefd6f3c9a40e2970a56e93a910bdf7f4d3'),
('admin', 'fe59abc73ea5c61788018a3a910c4f686debcb9e8a8189bec8cd5d8467c2569f');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, NULL),
(2, NULL),
(3, NULL),
(4, NULL),
(5, NULL),
(6, NULL);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
