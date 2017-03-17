CREATE DATABASE  IF NOT EXISTS `premiere` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `premiere`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: premiere
-- ------------------------------------------------------
-- Server version	5.7.11-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cells`
--

DROP TABLE IF EXISTS `cells`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cells` (
  `CELL_NUM` int(11) NOT NULL,
  `STATE` char(5) NOT NULL,
  `INMATE_NUM` int(11) DEFAULT NULL,
  PRIMARY KEY (`CELL_NUM`),
  KEY `INMATE_NUM` (`INMATE_NUM`),
  CONSTRAINT `cells_ibfk_1` FOREIGN KEY (`INMATE_NUM`) REFERENCES `prisoners` (`PRISONERS_NUM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cells`
--

LOCK TABLES `cells` WRITE;
/*!40000 ALTER TABLE `cells` DISABLE KEYS */;
INSERT INTO `cells` VALUES (1,'OPEN',148),(2,'OPEN',213),(3,'OPEN',282),(4,'OPEN',321),(5,'OPEN',356),(6,'OPEN',408),(7,'OPEN',462),(8,'OPEN',524),(9,'OPEN',608),(10,'OPEN',687),(11,'OPEN',725),(12,'OPEN',842),(13,'OPEN',NULL),(14,'OPEN',NULL),(15,'OPEN',NULL),(16,'OPEN',NULL),(17,'OPEN',NULL);
/*!40000 ALTER TABLE `cells` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prisoners`
--

DROP TABLE IF EXISTS `prisoners`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prisoners` (
  `PRISONERS_NUM` int(11) NOT NULL,
  `PRISONERS_LNAME` varchar(20) NOT NULL,
  `PRISONERS_FNAME` varchar(20) DEFAULT NULL,
  `GENDER` varchar(20) DEFAULT NULL,
  `RACE` varchar(20) DEFAULT NULL,
  `WEIGHT` varchar(3) DEFAULT NULL,
  `HEIGHT` varchar(4) DEFAULT NULL,
  `DOB` varchar(23) DEFAULT NULL,
  `SENTENCE_TIME` varchar(20) DEFAULT NULL,
  `PRISONERS_CELL` varchar(4) DEFAULT NULL,
  `THREAT_LEVEL` varchar(4) DEFAULT NULL,
  PRIMARY KEY (`PRISONERS_NUM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prisoners`
--

LOCK TABLES `prisoners` WRITE;
/*!40000 ALTER TABLE `prisoners` DISABLE KEYS */;
INSERT INTO `prisoners` VALUES (123,'sylver','jhon','Male','BLACK','143','63','12/31/2000','5','1','2'),(148,'Jones','Chris','MALE','WHITE','123','57','12/30/1990','65','2','3'),(213,'wsdef','cchrris','Male','HISPANIC ','143','54','12/31/2000','4','3',''),(282,'James','Mathew','MALE','WHITE','111','52','12/31/2000','43','4','2'),(321,'LENNON','JHON','Male','BLACK','143','51','12-31-1990','2','5',''),(356,'Ferguson','Joe','MALE','BLACK','172','52','12-31-1990','57','6','1'),(408,'Anderson','Thomas','MALE','BLACK','173','57','12-31-1990','52','7','2'),(462,'Barga','Drake','MALE','HISPANIC','156','67','12-31-1990','34','8','3'),(524,'Kline','Louis','MALE','BLACK','152','43','12-31-1990','12','9','1'),(608,'Johnson','Mark','MALE','WHITE','153','52','12-31-1990','12','10','1'),(687,'Gomez','Tom','MALE','HISPANIC','156','72','12-31-1990','28','11','1'),(725,'Deerfield','Bill','MALE','WHITE','145','52','12-31-1990','24','12','3'),(842,'Dukes','Richard','MALE','WHITE','123','42','12-31-1990','82','13','2');
/*!40000 ALTER TABLE `prisoners` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `STAFF_ID` int(11) NOT NULL,
  `FIRSTNAME` varchar(45) DEFAULT NULL,
  `LASTNAME` varchar(45) DEFAULT NULL,
  `POSITION` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`STAFF_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (123,'JHON','KHAN','OFFDUTY'),(243,'MIKE','KHAN','ONDUTY'),(245,'PETER','KHAN','ONDUTY'),(322,'JUKIO','EVITA','OFFDUTY'),(622,'TUBE','LAN','OFFDUTY');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `USER_NUM` char(15) NOT NULL,
  `PASSWORD` char(15) DEFAULT NULL,
  `FIRST_NAME` char(15) DEFAULT NULL,
  `LAST_NAME` char(15) DEFAULT NULL,
  PRIMARY KEY (`USER_NUM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('cffr90','janelle1','chris','fajardo'),('Hull35','Hull35','Richard','Hull'),('Kaiser20','Kaiser20','Valerie','Kaiser'),('Perez65','Perez65','Juan','Perez');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-21  7:45:00
