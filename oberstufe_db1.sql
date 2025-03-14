-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 14. Mrz 2025 um 12:53
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `oberstufe_db1`
--
CREATE DATABASE IF NOT EXISTS `oberstufe_db1` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `oberstufe_db1`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `abgeleitet`
--

DROP TABLE IF EXISTS `abgeleitet`;
CREATE TABLE `abgeleitet` (
  `FK_Dienstleistung` int(11) NOT NULL,
  `FK_Ticket` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `abgeleitet`
--

INSERT INTO `abgeleitet` (`FK_Dienstleistung`, `FK_Ticket`) VALUES
(3, 2),
(3, 3),
(14, 1),
(11, 1),
(9, 1),
(1, 46),
(2, 46),
(3, 46),
(1, 48),
(2, 48),
(3, 48),
(3, 48);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `arbeitet`
--

DROP TABLE IF EXISTS `arbeitet`;
CREATE TABLE `arbeitet` (
  `FK_Mitarbeiter` int(11) NOT NULL,
  `FK_Kunde` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `arbeitet`
--

INSERT INTO `arbeitet` (`FK_Mitarbeiter`, `FK_Kunde`) VALUES
(1, 1),
(2, 2),
(3, 1),
(4, 1),
(5, 1),
(6, 1),
(7, 1),
(8, 1),
(9, 1),
(10, 1),
(11, 1),
(12, 1),
(13, 1),
(14, 1),
(15, 1),
(16, 1),
(17, 1),
(18, 1),
(19, 1),
(20, 1),
(21, 1),
(22, 1),
(23, 1),
(24, 1),
(25, 1),
(26, 1),
(27, 1),
(28, 1),
(29, 1),
(30, 1),
(31, 1),
(32, 1),
(33, 1),
(34, 1),
(35, 1),
(36, 1),
(37, 1),
(38, 1),
(39, 1),
(40, 1),
(41, 1),
(42, 1),
(43, 1),
(44, 1),
(45, 1),
(46, 1),
(47, 1),
(48, 1),
(49, 1),
(50, 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `art`
--

DROP TABLE IF EXISTS `art`;
CREATE TABLE `art` (
  `PK_Art` int(11) NOT NULL,
  `Artname` varchar(255) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `art`
--

INSERT INTO `art` (`PK_Art`, `Artname`, `Beschreibung`) VALUES
(1, 'Wartung', 'Test2'),
(2, 'Fehlerbehebung', 'Behebung von Softwarefehlern'),
(3, 'Installation', 'Installation neuer Hardware oder Software'),
(4, 'Upgrade', 'System-Upgrade'),
(5, 'Beratung', 'IT-Beratung'),
(8, 'Test', 'awdawd');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bearbeitet`
--

DROP TABLE IF EXISTS `bearbeitet`;
CREATE TABLE `bearbeitet` (
  `FK_Mitarbeiter` int(11) NOT NULL,
  `FK_Ticket` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `bearbeitet`
--

INSERT INTO `bearbeitet` (`FK_Mitarbeiter`, `FK_Ticket`) VALUES
(1, 1),
(2, 1),
(3, 3),
(4, 4);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bezahlungsart`
--

DROP TABLE IF EXISTS `bezahlungsart`;
CREATE TABLE `bezahlungsart` (
  `Artname` varchar(255) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL,
  `PK_Bezahlungsart` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `bezahlungsart`
--

INSERT INTO `bezahlungsart` (`Artname`, `Beschreibung`, `PK_Bezahlungsart`) VALUES
('Kreditkarte', 'Zahlung per Kreditkarter', 1),
('Überweisung', 'Banküberweisung', 2),
('Paypal', 'Zahlung per Paypal', 3),
('Barzahlung', 'Zahlung in bar', 4),
('Kryptowährung', 'Zahlung mit Bitcoin', 5),
('Test', 'awdawd', 7),
('Leon schlagen', 'Leon ist ein Hurensohn und stinkt nach käse', 8);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `dienstleistung`
--

DROP TABLE IF EXISTS `dienstleistung`;
CREATE TABLE `dienstleistung` (
  `PK_Dienstleistung` int(11) NOT NULL,
  `Beschreibung` text DEFAULT NULL,
  `Kosten` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `dienstleistung`
--

INSERT INTO `dienstleistung` (`PK_Dienstleistung`, `Beschreibung`, `Kosten`) VALUES
(1, 'eServerwartunge', 8.50),
(2, 'Softwareinstallation', 300.00),
(3, 'Netzwerkinstallation', 75.00),
(4, 'Hardware-Reparatur', 200.00),
(5, 'Consulting', 500.00),
(6, 'asdads', 213213.00),
(7, 'asdads', 213213.00),
(8, 'asdads', 213213.00),
(9, 'asdads', 213213.00),
(10, 'asdads', 213213.00),
(11, 'asdads', 213213.00),
(12, 'asdads', 213213.00),
(13, 'asdads', 213213.00),
(14, 'Test', 66.00);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunde`
--

DROP TABLE IF EXISTS `kunde`;
CREATE TABLE `kunde` (
  `PK_Kunde` int(11) NOT NULL,
  `Kundennummer` varchar(255) DEFAULT NULL,
  `Firmenname` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Passwort` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `kunde`
--

INSERT INTO `kunde` (`PK_Kunde`, `Kundennummer`, `Firmenname`, `Email`, `Passwort`) VALUES
(1, 'K000', 'Easitix', 'admin@easitix.com', 'IonlyCANcockNOTcook'),
(2, 'K001', 'Firma Alpha2', 'unicorns@rainbowland.com', 'IllSmokeWeed69'),
(3, 'K002', 'Firma Beta', 'picklemonsters@crazyworld.com', 'ILikethefingerInMYass'),
(4, 'K003', 'Firma Gamma', 'flyingcarrots@vegetableheaven.com', 'IcanFLEXninetees4fortnite'),
(5, 'K004', 'Firma Delta', 'banana_bandits@fruitopia.com', 'L0StIn@VaCuum!!'),
(6, 'K005', 'Firma Epsilon', 'sockpuppets@whimsicalrealm.com', 'Sh@d0w0fChtrapper'),
(15, '666', 'LuciferMorningstar.Inc', 'Morningstar@Lucifer.inc', '2453532345');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mitarbeiter`
--

DROP TABLE IF EXISTS `mitarbeiter`;
CREATE TABLE `mitarbeiter` (
  `PK_Mitarbeiter` int(11) NOT NULL,
  `Vorname` varchar(255) DEFAULT NULL,
  `Nachname` varchar(255) DEFAULT NULL,
  `Position` varchar(255) DEFAULT NULL,
  `Festnetznummer` varchar(20) DEFAULT NULL,
  `Mobilnummer` varchar(20) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Passwort` varchar(255) DEFAULT NULL,
  `FK_Ort` int(11) DEFAULT NULL,
  `FK_Rechtegruppe` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `mitarbeiter`
--

INSERT INTO `mitarbeiter` (`PK_Mitarbeiter`, `Vorname`, `Nachname`, `Position`, `Festnetznummer`, `Mobilnummer`, `Email`, `Passwort`, `FK_Ort`, `FK_Rechtegruppe`) VALUES
(1, 'Max', 'Mustermann', 'Techniker', '030-1234567', '0176-12345678', 'max@techcorp.de', 'test', 1, 1),
(2, 'Erika', 'Mustermann', 'Sekretärin', '040-9876543', '0176-98765432', 'erika@meditech.de', 'test', 2, 2),
(3, 'Hans', 'Müller', 'Entwickler', '089-5555555', '0176-55555555', 'hans@edusoft.de', 'Hann1bal_@frica', 3, 1),
(4, 'Julia', 'Schmidt', 'Projektleiterin', '0221-6666666', '0176-66666666', 'julia@healthinc.de', 'Cr1ms0n_P1rate77', 4, 3),
(5, 'Peter', 'Beispiel', 'Manager', '069-7777777', '0176-77777777', 'peter@ecosolutions.de', 'Dr@cula_Vlad45', 5, 5),
(6, 'John Quincy', 'Adams', 'Präsident', '030-1111116', '0176-1234572', 'john.quincy.adams@example.com', 'Att1laTheHun$', 1, 1),
(7, 'Andrew', 'Jackson', 'Präsident', '030-1111117', '0176-1234573', 'andrew.jackson@example.com', 'BlackB3@rdPirate', 1, 1),
(8, 'Martin', 'Van Buren', 'Präsident', '030-1111118', '0176-1234574', 'martin.vanburen@example.com', 'RedPh@ntom66', 1, 1),
(9, 'William Henry', 'Harrison', 'Präsident', '030-1111119', '0176-1234575', 'william.harrison@example.com', 'JaggedCrownK1ng', 1, 1),
(10, 'John', 'Tyler', 'Präsident', '030-1111120', '0176-1234576', 'john.tyler@example.com', 'L1ttleM0hawkChief', 1, 1),
(11, 'James Knox', 'Polk', 'Präsident', '030-1111121', '0176-1234577', 'james.polk@example.com', 'Th3Rav3nMarauder', 1, 1),
(12, 'Zachary', 'Taylor', 'Präsident', '030-1111122', '0176-1234578', 'zachary.taylor@example.com', 'B0rch_Tusklord', 1, 1),
(13, 'Millard', 'Fillmore', 'Präsident', '030-1111123', '0176-1234579', 'millard.fillmore@example.com', 'Night0fW0lves', 1, 1),
(14, 'Franklin', 'Pierce', 'Präsident', '030-1111124', '0176-1234580', 'franklin.pierce@example.com', 'Bl@ckHand4Ever', 1, 1),
(15, 'James', 'Buchanan', 'Präsident', '030-1111125', '0176-1234581', 'james.buchanan@example.com', 'L0neJ@ckalAlpha', 1, 1),
(16, 'Abraham', 'Lincoln', 'Präsident', '030-1111126', '0176-1234582', 'abraham.lincoln@example.com', 'W0lfspadeKing', 1, 1),
(17, 'Andrew', 'Johnson', 'Präsident', '030-1111127', '0176-1234583', 'andrew.johnson@example.com', 'Wraith0fEmpire', 1, 1),
(18, 'Ulysses Simpson', 'Grant', 'Präsident', '030-1111128', '0176-1234584', 'ulysses.grant@example.com', 'M0ng00se@ntiHero', 1, 1),
(19, 'Rutherford Birchard', 'Hayes', 'Präsident', '030-1111129', '0176-1234585', 'rutherford.hayes@example.com', 'Cr1mson_Corsair', 1, 1),
(20, 'James Abram', 'Garfield', 'Präsident', '030-1111130', '0176-1234586', 'james.garfield@example.com', 'Ph@nt0mStrik3r', 1, 1),
(21, 'Chester Alan', 'Arthur', 'Präsident', '030-1111131', '0176-1234587', 'chester.arthur@example.com', 'Gr1mShad0wKing', 1, 1),
(22, 'Grover', 'Cleveland', 'Präsident', '030-1111132', '0176-1234588', 'grover.cleveland@example.com', 'D@rkRe@perXX', 1, 1),
(23, 'Benjamin', 'Harrison', 'Präsident', '030-1111133', '0176-1234589', 'benjamin.harrison@example.com', 'F@ngofWolfblade', 1, 1),
(24, 'William', 'McKinley', 'Präsident', '030-1111134', '0176-1234590', 'william.mckinley@example.com', 'R3dDr@gonWarlord', 1, 1),
(25, 'Theodore', 'Roosevelt', 'Präsident', '030-1111135', '0176-1234591', 'theodore.roosevelt@example.com', 'Gh0st0fKnights', 1, 1),
(26, 'William Howard', 'Taft', 'Präsident', '030-1111136', '0176-1234592', 'william.taft@example.com', 'Des3rtGh0st22', 1, 1),
(27, 'Woodrow', 'Wilson', 'Präsident', '030-1111137', '0176-1234593', 'woodrow.wilson@example.com', 'V@lkyrieM@rauder', 1, 1),
(28, 'Warren Gamaliel', 'Harding', 'Präsident', '030-1111138', '0176-1234594', 'warren.harding@example.com', 'D@rkHorseRider', 1, 1),
(29, 'Calvin', 'Coolidge', 'Präsident', '030-1111139', '0176-1234595', 'calvin.coolidge@example.com', 'Ch@otic@ngel', 1, 1),
(30, 'Herbert Clark', 'Hoover', 'Präsident', '030-1111140', '0176-1234596', 'herbert.hoover@example.com', 'Gr3yGh0st13', 1, 1),
(31, 'Franklin Delano', 'Roosevelt', 'Präsident', '030-1111141', '0176-1234597', 'franklin.roosevelt@example.com', 'L0n3Sc0rpi0n', 1, 1),
(32, 'Harry S', 'Truman', 'Präsident', '030-1111142', '0176-1234598', 'harry.truman@example.com', 'Sh@d0wMast3r', 1, 1),
(33, 'Dwight David', 'Eisenhower', 'Präsident', '030-1111143', '0176-1234599', 'dwight.eisenhower@example.com', 'NightShade33', 1, 1),
(34, 'John Fitzgerald', 'Kennedy', 'Präsident', '030-1111144', '0176-1240000', 'john.kennedy@example.com', 'M0rningStar99', 1, 1),
(35, 'Lyndon Baines', 'Johnson', 'Präsident', '030-1111145', '0176-1240001', 'lyndon.johnson@example.com', 'St0rmRaven23', 1, 1),
(36, 'Richard Milhous', 'Nixon', 'Präsident', '030-1111146', '0176-1240002', 'richard.nixon@example.com', 'F@lconStriker', 1, 1),
(37, 'Gerald', 'Ford', 'Präsident', '030-1111147', '0176-1240003', 'gerald.ford@example.com', 'R0gueCr0wned', 1, 1),
(38, 'James Earl', 'Carter', 'Präsident', '030-1111148', '0176-1240004', 'james.carter@example.com', 'CrimsonR1sing', 1, 1),
(39, 'Ronald Wilson', 'Reagan', 'Präsident', '030-1111149', '0176-1240005', 'ronald.reagan@example.com', 'Nightf@llR0gue', 1, 1),
(40, 'George Herbert Walker', 'Bush', 'Präsident', '030-1111150', '0176-1240006', 'george.bush@example.com', 'Jaguar@ssassin', 1, 1),
(41, 'William Jefferson', 'Clinton', 'Präsident', '030-1111151', '0176-1240007', 'william.clinton@example.com', 'S0ldier0fChaos', 1, 1),
(42, 'George Walker', 'Bush', 'Präsident', '030-1111152', '0176-1240008', 'george.walker.bush@example.com', 'Gh0stB@ndit', 1, 1),
(43, 'Barack Hussein', 'Obama', 'Präsident', '030-1111153', '0176-1240009', 'barack.obama@example.com', 'Sc@rletBlade', 1, 1),
(44, 'Donald John', 'Trump', 'Präsident', '030-1111154', '0176-1240010', 'donald.trump@example.com', 'L3gend$Pirate', 1, 1),
(45, 'Joseph Robinette', 'Biden Junior', 'Präsident', '030-1111155', '0176-1240011', 'joseph.biden@example.com', 'Bl00dCursedK1ng', 1, 1),
(46, 'George', 'Washington', 'Präsident', '030-1111111', '0176-1234567', 'george.washington@example.com', 'DarkWolf$hadow', 1, 1),
(47, 'John', 'Adams', 'Präsident', '030-1111112', '0176-1234568', 'john.adams@example.com', 'M0untainTiger', 1, 1),
(48, 'Thomas', 'Jefferson', 'Präsident', '030-1111113', '0176-1234569', 'thomas.jefferson@example.com', 'F1ery@ssassin', 1, 1),
(49, 'James', 'Madison', 'Präsident', '030-1111114', '0176-1234570', 'james.madison@example.com', 'Wh1teF@ngRaider', 1, 1),
(50, 'James', 'Monroe', 'Präsident', '030-1111115', '0176-1234571', 'james.monroe@example.com', 'S0ulCr0wnXX', 1, 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ort`
--

DROP TABLE IF EXISTS `ort`;
CREATE TABLE `ort` (
  `PK_Ort` int(11) NOT NULL,
  `Stadt` varchar(255) DEFAULT NULL,
  `PLZ` varchar(10) DEFAULT NULL,
  `Straße` varchar(255) DEFAULT NULL,
  `Hausnummer` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `ort`
--

INSERT INTO `ort` (`PK_Ort`, `Stadt`, `PLZ`, `Straße`, `Hausnummer`) VALUES
(1, 'Berlin', '10115', 'Hauptstraße', '10'),
(2, 'Hamburg', '20095', 'Nebenstraße', '5'),
(3, 'München', '80331', 'Platz', '12'),
(4, 'Köln', '50667', 'Ring', '3'),
(5, 'Frankfurt', '60313', 'Weg', '8');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `priorität`
--

DROP TABLE IF EXISTS `priorität`;
CREATE TABLE `priorität` (
  `PK_Priorität` int(11) NOT NULL,
  `Prioritätsname` varchar(255) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `priorität`
--

INSERT INTO `priorität` (`PK_Priorität`, `Prioritätsname`, `Beschreibung`) VALUES
(1, 'Hoch', 'Wichtige Aufgabe'),
(2, 'Mittel', 'Mittelwichtige Aufgabe'),
(3, 'Niedrig', 'Geringe Priorität'),
(4, 'Sehr Hoch', 'Sehr dringende Aufgabe'),
(5, 'Gering', 'Kann warten');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `rechnung`
--

DROP TABLE IF EXISTS `rechnung`;
CREATE TABLE `rechnung` (
  `Rechnungsnr` int(11) NOT NULL,
  `Ticketbeschreibung` text DEFAULT NULL,
  `Abrechnung` varchar(255) DEFAULT NULL,
  `Ratenzahlung` tinyint(1) DEFAULT NULL,
  `FK_Bezahlungsart` int(11) DEFAULT NULL,
  `FK_Kunde` int(11) DEFAULT NULL,
  `FK_Ticket` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `rechnung`
--

INSERT INTO `rechnung` (`Rechnungsnr`, `Ticketbeschreibung`, `Abrechnung`, `Ratenzahlung`, `FK_Bezahlungsart`, `FK_Kunde`, `FK_Ticket`) VALUES
(14, 'Test2', '0€', 0, 8, 2, 2),
(23, 'tesdt', 'Rechnung für Ticket 46', 0, 2, 1, 46),
(24, 'ttest', 'Rechnung für Ticket 48', 0, 2, 1, 48),
(26, 'Hardwareproblem an PC', 'Rechnung für Ticket 4', 0, 2, 1, 4),
(31, 'Server läuft nicht richtigasdd', 'Rechnung für Ticket 1', 0, 2, 2, 1),
(32, 'Neues Netzwerk muss installiert werden', 'Rechnung für Ticket 3', 0, 2, 1, 3);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `rechtegruppe`
--

DROP TABLE IF EXISTS `rechtegruppe`;
CREATE TABLE `rechtegruppe` (
  `Administrationsrechte` tinyint(1) DEFAULT NULL,
  `Bestelllimit` decimal(10,2) DEFAULT NULL,
  `Helpdesk_Fernwartung` tinyint(1) DEFAULT NULL,
  `PK_Rechtegruppe` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `rechtegruppe`
--

INSERT INTO `rechtegruppe` (`Administrationsrechte`, `Bestelllimit`, `Helpdesk_Fernwartung`, `PK_Rechtegruppe`) VALUES
(1, 1000.00, 1, 1),
(0, 500.00, 0, 2),
(1, 2000.00, 1, 3),
(0, 100.00, 0, 4),
(1, 1500.00, 0, 5);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `residiert`
--

DROP TABLE IF EXISTS `residiert`;
CREATE TABLE `residiert` (
  `FK_Kunde` int(11) NOT NULL,
  `FK_Ort` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `residiert`
--

INSERT INTO `residiert` (`FK_Kunde`, `FK_Ort`) VALUES
(1, 1),
(2, 3),
(3, 2),
(4, 3),
(5, 4),
(6, 5),
(15, 4);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `session`
--

DROP TABLE IF EXISTS `session`;
CREATE TABLE `session` (
  `id` int(11) NOT NULL,
  `sessionhash` longtext NOT NULL,
  `expires_at` datetime NOT NULL,
  `inserted_at` datetime NOT NULL DEFAULT current_timestamp(),
  `FK_Mitarbeiter` int(11) NOT NULL,
  `FK_Kunde` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `status`
--

DROP TABLE IF EXISTS `status`;
CREATE TABLE `status` (
  `PK_Status` int(11) NOT NULL,
  `Statusname` varchar(255) DEFAULT NULL,
  `Farbe` varchar(20) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `status`
--

INSERT INTO `status` (`PK_Status`, `Statusname`, `Farbe`, `Beschreibung`) VALUES
(1, 'Offen', 'Gelb', 'Ticket ist offen'),
(2, 'In Bearbeitung', 'Gelb', 'Ticket in Bearbeitung'),
(3, 'Geschlossen', 'Grün', 'Ticket geschlossen'),
(4, 'Wartend', 'Blau', 'Wartet auf Antwort'),
(5, 'Archiviert', 'Grau', 'Ticket archiviert');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ticket`
--

DROP TABLE IF EXISTS `ticket`;
CREATE TABLE `ticket` (
  `PK_Ticket` int(11) NOT NULL,
  `Ticket_Titel` varchar(75) NOT NULL,
  `Beschreibung` text DEFAULT NULL,
  `InterneNotiz` text DEFAULT NULL,
  `InternerStatus` text DEFAULT NULL,
  `Erstelldatum` datetime DEFAULT NULL,
  `Bearbeitungsdatum` datetime DEFAULT NULL,
  `FK_Status` int(11) DEFAULT NULL,
  `FK_Priorität` int(11) DEFAULT NULL,
  `FK_Art` int(11) DEFAULT NULL,
  `FK_Mitarbeiter` int(11) DEFAULT NULL,
  `FK_Kunde` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Daten für Tabelle `ticket`
--

INSERT INTO `ticket` (`PK_Ticket`, `Ticket_Titel`, `Beschreibung`, `InterneNotiz`, `InternerStatus`, `Erstelldatum`, `Bearbeitungsdatum`, `FK_Status`, `FK_Priorität`, `FK_Art`, `FK_Mitarbeiter`, `FK_Kunde`) VALUES
(1, 'Problem mit Server', 'Server läuft nicht richtigasdd', 'Keine Notizasdd', 'Offenasddd', '2024-09-01 00:00:00', '2024-09-01 00:00:00', 5, 3, 2, 1, 2),
(2, 'Fehler in Software', 'Software gibt Fehler aus', 'Dringend', 'In Bearbeitung', '2024-09-02 00:00:00', '2024-09-03 00:00:00', 2, 2, 2, 2, 2),
(3, 'Netzwerkinstallation', 'Neues Netzwerk muss installiert werden', 'Kabel fehlen', 'Geschlossen', '2024-09-02 20:00:00', '2024-09-02 20:00:00', 3, 3, 3, 3, 1),
(4, 'TimonDefekt', 'Hardwareproblem an PC', 'Ersatzteil bestellt', 'Wartend', '2024-09-04 00:00:00', '2024-09-04 00:00:00', 1, 2, 3, 10, 5),
(46, 'TEsttest', 'tesdt', 'test', 'test', '2322-12-31 22:22:00', '2322-12-31 22:22:00', 1, 1, 1, 8, 1),
(48, 'test', 'ttest', 'test', 'test', '1212-12-12 12:12:00', '1212-12-12 12:12:00', 1, 1, 1, 2, 1);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `abgeleitet`
--
ALTER TABLE `abgeleitet`
  ADD KEY `abgeleitet_fk_2` (`FK_Ticket`),
  ADD KEY `FK_Dienstleistung` (`FK_Dienstleistung`);

--
-- Indizes für die Tabelle `arbeitet`
--
ALTER TABLE `arbeitet`
  ADD PRIMARY KEY (`FK_Mitarbeiter`,`FK_Kunde`),
  ADD KEY `fk_kunde` (`FK_Kunde`);

--
-- Indizes für die Tabelle `art`
--
ALTER TABLE `art`
  ADD PRIMARY KEY (`PK_Art`);

--
-- Indizes für die Tabelle `bearbeitet`
--
ALTER TABLE `bearbeitet`
  ADD PRIMARY KEY (`FK_Mitarbeiter`,`FK_Ticket`),
  ADD KEY `bearbeitet_fk_2` (`FK_Ticket`);

--
-- Indizes für die Tabelle `bezahlungsart`
--
ALTER TABLE `bezahlungsart`
  ADD PRIMARY KEY (`PK_Bezahlungsart`);

--
-- Indizes für die Tabelle `dienstleistung`
--
ALTER TABLE `dienstleistung`
  ADD PRIMARY KEY (`PK_Dienstleistung`);

--
-- Indizes für die Tabelle `kunde`
--
ALTER TABLE `kunde`
  ADD PRIMARY KEY (`PK_Kunde`);

--
-- Indizes für die Tabelle `mitarbeiter`
--
ALTER TABLE `mitarbeiter`
  ADD PRIMARY KEY (`PK_Mitarbeiter`),
  ADD KEY `mitarbeiter_fk_1` (`FK_Ort`),
  ADD KEY `mitarbeiter_fk_2` (`FK_Rechtegruppe`);

--
-- Indizes für die Tabelle `ort`
--
ALTER TABLE `ort`
  ADD PRIMARY KEY (`PK_Ort`);

--
-- Indizes für die Tabelle `priorität`
--
ALTER TABLE `priorität`
  ADD PRIMARY KEY (`PK_Priorität`);

--
-- Indizes für die Tabelle `rechnung`
--
ALTER TABLE `rechnung`
  ADD PRIMARY KEY (`Rechnungsnr`),
  ADD KEY `rechnung_fk_1` (`FK_Bezahlungsart`),
  ADD KEY `rechnung_fk_2` (`FK_Kunde`),
  ADD KEY `rechnung_fk_3` (`FK_Ticket`);

--
-- Indizes für die Tabelle `rechtegruppe`
--
ALTER TABLE `rechtegruppe`
  ADD PRIMARY KEY (`PK_Rechtegruppe`);

--
-- Indizes für die Tabelle `residiert`
--
ALTER TABLE `residiert`
  ADD PRIMARY KEY (`FK_Kunde`,`FK_Ort`) USING BTREE,
  ADD KEY `FK_Kunde` (`FK_Kunde`,`FK_Ort`) USING BTREE,
  ADD KEY `residiert_fk1` (`FK_Ort`);

--
-- Indizes für die Tabelle `session`
--
ALTER TABLE `session`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Mitarbeiter` (`FK_Mitarbeiter`),
  ADD KEY `FK_Kunde` (`FK_Kunde`);

--
-- Indizes für die Tabelle `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`PK_Status`);

--
-- Indizes für die Tabelle `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`PK_Ticket`),
  ADD KEY `ticket_fk_1` (`FK_Status`),
  ADD KEY `ticket_fk_2` (`FK_Priorität`),
  ADD KEY `ticket_fk_3` (`FK_Art`),
  ADD KEY `ticket_fk_4` (`FK_Mitarbeiter`),
  ADD KEY `ticket_fk_5` (`FK_Kunde`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `art`
--
ALTER TABLE `art`
  MODIFY `PK_Art` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT für Tabelle `bezahlungsart`
--
ALTER TABLE `bezahlungsart`
  MODIFY `PK_Bezahlungsart` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT für Tabelle `dienstleistung`
--
ALTER TABLE `dienstleistung`
  MODIFY `PK_Dienstleistung` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT für Tabelle `kunde`
--
ALTER TABLE `kunde`
  MODIFY `PK_Kunde` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT für Tabelle `mitarbeiter`
--
ALTER TABLE `mitarbeiter`
  MODIFY `PK_Mitarbeiter` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT für Tabelle `ort`
--
ALTER TABLE `ort`
  MODIFY `PK_Ort` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT für Tabelle `priorität`
--
ALTER TABLE `priorität`
  MODIFY `PK_Priorität` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT für Tabelle `rechnung`
--
ALTER TABLE `rechnung`
  MODIFY `Rechnungsnr` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT für Tabelle `rechtegruppe`
--
ALTER TABLE `rechtegruppe`
  MODIFY `PK_Rechtegruppe` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT für Tabelle `session`
--
ALTER TABLE `session`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT für Tabelle `status`
--
ALTER TABLE `status`
  MODIFY `PK_Status` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT für Tabelle `ticket`
--
ALTER TABLE `ticket`
  MODIFY `PK_Ticket` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `abgeleitet`
--
ALTER TABLE `abgeleitet`
  ADD CONSTRAINT `abgeleitet_fk_1` FOREIGN KEY (`FK_Dienstleistung`) REFERENCES `dienstleistung` (`PK_Dienstleistung`),
  ADD CONSTRAINT `abgeleitet_fk_2` FOREIGN KEY (`FK_Ticket`) REFERENCES `ticket` (`PK_Ticket`),
  ADD CONSTRAINT `abgeleitet_ibfk_1` FOREIGN KEY (`FK_Dienstleistung`) REFERENCES `dienstleistung` (`PK_Dienstleistung`);

--
-- Constraints der Tabelle `arbeitet`
--
ALTER TABLE `arbeitet`
  ADD CONSTRAINT `arbeitet_ibfk_1` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`),
  ADD CONSTRAINT `fk_kunde` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`),
  ADD CONSTRAINT `fk_mitarbeiter` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`);

--
-- Constraints der Tabelle `bearbeitet`
--
ALTER TABLE `bearbeitet`
  ADD CONSTRAINT `bearbeitet_fk_1` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`),
  ADD CONSTRAINT `bearbeitet_fk_2` FOREIGN KEY (`FK_Ticket`) REFERENCES `ticket` (`PK_Ticket`);

--
-- Constraints der Tabelle `mitarbeiter`
--
ALTER TABLE `mitarbeiter`
  ADD CONSTRAINT `mitarbeiter_fk_1` FOREIGN KEY (`FK_Ort`) REFERENCES `ort` (`PK_Ort`),
  ADD CONSTRAINT `mitarbeiter_fk_2` FOREIGN KEY (`FK_Rechtegruppe`) REFERENCES `rechtegruppe` (`PK_Rechtegruppe`);

--
-- Constraints der Tabelle `rechnung`
--
ALTER TABLE `rechnung`
  ADD CONSTRAINT `rechnung_fk_1` FOREIGN KEY (`FK_Bezahlungsart`) REFERENCES `bezahlungsart` (`PK_Bezahlungsart`),
  ADD CONSTRAINT `rechnung_fk_2` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`),
  ADD CONSTRAINT `rechnung_fk_3` FOREIGN KEY (`FK_Ticket`) REFERENCES `ticket` (`PK_Ticket`);

--
-- Constraints der Tabelle `residiert`
--
ALTER TABLE `residiert`
  ADD CONSTRAINT `residiert_fk1` FOREIGN KEY (`FK_Ort`) REFERENCES `ort` (`PK_Ort`),
  ADD CONSTRAINT `residiert_fk2` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`);

--
-- Constraints der Tabelle `session`
--
ALTER TABLE `session`
  ADD CONSTRAINT `session_ibfk_1` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`),
  ADD CONSTRAINT `session_ibfk_2` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`);

--
-- Constraints der Tabelle `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `ticket_fk_1` FOREIGN KEY (`FK_Status`) REFERENCES `status` (`PK_Status`),
  ADD CONSTRAINT `ticket_fk_2` FOREIGN KEY (`FK_Priorität`) REFERENCES `priorität` (`PK_Priorität`),
  ADD CONSTRAINT `ticket_fk_3` FOREIGN KEY (`FK_Art`) REFERENCES `art` (`PK_Art`),
  ADD CONSTRAINT `ticket_fk_4` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`),
  ADD CONSTRAINT `ticket_fk_5` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
