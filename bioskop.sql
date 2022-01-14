<<<<<<< HEAD
-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.22-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for bioskop
DROP DATABASE IF EXISTS `bioskop`;
CREATE DATABASE IF NOT EXISTS `bioskop` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `bioskop`;

-- Dumping structure for table bioskop.film
DROP TABLE IF EXISTS `film`;
CREATE TABLE IF NOT EXISTS `film` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `film` varchar(255) NOT NULL,
  `genre` varchar(255) NOT NULL,
  `deskripsi` text NOT NULL,
  `director` varchar(255) NOT NULL,
  `duration` time NOT NULL,
  `date_release` date NOT NULL,
  `bahasa` varchar(255) NOT NULL,
  `harga_film` int(11) NOT NULL,
  `foto` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.film: ~1 rows (approximately)
/*!40000 ALTER TABLE `film` DISABLE KEYS */;
REPLACE INTO `film` (`id`, `film`, `genre`, `deskripsi`, `director`, `duration`, `date_release`, `bahasa`, `harga_film`, `foto`) VALUES
	(1, 'Deadly Silence', 'Horror', 'sample', 'Kelbioskop', '09:37:12', '2021-12-31', 'Indonesia', 50000, '');
/*!40000 ALTER TABLE `film` ENABLE KEYS */;

-- Dumping structure for table bioskop.jadwal_tayang
DROP TABLE IF EXISTS `jadwal_tayang`;
CREATE TABLE IF NOT EXISTS `jadwal_tayang` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_film` int(11) NOT NULL,
  `id_studio` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `waktu_mulai` time NOT NULL,
  `waktu_selesai` time NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_id_film` (`id_film`),
  KEY `FK_id_studio` (`id_studio`),
  CONSTRAINT `FK_id_film` FOREIGN KEY (`id_film`) REFERENCES `film` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_id_studio` FOREIGN KEY (`id_studio`) REFERENCES `studio` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.jadwal_tayang: ~1 rows (approximately)
/*!40000 ALTER TABLE `jadwal_tayang` DISABLE KEYS */;
REPLACE INTO `jadwal_tayang` (`id`, `id_film`, `id_studio`, `tanggal`, `waktu_mulai`, `waktu_selesai`) VALUES
	(4, 1, 1, '2021-12-31', '09:38:31', '09:38:31');
/*!40000 ALTER TABLE `jadwal_tayang` ENABLE KEYS */;

-- Dumping structure for table bioskop.studio
DROP TABLE IF EXISTS `studio`;
CREATE TABLE IF NOT EXISTS `studio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kapasitas` int(11) NOT NULL,
  `harga_kursi` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.studio: ~1 rows (approximately)
/*!40000 ALTER TABLE `studio` DISABLE KEYS */;
REPLACE INTO `studio` (`id`, `kapasitas`, `harga_kursi`) VALUES
	(1, 50, 50000);
/*!40000 ALTER TABLE `studio` ENABLE KEYS */;

-- Dumping structure for table bioskop.tiket
DROP TABLE IF EXISTS `tiket`;
CREATE TABLE IF NOT EXISTS `tiket` (
  `id` int(11) NOT NULL,
  `id_jadwal_tayang` int(11) NOT NULL,
  `total_harga` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_id_jadwal_tayang` (`id_jadwal_tayang`),
  CONSTRAINT `FK_id_jadwal_tayang` FOREIGN KEY (`id_jadwal_tayang`) REFERENCES `jadwal_tayang` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.tiket: ~0 rows (approximately)
/*!40000 ALTER TABLE `tiket` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiket` ENABLE KEYS */;

-- Dumping structure for table bioskop.user
DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) NOT NULL DEFAULT '',
  `email` varchar(255) NOT NULL DEFAULT '',
  `password` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.user: ~0 rows (approximately)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
=======
-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.22-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for bioskop
DROP DATABASE IF EXISTS `bioskop`;
CREATE DATABASE IF NOT EXISTS `bioskop` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `bioskop`;

-- Dumping structure for table bioskop.film
DROP TABLE IF EXISTS `film`;
CREATE TABLE IF NOT EXISTS `film` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `film` varchar(255) NOT NULL,
  `genre` varchar(255) NOT NULL,
  `deskripsi` text NOT NULL,
  `director` varchar(255) NOT NULL,
  `duration` time NOT NULL,
  `date_release` date NOT NULL,
  `bahasa` varchar(255) NOT NULL,
  `harga_film` int(11) NOT NULL,
  `foto` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.film: ~1 rows (approximately)
/*!40000 ALTER TABLE `film` DISABLE KEYS */;
REPLACE INTO `film` (`id`, `film`, `genre`, `deskripsi`, `director`, `duration`, `date_release`, `bahasa`, `harga_film`, `foto`) VALUES
	(1, 'Deadly Silence', 'Horror', 'sample', 'Kelbioskop', '09:37:12', '2021-12-31', 'Indonesia', 50000, '');
/*!40000 ALTER TABLE `film` ENABLE KEYS */;

-- Dumping structure for table bioskop.jadwal_tayang
DROP TABLE IF EXISTS `jadwal_tayang`;
CREATE TABLE IF NOT EXISTS `jadwal_tayang` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_film` int(11) NOT NULL,
  `id_studio` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `waktu_mulai` time NOT NULL,
  `waktu_selesai` time NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_id_film` (`id_film`),
  KEY `FK_id_studio` (`id_studio`),
  CONSTRAINT `FK_id_film` FOREIGN KEY (`id_film`) REFERENCES `film` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_id_studio` FOREIGN KEY (`id_studio`) REFERENCES `studio` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.jadwal_tayang: ~1 rows (approximately)
/*!40000 ALTER TABLE `jadwal_tayang` DISABLE KEYS */;
REPLACE INTO `jadwal_tayang` (`id`, `id_film`, `id_studio`, `tanggal`, `waktu_mulai`, `waktu_selesai`) VALUES
	(4, 1, 1, '2021-12-31', '09:38:31', '09:38:31');
/*!40000 ALTER TABLE `jadwal_tayang` ENABLE KEYS */;

-- Dumping structure for table bioskop.studio
DROP TABLE IF EXISTS `studio`;
CREATE TABLE IF NOT EXISTS `studio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kapasitas` int(11) NOT NULL,
  `harga_kursi` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.studio: ~1 rows (approximately)
/*!40000 ALTER TABLE `studio` DISABLE KEYS */;
REPLACE INTO `studio` (`id`, `kapasitas`, `harga_kursi`) VALUES
	(1, 50, 50000);
/*!40000 ALTER TABLE `studio` ENABLE KEYS */;

-- Dumping structure for table bioskop.tiket
DROP TABLE IF EXISTS `tiket`;
CREATE TABLE IF NOT EXISTS `tiket` (
  `id` int(11) NOT NULL,
  `id_jadwal_tayang` int(11) NOT NULL,
  `total_harga` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_id_jadwal_tayang` (`id_jadwal_tayang`),
  CONSTRAINT `FK_id_jadwal_tayang` FOREIGN KEY (`id_jadwal_tayang`) REFERENCES `jadwal_tayang` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.tiket: ~0 rows (approximately)
/*!40000 ALTER TABLE `tiket` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiket` ENABLE KEYS */;

-- Dumping structure for table bioskop.user
DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) NOT NULL DEFAULT '',
  `email` varchar(255) NOT NULL DEFAULT '',
  `password` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table bioskop.user: ~0 rows (approximately)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
>>>>>>> 764aee4f91dd456233dce9d2dbd257109fa93038
