SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
DROP DATABASE IF EXISTS `oberstufe_db1`;
CREATE DATABASE IF NOT EXISTS `oberstufe_db1` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `oberstufe_db1`;

DROP TABLE IF EXISTS `abgeleitet`;
CREATE TABLE `abgeleitet` (
  `FK_Dienstleistung` int(11) NOT NULL,
  `FK_Ticket` int(11) NOT NULL,
  `Anzahl` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `abgeleitet` (`FK_Dienstleistung`, `FK_Ticket`, `Anzahl`) VALUES
(1, 8, 2),
(1, 18, 1),
(1, 46, 1),
(1, 48, 1),
(2, 10, 1),
(2, 21, 1),
(2, 46, 1),
(2, 48, 1),
(3, 2, 1),
(3, 3, 1),
(3, 9, 1),
(3, 15, 1),
(3, 19, 2),
(3, 46, 1),
(3, 48, 2),
(4, 11, 2),
(4, 16, 1),
(4, 22, 1),
(5, 12, 1),
(5, 17, 3),
(5, 20, 1),
(6, 13, 1),
(6, 23, 2),
(9, 1, 1),
(11, 1, 1),
(14, 1, 1);

DROP TABLE IF EXISTS `arbeitet`;
CREATE TABLE `arbeitet` (
  `FK_Mitarbeiter` int(11) NOT NULL,
  `FK_Kunde` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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

DROP TABLE IF EXISTS `art`;
CREATE TABLE `art` (
  `PK_Art` int(11) NOT NULL,
  `Artname` varchar(255) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `art` (`PK_Art`, `Artname`, `Beschreibung`) VALUES
(1, 'Wartung', 'Test2'),
(2, 'Fehlerbehebung', 'Behebung von Softwarefehlern'),
(3, 'Installation', 'Installation neuer Hardware oder Software'),
(4, 'Upgrade', 'System-Upgrade'),
(5, 'Beratung', 'IT-Beratung'),
(6, 'Test', 'awdawd');

DROP TABLE IF EXISTS `bearbeitet`;
CREATE TABLE `bearbeitet` (
  `FK_Mitarbeiter` int(11) NOT NULL,
  `FK_Ticket` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `bearbeitet` (`FK_Mitarbeiter`, `FK_Ticket`) VALUES
(1, 1),
(2, 1),
(3, 3),
(4, 4),
(5, 10),
(7, 11),
(9, 17),
(12, 8),
(15, 13),
(22, 16),
(23, 9),
(30, 12),
(40, 15);

DROP TABLE IF EXISTS `bezahlungsart`;
CREATE TABLE `bezahlungsart` (
  `Artname` varchar(255) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL,
  `PK_Bezahlungsart` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `bezahlungsart` (`Artname`, `Beschreibung`, `PK_Bezahlungsart`) VALUES
('Kreditkarte', 'Zahlung per Kreditkarter', 1),
('Überweisung', 'Banküberweisung', 2),
('Paypal', 'Zahlung per Paypal', 3),
('Barzahlung', 'Zahlung in bar', 4),
('Kryptowährung', 'Zahlung mit Bitcoin', 5),
('Test', 'awdawd', 6),
('TestArt', 'TestArt', 7),
('Leon schlagen', 'Leon ist ein Hurensohn und stinkt nach käse', 8);

DROP TABLE IF EXISTS `dienstleistung`;
CREATE TABLE `dienstleistung` (
  `PK_Dienstleistung` int(11) NOT NULL,
  `Beschreibung` text DEFAULT NULL,
  `Kosten` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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

DROP TABLE IF EXISTS `kunde`;
CREATE TABLE `kunde` (
  `PK_Kunde` int(11) NOT NULL,
  `Kundennummer` varchar(255) DEFAULT NULL,
  `Firmenname` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Passwort` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `kunde` (`PK_Kunde`, `Kundennummer`, `Firmenname`, `Email`, `Passwort`) VALUES
(1, 'K000', 'Easitix', 'admin@easitix.com', 'IonlyCANcockNOTcook'),
(2, 'K001', 'Firma Alpha2', 'unicorns@rainbowland.com', 'IllSmokeWeed69'),
(3, 'K002', 'Firma Beta', 'picklemonsters@crazyworld.com', 'ILikethefingerInMYass'),
(4, 'K003', 'Firma Gamma', 'flyingcarrots@vegetableheaven.com', 'IcanFLEXninetees4fortnite'),
(5, 'K004', 'Firma Delta', 'banana_bandits@fruitopia.com', 'L0StIn@VaCuum!!'),
(6, 'K005', 'Firma Epsilon', 'sockpuppets@whimsicalrealm.com', 'Sh@d0w0fChtrapper'),
(7, '666', 'LuciferMorningstar.Inc', 'Morningstar@Lucifer.inc', '2453532345');

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

INSERT INTO `mitarbeiter` (`PK_Mitarbeiter`, `Vorname`, `Nachname`, `Position`, `Festnetznummer`, `Mobilnummer`, `Email`, `Passwort`, `FK_Ort`, `FK_Rechtegruppe`) VALUES
(1, 'Max', 'Mustermann', 'Techniker', '030-1234567', '0176-12345678', 'max@techcorp.de', 'a94a8fe5ccb19ba61c4c0873d391e987982fbbd3', 1, 1),
(2, 'Erika', 'Mustermann', 'Sekretärin', '040-9876543', '0176-98765432', 'erika@meditech.de', 'a94a8fe5ccb19ba61c4c0873d391e987982fbbd3', 2, 2),
(3, 'Hans', 'Müller', 'Entwickler', '089-5555555', '0176-55555555', 'hans@edusoft.de', 'd1bd0728db4531d015b499e0a02f281a91fb507c', 3, 1),
(4, 'Julia', 'Schmidt', 'Projektleiterin', '0221-6666666', '0176-66666666', 'julia@healthinc.de', '899bf9c46e95583d54e4f838664bc3a112120811', 4, 3),
(5, 'Peter', 'Beispiel', 'Manager', '069-7777777', '0176-77777777', 'peter@ecosolutions.de', '332aa1470f5edc79d776e0caf88fa0ce5ada48e5', 5, 5),
(6, 'John Quincy', 'Adams', 'Präsident', '030-1111116', '0176-1234572', 'john.quincy.adams@example.com', '68645a5be4dbcf249475d2634a1bb15a34559464', 1, 1),
(7, 'Andrew', 'Jackson', 'Präsident', '030-1111117', '0176-1234573', 'andrew.jackson@example.com', 'b6e948c1e71fd16091fc78d24f4495b82d5f5cc7', 1, 1),
(8, 'Martin', 'Van Buren', 'Präsident', '030-1111118', '0176-1234574', 'martin.vanburen@example.com', '6bcd329ced7161fb2e04c7eaa71fda55888f298a', 1, 1),
(9, 'William Henry', 'Harrison', 'Präsident', '030-1111119', '0176-1234575', 'william.harrison@example.com', 'fafb70a27fa4d3395946582fa17cdf6a46d6f761', 1, 1),
(10, 'John', 'Tyler', 'Präsident', '030-1111120', '0176-1234576', 'john.tyler@example.com', 'ac74f2edf20f4a13f1227d1558a283ad87b0546d', 1, 1),
(11, 'James Knox', 'Polk', 'Präsident', '030-1111121', '0176-1234577', 'james.polk@example.com', '412a7276f87640a11282e9ac8096703533ce8864', 1, 1),
(12, 'Zachary', 'Taylor', 'Präsident', '030-1111122', '0176-1234578', 'zachary.taylor@example.com', '8356f8fa35f5e8134d5a4a9a1b2bbbd2ee5e1508', 1, 1),
(13, 'Millard', 'Fillmore', 'Präsident', '030-1111123', '0176-1234579', 'millard.fillmore@example.com', '8fde0a22fcd3e272b1c56e55faa4bdca8479af53', 1, 1),
(14, 'Franklin', 'Pierce', 'Präsident', '030-1111124', '0176-1234580', 'franklin.pierce@example.com', 'a4c5ad7783137e642b59f037d27809ae328ebcbe', 1, 1),
(15, 'James', 'Buchanan', 'Präsident', '030-1111125', '0176-1234581', 'james.buchanan@example.com', '94518326d0ef268b11e070dcc36c5fa9bd54d3a0', 1, 1),
(16, 'Abraham', 'Lincoln', 'Präsident', '030-1111126', '0176-1234582', 'abraham.lincoln@example.com', '80e7c235b6db817ac92c21831e2e14cc12ca5713', 1, 1),
(17, 'Andrew', 'Johnson', 'Präsident', '030-1111127', '0176-1234583', 'andrew.johnson@example.com', '0501a19f7eaa4c4a1f11f1f8e298a7ebf4f2b398', 1, 1),
(18, 'Ulysses Simpson', 'Grant', 'Präsident', '030-1111128', '0176-1234584', 'ulysses.grant@example.com', '8b46ca796e9127ef26d3ada0534fc15eb970fb54', 1, 1),
(19, 'Rutherford Birchard', 'Hayes', 'Präsident', '030-1111129', '0176-1234585', 'rutherford.hayes@example.com', '468fecf7513b8577f29b4a41f806aed7b3f07523', 1, 1),
(20, 'James Abram', 'Garfield', 'Präsident', '030-1111130', '0176-1234586', 'james.garfield@example.com', '4251d30c20236b7d80a55a6682edd7acf07c0150', 1, 1),
(21, 'Chester Alan', 'Arthur', 'Präsident', '030-1111131', '0176-1234587', 'chester.arthur@example.com', '3341bbf1aa62e8d3b214439ae6e382f296c4dc77', 1, 1),
(22, 'Grover', 'Cleveland', 'Präsident', '030-1111132', '0176-1234588', 'grover.cleveland@example.com', 'fce63cd91ab1f0d266584ca39be1cad256430f16', 1, 1),
(23, 'Benjamin', 'Harrison', 'Präsident', '030-1111133', '0176-1234589', 'benjamin.harrison@example.com', '7fae53632d6a3144c266933f8a8e90bfd0a833af', 1, 1),
(24, 'William', 'McKinley', 'Präsident', '030-1111134', '0176-1234590', 'william.mckinley@example.com', 'b36a779563b06f23a75b506a2ef4944bd5ae7a40', 1, 1),
(25, 'Theodore', 'Roosevelt', 'Präsident', '030-1111135', '0176-1234591', 'theodore.roosevelt@example.com', '00b6761be28ed08e12f6ae2ececd7953c0b36ab8', 1, 1),
(26, 'William Howard', 'Taft', 'Präsident', '030-1111136', '0176-1234592', 'william.taft@example.com', 'b8d261a21fa87688947a1be9ddf2305c86c0d27c', 1, 1),
(27, 'Woodrow', 'Wilson', 'Präsident', '030-1111137', '0176-1234593', 'woodrow.wilson@example.com', '5226c5751edea66e3fb95da072172fd8309296d6', 1, 1),
(28, 'Warren Gamaliel', 'Harding', 'Präsident', '030-1111138', '0176-1234594', 'warren.harding@example.com', 'bc5762fe70c730faaad14c2738777ab14ba39b6f', 1, 1),
(29, 'Calvin', 'Coolidge', 'Präsident', '030-1111139', '0176-1234595', 'calvin.coolidge@example.com', '79654b104b5885a3c1a29ec2cfb3d3b3bff063fa', 1, 1),
(30, 'Herbert Clark', 'Hoover', 'Präsident', '030-1111140', '0176-1234596', 'herbert.hoover@example.com', 'e54bd42bc35c8f0d3a68835afb1a630130bf4fd9', 1, 1),
(31, 'Franklin Delano', 'Roosevelt', 'Präsident', '030-1111141', '0176-1234597', 'franklin.roosevelt@example.com', 'd2193641070514cfb0c1e69cb9b6749bae211ff2', 1, 1),
(32, 'Harry S', 'Truman', 'Präsident', '030-1111142', '0176-1234598', 'harry.truman@example.com', 'f9fed9be84b3b2884b18ebc767c72ccdd6a5e607', 1, 1),
(33, 'Dwight David', 'Eisenhower', 'Präsident', '030-1111143', '0176-1234599', 'dwight.eisenhower@example.com', 'd778e453d77411f6f1a7634485e09abde119a847', 1, 1),
(34, 'John Fitzgerald', 'Kennedy', 'Präsident', '030-1111144', '0176-1240000', 'john.kennedy@example.com', '47f7cb289e03d7cfe599642ab32bdc008ba0e316', 1, 1),
(35, 'Lyndon Baines', 'Johnson', 'Präsident', '030-1111145', '0176-1240001', 'lyndon.johnson@example.com', '431aba28ba3144f0cee139c21a4cf427f0c1d41f', 1, 1),
(36, 'Richard Milhous', 'Nixon', 'Präsident', '030-1111146', '0176-1240002', 'richard.nixon@example.com', 'e97e76d9598e8c1cfe77d90596f37bc87a6647a5', 1, 1),
(37, 'Gerald', 'Ford', 'Präsident', '030-1111147', '0176-1240003', 'gerald.ford@example.com', 'e1ac42d6578e184a5bef80b60fdbb033b1801b40', 1, 1),
(38, 'James Earl', 'Carter', 'Präsident', '030-1111148', '0176-1240004', 'james.carter@example.com', '8013e884a94f18b55ecbc047b79c826f397a980e', 1, 1),
(39, 'Ronald Wilson', 'Reagan', 'Präsident', '030-1111149', '0176-1240005', 'ronald.reagan@example.com', '89fe9969006d15f8e89a443e8ba2c050d91aa67a', 1, 1),
(40, 'George Herbert Walker', 'Bush', 'Präsident', '030-1111150', '0176-1240006', 'george.bush@example.com', '7a91b5fc2d3242efc494d48c13cc4a66ebf50e52', 1, 1),
(41, 'William Jefferson', 'Clinton', 'Präsident', '030-1111151', '0176-1240007', 'william.clinton@example.com', 'c3ed1a80817136b39491b7d7bad9e9548521bad2', 1, 1),
(42, 'George Walker', 'Bush', 'Präsident', '030-1111152', '0176-1240008', 'george.walker.bush@example.com', 'e86d611b96072901d5a1e497fa07d998f82b0862', 1, 1),
(43, 'Barack Hussein', 'Obama', 'Präsident', '030-1111153', '0176-1240009', 'barack.obama@example.com', 'ec2c84317f324e211140294d4cd8fc92477e73e1', 1, 1),
(44, 'Donald John', 'Trump', 'Präsident', '030-1111154', '0176-1240010', 'donald.trump@example.com', 'f1d352b3a93ab0f06994357c3a6781408c485f7e', 1, 1),
(45, 'Joseph Robinette', 'Biden Junior', 'Präsident', '030-1111155', '0176-1240011', 'joseph.biden@example.com', '158e732362f64510fd72eb06fb7de0c29350bfcb', 1, 1),
(46, 'George', 'Washington', 'Präsident', '030-1111111', '0176-1234567', 'george.washington@example.com', '87714e51593d49bb8fb6c8d30a8dbc8480057f95', 1, 1),
(47, 'John', 'Adams', 'Präsident', '030-1111112', '0176-1234568', 'john.adams@example.com', 'c95f67b11b7d68f81627fd43d82ac303d46899f7', 1, 1),
(48, 'Thomas', 'Jefferson', 'Präsident', '030-1111113', '0176-1234569', 'thomas.jefferson@example.com', '7df6f485fd81173ef767fd64102cc8fedcd266ae', 1, 1),
(49, 'James', 'Madison', 'Präsident', '030-1111114', '0176-1234570', 'james.madison@example.com', '7a711545ae4cade33e7db80232d8379619b50479', 1, 1),
(50, 'James', 'Monroe', 'Präsident', '030-1111115', '0176-1234571', 'james.monroe@example.com', '7604cb327ffbdf7ecacb283be39586c9b880b3ce', 1, 1);

DROP TABLE IF EXISTS `ort`;
CREATE TABLE `ort` (
  `PK_Ort` int(11) NOT NULL,
  `Stadt` varchar(255) DEFAULT NULL,
  `PLZ` varchar(10) DEFAULT NULL,
  `Straße` varchar(255) DEFAULT NULL,
  `Hausnummer` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `ort` (`PK_Ort`, `Stadt`, `PLZ`, `Straße`, `Hausnummer`) VALUES
(1, 'Berlin', '10115', 'Hauptstraße', '10'),
(2, 'Hamburg', '20095', 'Nebenstraße', '5'),
(3, 'München', '80331', 'Platz', '12'),
(4, 'Köln', '50667', 'Ring', '3'),
(5, 'Frankfurt', '60313', 'Weg', '8');

DROP TABLE IF EXISTS `priorität`;
CREATE TABLE `priorität` (
  `PK_Priorität` int(11) NOT NULL,
  `Prioritätsname` varchar(255) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `priorität` (`PK_Priorität`, `Prioritätsname`, `Beschreibung`) VALUES
(1, 'Hoch', 'Wichtige Aufgabe'),
(2, 'Mittel', 'Mittelwichtige Aufgabe'),
(3, 'Niedrig', 'Geringe Priorität'),
(4, 'Sehr Hoch', 'Sehr dringende Aufgabe'),
(5, 'Gering', 'Kann warten');

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

INSERT INTO `rechnung` (`Rechnungsnr`, `Ticketbeschreibung`, `Abrechnung`, `Ratenzahlung`, `FK_Bezahlungsart`, `FK_Kunde`, `FK_Ticket`) VALUES
(7, 'Serverproblem', 'Einmalzahlung', 0, 3, 5, 8),
(8, 'Lizenzfehler', 'Ratenzahlung (3 Monate)', 1, 5, 4, 9),
(9, 'Netzwerkproblem', 'Einmalzahlung', 0, 2, 2, 10),
(10, 'E-Mail Problem', 'Monatliche Abrechnung', 1, 6, 6, 11),
(11, 'VPN Zugriff', 'Jahresvertrag', 0, 1, 1, 12),
(12, 'Druckerproblem', 'Einmalzahlung', 0, 4, 3, 13),
(13, 'Hardwaredefekt', 'Ratenzahlung (6 Monate)', 1, 7, 7, 14),
(14, 'Test2', '0€', 0, 8, 2, 2),
(15, 'Sicherheitswarnung', 'Sicherheits-Checkup-Paket', 0, 8, 5, 16),
(16, 'Datenbankabsturz', 'Notfall-Support', 0, 2, 3, 17),
(17, 'Software Installation', 'Einmalzahlung', 0, 1, 2, 18),
(18, 'Fehlermeldung Windows', 'Monatliche Wartung', 1, 3, 3, 19),
(19, 'Netzwerk-Diagnose', 'Jahresvertrag', 0, 6, 7, 20),
(20, 'Account gesperrt', 'Einmalzahlung', 0, 2, 5, 21),
(21, 'Hardware-Aufrüstung', 'Ratenzahlung (3 Monate)', 1, 7, 6, 22),
(22, 'Firewall-Konfiguration', 'Einmalzahlung', 0, 4, 1, 23),
(23, 'tesdt', 'Rechnung für Ticket 46', 0, 2, 1, 46),
(24, 'ttest', 'Rechnung für Ticket 48', 0, 2, 1, 48),
(26, 'Hardwareproblem an PC', 'Rechnung für Ticket 4', 0, 2, 1, 4),
(31, 'Server läuft nicht richtigasdd', 'Rechnung für Ticket 1', 0, 2, 2, 1),
(32, 'Neues Netzwerk muss installiert werden', 'Rechnung für Ticket 3', 0, 2, 1, 3);

DROP TABLE IF EXISTS `rechtegruppe`;
CREATE TABLE `rechtegruppe` (
  `Administrationsrechte` tinyint(1) DEFAULT NULL,
  `Bestelllimit` decimal(10,2) DEFAULT NULL,
  `Helpdesk_Fernwartung` tinyint(1) DEFAULT NULL,
  `PK_Rechtegruppe` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `rechtegruppe` (`Administrationsrechte`, `Bestelllimit`, `Helpdesk_Fernwartung`, `PK_Rechtegruppe`) VALUES
(1, 1000.00, 1, 1),
(0, 500.00, 0, 2),
(1, 2000.00, 1, 3),
(0, 100.00, 0, 4),
(1, 1500.00, 0, 5);

DROP TABLE IF EXISTS `residiert`;
CREATE TABLE `residiert` (
  `FK_Kunde` int(11) NOT NULL,
  `FK_Ort` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `residiert` (`FK_Kunde`, `FK_Ort`) VALUES
(1, 1),
(2, 3),
(3, 2),
(4, 3),
(5, 4),
(6, 5),
(7, 4);

DROP TABLE IF EXISTS `session`;
CREATE TABLE `session` (
  `id` int(11) NOT NULL,
  `sessionhash` longtext NOT NULL,
  `expires_at` datetime NOT NULL,
  `inserted_at` datetime NOT NULL DEFAULT current_timestamp(),
  `FK_Mitarbeiter` int(11) NOT NULL,
  `FK_Kunde` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

DROP TABLE IF EXISTS `status`;
CREATE TABLE `status` (
  `PK_Status` int(11) NOT NULL,
  `Statusname` varchar(255) DEFAULT NULL,
  `Farbe` varchar(20) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

INSERT INTO `status` (`PK_Status`, `Statusname`, `Farbe`, `Beschreibung`) VALUES
(1, 'Offen', 'Gelb', 'Ticket ist offen'),
(2, 'In Bearbeitung', 'Gelb', 'Ticket in Bearbeitung'),
(3, 'Geschlossen', 'Grün', 'Ticket geschlossen'),
(4, 'Wartend', 'Blau', 'Wartet auf Antwort'),
(5, 'Archiviert', 'Grau', 'Ticket archiviert');

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

INSERT INTO `ticket` (`PK_Ticket`, `Ticket_Titel`, `Beschreibung`, `InterneNotiz`, `InternerStatus`, `Erstelldatum`, `Bearbeitungsdatum`, `FK_Status`, `FK_Priorität`, `FK_Art`, `FK_Mitarbeiter`, `FK_Kunde`) VALUES
(1, 'Problem mit Server', 'Server läuft nicht richtigasdd', 'Keine Notizasdd', 'Offenasddd', '2024-09-01 00:00:00', '2024-09-01 00:00:00', 5, 3, 2, 1, 2),
(2, 'Fehler in Software', 'Software gibt Fehler aus', 'Dringend', 'In Bearbeitung', '2024-09-02 00:00:00', '2024-09-03 00:00:00', 2, 2, 2, 2, 2),
(3, 'Netzwerkinstallation', 'Neues Netzwerk muss installiert werden', 'Kabel fehlen', 'Geschlossen', '2024-09-02 20:00:00', '2024-09-02 20:00:00', 3, 3, 3, 3, 1),
(4, 'TimonDefekt', 'Hardwareproblem an PC', 'Ersatzteil bestellt', 'Wartend', '2024-09-04 00:00:00', '2024-09-04 00:00:00', 1, 2, 3, 10, 5),
(8, 'Serverproblem', 'Der Server ist abgestürzt', 'Dringend prüfen', 'In Bearbeitung', '2025-03-18 10:15:00', '2025-03-18 11:30:00', 2, 4, 3, 12, 5),
(9, 'Lizenzfehler', 'Softwarelizenz ist abgelaufen', 'Kunde informieren', 'Wartend auf Antwort', '2025-03-17 14:00:00', NULL, 3, 2, 1, 23, 4),
(10, 'Netzwerkproblem', 'Keine Verbindung zum WLAN', 'Router-Check durchführen', 'In Bearbeitung', '2025-03-19 09:20:00', NULL, 1, 5, 2, 5, 2),
(11, 'E-Mail Problem', 'Kunde kann keine E-Mails empfangen', NULL, 'Offen', '2025-03-18 13:40:00', NULL, 4, 3, 6, 7, 6),
(12, 'VPN Zugriff', 'Mitarbeiter kann sich nicht ins VPN einloggen', 'Zugangsdaten überprüfen', 'Erledigt', '2025-03-16 08:30:00', '2025-03-16 10:00:00', 5, 1, 4, 30, 1),
(13, 'Druckerproblem', 'Drucker druckt nur leere Seiten', 'Toner oder Treiber prüfen', 'In Bearbeitung', '2025-03-19 12:00:00', NULL, 2, 3, 5, 15, 3),
(14, 'Hardwaredefekt', 'PC startet nicht mehr', 'Möglicher Hardware-Defekt', 'Wartend auf Ersatzteile', '2025-03-15 16:45:00', NULL, 3, 5, 2, 8, 7),
(15, 'Backup Fehler', 'Automatisches Backup schlägt fehl', NULL, 'Offen', '2025-03-18 22:10:00', NULL, 1, 4, 3, 40, 2),
(16, 'Sicherheitswarnung', 'Mitarbeiter erhielt verdächtige E-Mail', 'Phishing-Versuch untersuchen', 'Erledigt', '2025-03-19 06:55:00', '2025-03-19 07:30:00', 5, 2, 6, 22, 5),
(17, 'Datenbankabsturz', 'Kundendatenbank nicht erreichbar', 'Letztes Backup wiederherstellen', 'Dringend', '2025-03-19 04:20:00', NULL, 1, 5, 1, 9, 3),
(18, 'Software Installation', 'Benutzer benötigt neue Software auf PC', 'Installationsdateien bereitstellen', 'Offen', '2025-03-19 08:30:00', NULL, 3, 2, 1, 1, 2),
(19, 'Fehlermeldung Windows', 'Windows zeigt kritische Fehlermeldung an', 'Event-Logs prüfen', 'In Bearbeitung', '2025-03-18 12:15:00', NULL, 2, 4, 2, 1, 3),
(20, 'Netzwerk-Diagnose', 'Langsame Internetverbindung', 'Speed-Test und Router-Reset empfohlen', 'Offen', '2025-03-17 10:45:00', NULL, 1, 3, 5, 1, 7),
(21, 'Account gesperrt', 'Mitarbeiter kann sich nicht im System anmelden', 'Passwort zurücksetzen', 'Erledigt', '2025-03-18 09:10:00', '2025-03-18 09:30:00', 5, 1, 6, 1, 5),
(22, 'Hardware-Aufrüstung', 'Kunde benötigt mehr RAM für seinen Laptop', 'Kompatible Module prüfen', 'In Bearbeitung', '2025-03-16 15:20:00', NULL, 2, 5, 4, 1, 6),
(23, 'Firewall-Konfiguration', 'Firewall blockiert legitimen Traffic', 'Whitelist prüfen', 'Wartend auf Genehmigung', '2025-03-19 14:00:00', NULL, 4, 3, 3, 1, 1),
(46, 'TEsttest', 'tesdt', 'test', 'test', '2322-12-31 22:22:00', '2322-12-31 22:22:00', 1, 1, 1, 8, 1),
(48, 'test', 'ttest', 'test', 'test', '1212-12-12 12:12:00', '1212-12-12 12:12:00', 1, 1, 1, 2, 1);


ALTER TABLE `abgeleitet`
  ADD PRIMARY KEY (`FK_Dienstleistung`,`FK_Ticket`),
  ADD KEY `abgeleitet_ticket` (`FK_Ticket`);

ALTER TABLE `arbeitet`
  ADD PRIMARY KEY (`FK_Mitarbeiter`,`FK_Kunde`),
  ADD KEY `arbeitet_kunde` (`FK_Kunde`);

ALTER TABLE `art`
  ADD PRIMARY KEY (`PK_Art`);

ALTER TABLE `bearbeitet`
  ADD PRIMARY KEY (`FK_Mitarbeiter`,`FK_Ticket`),
  ADD KEY `bearbeitet_ticket` (`FK_Ticket`);

ALTER TABLE `bezahlungsart`
  ADD PRIMARY KEY (`PK_Bezahlungsart`);

ALTER TABLE `dienstleistung`
  ADD PRIMARY KEY (`PK_Dienstleistung`);

ALTER TABLE `kunde`
  ADD PRIMARY KEY (`PK_Kunde`);

ALTER TABLE `mitarbeiter`
  ADD PRIMARY KEY (`PK_Mitarbeiter`),
  ADD KEY `mitarbeiter_fk_1` (`FK_Ort`),
  ADD KEY `mitarbeiter_fk_2` (`FK_Rechtegruppe`);

ALTER TABLE `ort`
  ADD PRIMARY KEY (`PK_Ort`);

ALTER TABLE `priorität`
  ADD PRIMARY KEY (`PK_Priorität`);

ALTER TABLE `rechnung`
  ADD PRIMARY KEY (`Rechnungsnr`),
  ADD KEY `rechnung_fk_1` (`FK_Bezahlungsart`),
  ADD KEY `rechnung_fk_2` (`FK_Kunde`),
  ADD KEY `rechnung_fk_3` (`FK_Ticket`);

ALTER TABLE `rechtegruppe`
  ADD PRIMARY KEY (`PK_Rechtegruppe`);

ALTER TABLE `residiert`
  ADD PRIMARY KEY (`FK_Kunde`,`FK_Ort`),
  ADD KEY `residiert_ort` (`FK_Ort`);

ALTER TABLE `session`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Mitarbeiter` (`FK_Mitarbeiter`),
  ADD KEY `FK_Kunde` (`FK_Kunde`);

ALTER TABLE `status`
  ADD PRIMARY KEY (`PK_Status`);

ALTER TABLE `ticket`
  ADD PRIMARY KEY (`PK_Ticket`),
  ADD KEY `ticket_fk_1` (`FK_Status`),
  ADD KEY `ticket_fk_2` (`FK_Priorität`),
  ADD KEY `ticket_fk_3` (`FK_Art`),
  ADD KEY `ticket_fk_4` (`FK_Mitarbeiter`),
  ADD KEY `ticket_fk_5` (`FK_Kunde`);


ALTER TABLE `art`
  MODIFY `PK_Art` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

ALTER TABLE `bezahlungsart`
  MODIFY `PK_Bezahlungsart` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

ALTER TABLE `dienstleistung`
  MODIFY `PK_Dienstleistung` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

ALTER TABLE `kunde`
  MODIFY `PK_Kunde` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

ALTER TABLE `mitarbeiter`
  MODIFY `PK_Mitarbeiter` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

ALTER TABLE `ort`
  MODIFY `PK_Ort` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

ALTER TABLE `priorität`
  MODIFY `PK_Priorität` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

ALTER TABLE `rechnung`
  MODIFY `Rechnungsnr` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

ALTER TABLE `rechtegruppe`
  MODIFY `PK_Rechtegruppe` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

ALTER TABLE `session`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

ALTER TABLE `status`
  MODIFY `PK_Status` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

ALTER TABLE `ticket`
  MODIFY `PK_Ticket` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;


ALTER TABLE `abgeleitet`
  ADD CONSTRAINT `abgeleitet_dienstleistung` FOREIGN KEY (`FK_Dienstleistung`) REFERENCES `dienstleistung` (`PK_Dienstleistung`),
  ADD CONSTRAINT `abgeleitet_ticket` FOREIGN KEY (`FK_Ticket`) REFERENCES `ticket` (`PK_Ticket`);

ALTER TABLE `arbeitet`
  ADD CONSTRAINT `arbeitet_kunde` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`),
  ADD CONSTRAINT `arbeitet_mitarbeiter` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`);

ALTER TABLE `bearbeitet`
  ADD CONSTRAINT `bearbeitet_mitarbeiter` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`),
  ADD CONSTRAINT `bearbeitet_ticket` FOREIGN KEY (`FK_Ticket`) REFERENCES `ticket` (`PK_Ticket`);

ALTER TABLE `mitarbeiter`
  ADD CONSTRAINT `mitarbeiter_ort` FOREIGN KEY (`FK_Ort`) REFERENCES `ort` (`PK_Ort`),
  ADD CONSTRAINT `mitarbeiter_rechtegruppe` FOREIGN KEY (`FK_Rechtegruppe`) REFERENCES `rechtegruppe` (`PK_Rechtegruppe`);

ALTER TABLE `rechnung`
  ADD CONSTRAINT `rechnung_bezahlungsart` FOREIGN KEY (`FK_Bezahlungsart`) REFERENCES `bezahlungsart` (`PK_Bezahlungsart`),
  ADD CONSTRAINT `rechnung_kunde` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`),
  ADD CONSTRAINT `rechnung_ticket` FOREIGN KEY (`FK_Ticket`) REFERENCES `ticket` (`PK_Ticket`);

ALTER TABLE `residiert`
  ADD CONSTRAINT `residiert_kunde` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`),
  ADD CONSTRAINT `residiert_ort` FOREIGN KEY (`FK_Ort`) REFERENCES `ort` (`PK_Ort`);

ALTER TABLE `session`
  ADD CONSTRAINT `session_kunde` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`),
  ADD CONSTRAINT `session_mitarbeiter` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`);

ALTER TABLE `ticket`
  ADD CONSTRAINT `ticket_art` FOREIGN KEY (`FK_Art`) REFERENCES `art` (`PK_Art`),
  ADD CONSTRAINT `ticket_kunde` FOREIGN KEY (`FK_Kunde`) REFERENCES `kunde` (`PK_Kunde`),
  ADD CONSTRAINT `ticket_mitarbeiter` FOREIGN KEY (`FK_Mitarbeiter`) REFERENCES `mitarbeiter` (`PK_Mitarbeiter`),
  ADD CONSTRAINT `ticket_prioritaet` FOREIGN KEY (`FK_Priorität`) REFERENCES `priorität` (`PK_Priorität`),
  ADD CONSTRAINT `ticket_status` FOREIGN KEY (`FK_Status`) REFERENCES `status` (`PK_Status`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
