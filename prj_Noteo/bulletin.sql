-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 11 Octobre 2019 à 10:07
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `bulletin`
--

-- --------------------------------------------------------

--
-- Structure de la table `matiere`
--

CREATE TABLE IF NOT EXISTS `matiere` (
  `idMatiere` int(5) NOT NULL,
  `libelle` varchar(255) NOT NULL,
  `NomProf` varchar(255) NOT NULL,
  PRIMARY KEY (`idMatiere`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `matiere`
--

INSERT INTO `matiere` (`idMatiere`, `libelle`, `NomProf`) VALUES
(1, 'Anglais', 'Courageux'),
(2, 'Art Plastique', 'De Smyter'),
(3, 'EPS', 'Carzon'),
(4, 'Espagnol', 'Theodor'),
(5, 'Francais', 'Giguelle'),
(6, 'Histoire', 'Allain'),
(7, 'Latin', 'giguelle'),
(8, 'Mathématiques', 'Diler'),
(9, 'Musique', 'Alexandre'),
(10, 'Physique/chimie', 'Garrido'),
(11, 'SVT', 'Grarre'),
(12, 'Technologie', 'Dusanter');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
