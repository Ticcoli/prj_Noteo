-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 11 Octobre 2019 à 09:55
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
-- Structure de la table `anneee`
--

CREATE TABLE IF NOT EXISTS `anneee` (
  `id` int(5) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `anneee`
--

INSERT INTO `anneee` (`id`) VALUES
(1),
(2),
(3);

-- --------------------------------------------------------

--
-- Structure de la table `eleve`
--

CREATE TABLE IF NOT EXISTS `eleve` (
  `ideleve` int(5) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `classe` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`ideleve`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `eleve`
--

INSERT INTO `eleve` (`ideleve`, `nom`, `prenom`, `classe`, `password`) VALUES
(1, 'Quenot', 'Maël', 'BTS2', '721a9b52bfceacc503c056e3b9b93cfa'),
(2, 'Ballot', 'dimitry', 'BTS2', '721a9b52bfceacc503c056e3b9b93cfa');

-- --------------------------------------------------------

--
-- Structure de la table `matiere`
--

CREATE TABLE IF NOT EXISTS `matiere` (
  `idMatiere` int(5) NOT NULL,
  `libelle` varchar(255) NOT NULL,
  PRIMARY KEY (`idMatiere`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `matiere`
--

INSERT INTO `matiere` (`idMatiere`, `libelle`) VALUES
(1, 'Anglais'),
(2, 'Art Plastique'),
(3, 'EPS'),
(4, 'Espagnol'),
(5, 'Francais'),
(6, 'Histoire'),
(7, 'Latin'),
(8, 'Mathématiques'),
(9, 'Musique'),
(10, 'Physique'),
(11, 'SVT'),
(12, 'Technologie');

-- --------------------------------------------------------

--
-- Structure de la table `noter`
--

CREATE TABLE IF NOT EXISTS `noter` (
  `coeff` int(2) NOT NULL,
  `note` int(5) NOT NULL,
  `ideleveNote` int(5) NOT NULL,
  `idMatiereNote` int(5) NOT NULL,
  `idTrimestreNote` int(5) NOT NULL,
  `idAneeNote` int(5) NOT NULL,
  PRIMARY KEY (`ideleveNote`,`idMatiereNote`,`idTrimestreNote`,`idAneeNote`),
  KEY `ideleveNote` (`ideleveNote`),
  KEY `idMatiereNote` (`idMatiereNote`),
  KEY `idTrimestreNote/annee` (`idTrimestreNote`,`idAneeNote`),
  KEY `idAneeNote` (`idAneeNote`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `noter`
--

INSERT INTO `noter` (`coeff`, `note`, `ideleveNote`, `idMatiereNote`, `idTrimestreNote`, `idAneeNote`) VALUES
(1, 12, 1, 6, 1, 1),
(2, 16, 2, 7, 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `trimestre`
--

CREATE TABLE IF NOT EXISTS `trimestre` (
  `id` int(5) NOT NULL,
  `libelle` varchar(255) NOT NULL,
  `idAnnee` int(5) NOT NULL,
  PRIMARY KEY (`id`,`idAnnee`),
  KEY `idAnnee` (`idAnnee`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `trimestre`
--

INSERT INTO `trimestre` (`id`, `libelle`, `idAnnee`) VALUES
(1, 'Trimestre 1', 1),
(2, 'trimestre 2', 1),
(3, 'Trimestre 3', 1);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `noter`
--
ALTER TABLE `noter`
  ADD CONSTRAINT `noter_ibfk_1` FOREIGN KEY (`ideleveNote`) REFERENCES `eleve` (`ideleve`),
  ADD CONSTRAINT `noter_ibfk_2` FOREIGN KEY (`idMatiereNote`) REFERENCES `matiere` (`idMatiere`),
  ADD CONSTRAINT `noter_ibfk_3` FOREIGN KEY (`idAneeNote`) REFERENCES `anneee` (`id`);

--
-- Contraintes pour la table `trimestre`
--
ALTER TABLE `trimestre`
  ADD CONSTRAINT `trimestre_ibfk_1` FOREIGN KEY (`idAnnee`) REFERENCES `anneee` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
