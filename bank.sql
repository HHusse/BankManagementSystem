-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Nov 30, 2022 at 01:24 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bank`
--

-- --------------------------------------------------------

--
-- Table structure for table `clientii`
--

CREATE TABLE `clientii` (
  `nume` varchar(50) NOT NULL,
  `prenume` varchar(50) NOT NULL,
  `cnp` bigint(13) NOT NULL,
  `dataNasterii` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `conturibancare`
--

CREATE TABLE `conturibancare` (
  `cnp` bigint(13) NOT NULL,
  `nrCont` varchar(150) NOT NULL,
  `dataDeschiderii` varchar(50) NOT NULL,
  `moneda` varchar(50) NOT NULL,
  `sold` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `loginclient`
--

CREATE TABLE `loginclient` (
  `user` varchar(50) NOT NULL,
  `pin` int(4) NOT NULL,
  `CNP` bigint(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `operatorii`
--

CREATE TABLE `operatorii` (
  `nume` varchar(50) NOT NULL,
  `prenume` varchar(50) NOT NULL,
  `cnp` bigint(20) NOT NULL,
  `dataNasterii` varchar(50) NOT NULL,
  `user` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `valid` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tranzactii`
--

CREATE TABLE `tranzactii` (
  `cod` bigint(20) NOT NULL,
  `from` varchar(50) NOT NULL,
  `to` varchar(50) DEFAULT NULL,
  `tiptranzactie` varchar(50) NOT NULL,
  `suma` double NOT NULL,
  `moneda` varchar(50) NOT NULL,
  `data` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientii`
--
ALTER TABLE `clientii`
  ADD PRIMARY KEY (`cnp`);

--
-- Indexes for table `conturibancare`
--
ALTER TABLE `conturibancare`
  ADD PRIMARY KEY (`nrCont`),
  ADD KEY `cnp` (`cnp`);

--
-- Indexes for table `loginclient`
--
ALTER TABLE `loginclient`
  ADD PRIMARY KEY (`user`),
  ADD KEY `CNP` (`CNP`);

--
-- Indexes for table `operatorii`
--
ALTER TABLE `operatorii`
  ADD PRIMARY KEY (`cnp`);

--
-- Indexes for table `tranzactii`
--
ALTER TABLE `tranzactii`
  ADD PRIMARY KEY (`cod`),
  ADD KEY `from` (`from`),
  ADD KEY `to` (`to`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tranzactii`
--
ALTER TABLE `tranzactii`
  MODIFY `cod` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `conturibancare`
--
ALTER TABLE `conturibancare`
  ADD CONSTRAINT `conturibancare_ibfk_1` FOREIGN KEY (`cnp`) REFERENCES `clientii` (`cnp`);

--
-- Constraints for table `loginclient`
--
ALTER TABLE `loginclient`
  ADD CONSTRAINT `loginclient_ibfk_1` FOREIGN KEY (`CNP`) REFERENCES `clientii` (`cnp`);

--
-- Constraints for table `tranzactii`
--
ALTER TABLE `tranzactii`
  ADD CONSTRAINT `tranzactii_ibfk_1` FOREIGN KEY (`from`) REFERENCES `conturibancare` (`nrCont`),
  ADD CONSTRAINT `tranzactii_ibfk_2` FOREIGN KEY (`to`) REFERENCES `conturibancare` (`nrCont`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
