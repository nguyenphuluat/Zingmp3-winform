-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.35-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema zingmp3_data
--

CREATE DATABASE IF NOT EXISTS zingmp3_data;
USE zingmp3_data;

--
-- Definition of table `tblcategory`
--

DROP TABLE IF EXISTS `tblcategory`;
CREATE TABLE `tblcategory` (
  `category_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `category_name` varchar(45) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategory`
--

/*!40000 ALTER TABLE `tblcategory` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblcategory` ENABLE KEYS */;


--
-- Definition of table `tblsing`
--

DROP TABLE IF EXISTS `tblsing`;
CREATE TABLE `tblsing` (
  `sing_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `sing_category_id` int(10) unsigned NOT NULL,
  `sing_name` varchar(45) NOT NULL,
  `sing_author` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `sing_singer` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `sing_listened` int(10) unsigned DEFAULT '0',
  `sing_created_date` varchar(45) DEFAULT NULL,
  `sing_focus` tinyint(1) DEFAULT NULL,
  `sing_content` text,
  `sing_path_mp3` varchar(45) NOT NULL,
  `sing_time` int(10) unsigned DEFAULT NULL,
  `sing_dowloaded` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`sing_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsing`
--

/*!40000 ALTER TABLE `tblsing` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblsing` ENABLE KEYS */;


--
-- Definition of table `tbluser`
--

DROP TABLE IF EXISTS `tbluser`;
CREATE TABLE `tbluser` (
  `user_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) NOT NULL,
  `user_pass` varchar(45) NOT NULL,
  `user_fullname` varchar(45) DEFAULT NULL,
  `user_address` varchar(45) CHARACTER SET utf8 NOT NULL,
  `user_phone` varchar(45) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
