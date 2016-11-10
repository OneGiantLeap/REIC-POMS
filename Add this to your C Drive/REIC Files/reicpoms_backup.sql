-- MySqlBackup.NET 2.0.9.3
-- Dump Time: 2016-07-20 17:28:46
-- --------------------------------------
-- Server version 5.6.26 MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of customer_t
-- 

DROP TABLE IF EXISTS `customer_t`;
CREATE TABLE IF NOT EXISTS `customer_t` (
  `customer_id` int(11) NOT NULL,
  `business_name_style` varchar(40) DEFAULT NULL,
  `tin_number` char(15) DEFAULT NULL,
  `company_name` varchar(70) NOT NULL,
  `contact_person` varchar(70) NOT NULL,
  `contact_number` varchar(25) NOT NULL,
  `account_number` varchar(16) DEFAULT NULL,
  `email_address` varchar(50) NOT NULL,
  `address` varchar(255) NOT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table customer_t
-- 

/*!40000 ALTER TABLE `customer_t` DISABLE KEYS */;
INSERT INTO `customer_t`(`customer_id`,`business_name_style`,`tin_number`,`company_name`,`contact_person`,`contact_number`,`account_number`,`email_address`,`address`) VALUES
(1,'Logistics','222-887-919-888','AFG Company','Joy Hsien','09224445555','0251478498568754','joyhsien@afg.com','299 Tomas Morato Ave, Quezon City'),
(2,'Food','N/A','Harurot Co.','Auria M. Francisco','09999993371','N/A','afrancisco@harurot.com.ph','75 P. Domingo Street, Carmona, Makati City, 1207 Metro Manila'),
(3,'Logistics','N/A','EMP Company','Andres Ramos','7284878','8748224455558888','aramos@empcompany.com','7114 Kundiman Street, Sampaloc, 1008 Manila'),
(4,'N/A','888-222-555-777','Agetro Technologies','Romualdo Santos','09123456789','N/A','rsantos@agetro.com.ph','99 Commerce & Industry Plaza, 1030 Campus Avenue, Taguig, 1634 Metro Manila'),
(5,'Logistics','887-898-224-014','AVIS','Wilbert Ramos','502-3344','N/A','wilbertramos@avis.com.ph','Lot 4, Allegis IT Park, Carmelray Industrial Park 2, Makiling Dr, Tulo, Calamba, 4029 Laguna'),
(6,'IT','N/A','Villarica Enterprise','Mr. Villarica','(02) 285 2740','N/A','support@villarica.com.ph','3rd Floor, Lucky China Town Mall, Calle Felipe cor. La Chombre Streets Zone 28, Binondo, Manila, Metro Manila'),
(7,'IT','N/A','Indie Enterprises','Samuel H. Magtanggol','09123456789','N/A','sammagtanggol@indie.com.ph','641 A. Mabini St, Sangandaan, Caloocan, 1116 Metro Manila'),
(8,'Food','N/A','Food Group','Perlita A. Sanchez','09123456789','N/A','foodie@foodgroup.com.ph','Level 3, Cyberzone Building B, SM Megamall, EDSA, corner DoÃ±a Julia Vargas Ave., Wack-Wack Greenhills, Mandaluyong, 1550 Metro Manila'),
(9,'N/A','000-216-541-287','21/21 Co.','Pauline Abegonia','09123456789','N/A','pabegonia@2121company.com','95 Hermogenes Street, Sofia Subdivision, Del Pilar, San Fernando City, 2000 Pampanga'),
(10,'N/A','N/A','Balay Dako','Paolo Vasquez','09123456788','N/A','balaydako@yahoo.com.ph','40th Floor, Petron Mega Plaza, 358 Sen. Gil J. Puyat Ave, Makati, Metro Manila'),
(11,'Sports','N/A','Abencia & Co.','Lleonora Abencia','09153909781','N/A','labencia@yahoo.com','12/F Tower 2, the Enterprise Center, Paseo De Roxas Cor. Ayala Avenue, Makati City'),
(12,'IT','N/A','Telstra','Laura Lee','4317144','N/A','llee@telstra.com.ph','10-12/F 6256 Ayala Ave., Makati City'),
(13,'N/A','N/A','Joy Luck Club','Monica Roxas','4211111','N/A','mroxas@joyluckclub.com.ph','18 Adb Ave., Ortigas Center, Mandaluyong, 1550 Metro Manila'),
(14,'N/A','000-222-581-222','Dollar','Lorina Go','09153903333','N/A','lorinago@yahoo.com','National Highway, Barangay 19 San Lorenzo, San Nicolas, 2901 Ilocos Norte'),
(15,'N/A','N/A','Lucid Co.','Charita King','09156666666','N/A','lucidco@yahoo.com.ph','San Antonio, Pasig, 1605 Kalakhang Maynila'),
(16,'N/A','888-345-442-012','Colette''s Company','Colette Roden','09353403371','N/A','croden@colettes.com','8 Visayas Ave, Vasra Diliman, Quezon City, 1128 Metro Manila'),
(17,'N/A','265-777-888-999','VHM Co.','Ms. Christine Tan','09123456789','N/A','christinetan@vhm.com','Zuelig Building, Makati City'),
(18,'N/A','N/A','Prince Laharl and Co.','Laharl','+639665558966','N/A','overlord.laharl@info.com','The Netherworld');
/*!40000 ALTER TABLE `customer_t` ENABLE KEYS */;

-- 
-- Definition of item_t
-- 

DROP TABLE IF EXISTS `item_t`;
CREATE TABLE IF NOT EXISTS `item_t` (
  `part_number` varchar(11) NOT NULL,
  `item_name` varchar(35) NOT NULL,
  `item_description` text,
  `supplier_unit_price` double NOT NULL,
  `mark_up_percentage` int(11) NOT NULL,
  `reic_unit_price` double NOT NULL,
  `minimum_order_quantity` int(11) NOT NULL,
  `unit_of_measurement` varchar(10) NOT NULL,
  `from_date` date NOT NULL,
  `to_date` date NOT NULL,
  `supplier_id` int(11) NOT NULL,
  PRIMARY KEY (`part_number`),
  KEY `item_t_fk` (`supplier_id`),
  CONSTRAINT `item_t_fk` FOREIGN KEY (`supplier_id`) REFERENCES `supplier_t` (`supplier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table item_t
-- 

/*!40000 ALTER TABLE `item_t` DISABLE KEYS */;
INSERT INTO `item_t`(`part_number`,`item_name`,`item_description`,`supplier_unit_price`,`mark_up_percentage`,`reic_unit_price`,`minimum_order_quantity`,`unit_of_measurement`,`from_date`,`to_date`,`supplier_id`) VALUES
('000001','Aluminum Wire Bonders','Gold and aluminum wire bonding',100,35,135,1,'g','2016-04-18','2017-04-08',1),
('000002','Vacuum Sealer','A device or substance used to seal something',100,25,125,2,'g','2016-04-18','2017-04-18',1),
('000003','Paper Tapes','Holds data as patterns of punched holes',1234.75,15,1419.96,2,'g','2015-06-30','2016-06-30',2),
('000004','Extruded Magazine','Type of magazine',501,15,576.15,3,'lb','2015-11-21','2016-11-21',2),
('000005','Mold Press','Used to form and consolidate curds',3,10,3.3,4,'lb','2016-03-26','2016-04-26',3),
('000006','Raised Floor System','Provides an elevated structural floor above a solid substrate',9999.99,100,19999.98,1,'g','2015-07-15','2017-05-15',3),
('000007','Wirebonders','Interconnections between an integrated circuit (IC) or other semiconductor device',10,10,11,3,'lb','2016-04-18','2017-04-18',4),
('000008','Multifunctional Bond Testers','Semiconductor manufacturing equipment/material',3,10,3.3,3,'lb','2016-12-28','2017-12-28',4),
('000009','Test Handlers','Designed to perform in-circuit tests and functional tests on printed circuit boards',4,100,8,1,'lb','2016-01-18','2017-02-18',5),
('000010','Digital Flat Panel X-Ray','a class of solid-state x-ray digital radiography devices ',4,100,8,1,'lb','2016-02-18','2017-02-18',5),
('000011','Reed Relay','A type of relay that uses an electromagnet to control one or more reed switches',69.99,100,139.98,1,'g','2016-03-25','2017-03-25',6),
('000012','OEM Spare Replacement','Machine Tool OEM Parts',10,25,12.5,2,'lb','2016-04-23','2017-04-23',6),
('000013','Wafer Handling Tools','Handling Tools and Accessories for Wafer',30,100,60,4,'lb','2016-04-30','2017-05-31',7),
('000014','Embossed Tape and Reel Materials','Object around which lengths of another material (usually long and flexible) are wound for storage',4,100,8,1,'lb','2015-08-18','2016-08-18',7),
('000015','Industrial Cleaning Materials','Products that can be used for cleaning',4,100,8,1,'lb','2015-04-15','2016-04-15',8),
('000016','ESD and Clean Room Products','Products that can be used for cleaning',69.99,100,139.98,1,'g','2016-10-25','2017-10-25',9),
('000017','Extruded Carriers','Tool for transportation',10,20,12,3,'lb','2016-04-26','2016-04-30',9),
('000018','Corrugated Sheet','Suitable for any domestic, industrial or agricultural application',30,100,60,3,'lb','2016-04-05','2016-08-05',10),
('000019','Accessory of Corrugated Products','Other accessories for said product',4,100,8,1,'lb','2016-04-18','2017-04-18',10),
('000020','L-Style Holder','Tool for holding and storing',4,100,8,1,'lb','2016-05-18','2017-05-19',11),
('000021','Corrugated Box','Corrugated fiberboard boxes with the functional physical, processing and end-use requirements',100,35,135,1,'g','2016-01-18','2016-12-18',11),
('000022','ESD PDB Rack','Tool for holding and storing',100,25,125,2,'g','2016-04-18','2017-04-08',12),
('000023','Condor Sigma','Most advanced bond tester on the market',1234.75,15,1419.96,2,'g','2016-02-14','2016-07-14',12),
('000024','Magazine Rack','Tool for holding and storing',501,15,576.15,1,'lb','2015-04-18','2017-04-18',13),
('000025','Hang ESD PSB Racks','Tool for holding and storing',3,10,3.3,3,'lb','2015-11-05','2017-11-05',13),
('002342','Potato','',7,15,8.05,1,'pck','2016-07-10','2016-07-13',18),
('218419','Crimson Wand','Really red, really crimson.',100899,60,161438.4,1,'pc','2015-07-19','2016-07-19',19),
('556888','Superior Wire Bonders','Fully automatic, thermosonic',1888,50,2832,1,'lb','2016-05-18','2016-08-18',5),
('585878','Regular Wire Bonders','Strong and superior',86,75,150.5,1,'lb','2016-05-18','2016-05-21',5);
/*!40000 ALTER TABLE `item_t` ENABLE KEYS */;

-- 
-- Definition of po_order_line_t
-- 

DROP TABLE IF EXISTS `po_order_line_t`;
CREATE TABLE IF NOT EXISTS `po_order_line_t` (
  `po_no` char(8) NOT NULL,
  `part_number` varchar(11) NOT NULL,
  `supplier_unit_price` double NOT NULL,
  `quantity` int(11) NOT NULL,
  `item_total` double NOT NULL,
  PRIMARY KEY (`po_no`,`part_number`),
  KEY `po_order_line_t_fk2` (`part_number`),
  CONSTRAINT `po_order_line_t_fk1` FOREIGN KEY (`po_no`) REFERENCES `po_t` (`po_no`),
  CONSTRAINT `po_order_line_t_fk2` FOREIGN KEY (`part_number`) REFERENCES `item_t` (`part_number`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table po_order_line_t
-- 

/*!40000 ALTER TABLE `po_order_line_t` DISABLE KEYS */;
INSERT INTO `po_order_line_t`(`po_no`,`part_number`,`supplier_unit_price`,`quantity`,`item_total`) VALUES
('0905-001','000013',30,3,90),
('0905-001','000014',4,2,8),
('0905-001','000015',4,3,12),
('1002-001','000011',69.99,5,349.95),
('1002-001','000012',10,2,20),
('1103-001','000007',10,4,40),
('1103-001','000008',3,3,9),
('1204-001','000005',3,2,6),
('1204-001','000006',9999.99,4,39999.96),
('1304-001','000003',1234.75,1,1234.75),
('1304-001','000004',501,1,501),
('1504-001','000001',100,3,300),
('1504-001','000002',100,2,200),
('1603-001','000009',4,5,20),
('1603-001','000010',4,2,8);
/*!40000 ALTER TABLE `po_order_line_t` ENABLE KEYS */;

-- 
-- Definition of po_t
-- 

DROP TABLE IF EXISTS `po_t`;
CREATE TABLE IF NOT EXISTS `po_t` (
  `po_no` char(8) NOT NULL,
  `order_date` date NOT NULL,
  `required_delivery_date` date NOT NULL,
  `order_description` text,
  `pq_no` char(8) NOT NULL,
  `payment_terms` varchar(7) NOT NULL,
  `delivery_terms` varchar(8) NOT NULL,
  `net_item_subtotal` double NOT NULL,
  `delivery_cost` double DEFAULT NULL,
  `order_total` double NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `so_no` int(11) DEFAULT NULL,
  PRIMARY KEY (`po_no`),
  KEY `po_t_fk1` (`customer_id`),
  KEY `po_t_fk2` (`supplier_id`),
  KEY `po_t_fk3` (`pq_no`),
  KEY `po_t_fk4` (`so_no`),
  CONSTRAINT `po_t_fk1` FOREIGN KEY (`customer_id`) REFERENCES `customer_t` (`customer_id`),
  CONSTRAINT `po_t_fk2` FOREIGN KEY (`supplier_id`) REFERENCES `supplier_t` (`supplier_id`),
  CONSTRAINT `po_t_fk3` FOREIGN KEY (`pq_no`) REFERENCES `pq_t` (`pq_no`),
  CONSTRAINT `po_t_fk4` FOREIGN KEY (`so_no`) REFERENCES `sidr_t` (`so_no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table po_t
-- 

/*!40000 ALTER TABLE `po_t` DISABLE KEYS */;
INSERT INTO `po_t`(`po_no`,`order_date`,`required_delivery_date`,`order_description`,`pq_no`,`payment_terms`,`delivery_terms`,`net_item_subtotal`,`delivery_cost`,`order_total`,`supplier_id`,`customer_id`,`so_no`) VALUES
('0905-001','2009-05-10','2009-05-20','Object around which lengths of another material (usually long and flexible) are wound for storage','0905-001','15 Days','FOB',89.9,100,189.9,7,7,1001),
('1002-001','2010-02-16','2010-02-28','Machine Tool OEM Parts','1002-001','COD','CIF',1077,100,1177,6,6,1002),
('1103-001','2011-03-27','2011-04-05','Interconnections between an integrated circuit (IC) or other semiconductor device','1103-001','30 Days','DAP',53.9,100,153.9,4,5,1003),
('1204-001','2012-04-07','2012-04-15','Provides an elevated structural floor above a solid substrate','1204-001','15 Days','FOB',200055.9,100,200155.9,3,4,1004),
('1304-001','2013-04-30','2013-05-10','Holds data as patterns of punched holes','1304-001','30 Days','DAP',12325.98,100,12425.98,2,3,1005),
('1504-001','2015-04-10','2015-04-17','Aluminum wire bonding','1504-001','15 Days','FOB',4250,200,4250,1,1,1006),
('1603-001','2016-03-17','2016-03-24','Designed to perform in-circuit tests and functional tests on printed circuit boards','1603-001','COD','CIF',160,100,260,5,8,1007),
('1604-001','2016-04-17','2016-04-30',NULL,'1603-001','15 Days','FOB',1234.75,500,1734.75,15,10,NULL);
/*!40000 ALTER TABLE `po_t` ENABLE KEYS */;

-- 
-- Definition of pq_order_line_t
-- 

DROP TABLE IF EXISTS `pq_order_line_t`;
CREATE TABLE IF NOT EXISTS `pq_order_line_t` (
  `pq_no` char(8) NOT NULL,
  `part_number` varchar(11) NOT NULL,
  `reic_unit_price` double NOT NULL,
  `quantity` int(11) NOT NULL,
  `item_total` double NOT NULL,
  PRIMARY KEY (`pq_no`,`part_number`),
  KEY `pq_order_line_t_fk2` (`part_number`),
  CONSTRAINT `pq_order_line_t_fk1` FOREIGN KEY (`pq_no`) REFERENCES `pq_t` (`pq_no`),
  CONSTRAINT `pq_order_line_t_fk2` FOREIGN KEY (`part_number`) REFERENCES `item_t` (`part_number`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pq_order_line_t
-- 

/*!40000 ALTER TABLE `pq_order_line_t` DISABLE KEYS */;
INSERT INTO `pq_order_line_t`(`pq_no`,`part_number`,`reic_unit_price`,`quantity`,`item_total`) VALUES
('0608-001','000020',8,3,24),
('0704-001','000018',60,3,180),
('0704-001','000019',8,7,56),
('0804-001','000016',139.98,5,699.9),
('0804-001','000017',12,7,84),
('0905-001','000013',60,3,180),
('0905-001','000014',8,7,56),
('0905-001','000015',8,3,24),
('1002-001','000011',139.98,5,699.9),
('1002-001','000012',12.5,7,87.5),
('1103-001','000007',11,4,44),
('1103-001','000008',3.3,3,9.9),
('1204-001','000005',3.3,17,56.1),
('1204-001','000006',9999.99,10,199999.8),
('1304-001','000003',1419.96,3,4259.88),
('1304-001','000004',576.15,14,8066.1),
('1504-001','000001',125,25,3125),
('1504-001','000002',125,7,875),
('1603-001','000009',8,5,40),
('1603-001','000010',8,15,120),
('1605-001','000006',19999.98,1,19999.98),
('1605-002','000024',576.15,4,2304.6),
('1605-002','000025',3.3,1,3.3),
('1605-003','000023',1419.96,23,32659.08),
('1605-004','000024',576.15,3,1728.45),
('1605-005','000023',1419.96,23,32659.08),
('1605-006','000024',576.15,3,1728.45),
('1605-007','000013',60,1,60),
('1605-007','000014',8,1,8),
('1607-001','218419',161438.4,3,484315.2),
('1607-002','000024',576.15,4,2304.6),
('1607-002','000025',3.3,1,3.3);
/*!40000 ALTER TABLE `pq_order_line_t` ENABLE KEYS */;

-- 
-- Definition of pq_t
-- 

DROP TABLE IF EXISTS `pq_t`;
CREATE TABLE IF NOT EXISTS `pq_t` (
  `pq_no` char(8) NOT NULL,
  `pq_date` date NOT NULL,
  `from_date` date NOT NULL,
  `to_date` date NOT NULL,
  `payment_terms` varchar(7) NOT NULL,
  `delivery_terms` varchar(8) NOT NULL,
  `bill_to` varchar(8) NOT NULL,
  `ship_to` varchar(8) NOT NULL,
  `in_favor_of` varchar(8) NOT NULL,
  `total_amount` double NOT NULL,
  `customer_id` int(11) NOT NULL,
  PRIMARY KEY (`pq_no`),
  KEY `pq_t_fk` (`customer_id`),
  CONSTRAINT `pq_t_fk` FOREIGN KEY (`customer_id`) REFERENCES `customer_t` (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pq_t
-- 

/*!40000 ALTER TABLE `pq_t` DISABLE KEYS */;
INSERT INTO `pq_t`(`pq_no`,`pq_date`,`from_date`,`to_date`,`payment_terms`,`delivery_terms`,`bill_to`,`ship_to`,`in_favor_of`,`total_amount`,`customer_id`) VALUES
('0608-001','2006-08-25','2006-08-25','2006-12-25','30 Days','DAP','REIC','Customer','REIC',24,10),
('0704-001','2007-04-05','2007-04-05','2007-07-05','15 Days','FOB','REIC','Customer','REIC',236,9),
('0804-001','2008-04-25','2008-04-25','2009-05-25','30 Days','DAP','REIC','Customer','REIC',783.9,8),
('0905-001','2009-05-05','2009-05-05','2010-07-15','15 Days','FOB','REIC','Customer','REIC',260,7),
('1002-001','2010-02-14','2010-02-14','2011-05-14','COD','CIF','REIC','Customer','REIC',787.4,6),
('1103-001','2011-03-25','2011-03-25','2012-03-25','30 Days','DAP','REIC','Customer','REIC',53.9,5),
('1204-001','2012-04-05','2012-04-05','2013-04-05','15 Days','FOB','REIC','Customer','REIC',200055.9,4),
('1304-001','2013-04-25','2013-04-25','2014-04-25','30 Days','DAP','REIC','Customer','REIC',12325.98,3),
('1504-001','2015-04-05','2015-04-05','2016-04-05','15 Days','FOB','REIC','Customer','REIC',4250,1),
('1603-001','2016-03-14','2016-03-14','2016-05-14','COD','CIF','REIC','Customer','REIC',160,8),
('1605-001','2016-05-15','2016-05-15','2017-05-15','15 Days','Ex-works','Customer','Customer','Supplier',19999.98,16),
('1605-002','2016-05-17','2016-05-15','2017-05-15','15 Days','CIF','REIC','REIC','Customer',2307.9,1),
('1605-003','2016-05-18','2016-05-18','2016-08-18','COD','CIF','Customer','Customer','REIC',32659.08,13),
('1605-004','2016-05-18','2016-05-18','2016-05-21','COD','FOB','Customer','Customer','Supplier',1728.45,6),
('1605-005','2016-05-18','2016-05-18','2016-05-21','COD','CIF','Customer','Customer','REIC',32659.08,13),
('1605-006','2016-05-18','2016-05-18','2016-05-28','COD','FOB','Customer','Customer','REIC',1728.45,6),
('1605-007','2016-05-18','2016-05-18','2016-06-18','COD','Ex-works','REIC','Customer','REIC',68,12),
('1607-001','2016-07-19','2016-07-12','2016-07-19','15 Days','DAP','REIC','Customer','REIC',484315.2,18),
('1607-002','2016-07-19','2016-07-04','2016-07-19','15 Days','CIF','Customer','Customer','REIC',2307.9,1);
/*!40000 ALTER TABLE `pq_t` ENABLE KEYS */;

-- 
-- Definition of rfq_order_line_t
-- 

DROP TABLE IF EXISTS `rfq_order_line_t`;
CREATE TABLE IF NOT EXISTS `rfq_order_line_t` (
  `rfq_no` char(8) NOT NULL,
  `part_number` varchar(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  PRIMARY KEY (`rfq_no`,`part_number`),
  KEY `rfq_order_line_t_fk2` (`part_number`),
  CONSTRAINT `rfq_order_line_t_fk1` FOREIGN KEY (`rfq_no`) REFERENCES `rfq_t` (`rfq_no`),
  CONSTRAINT `rfq_order_line_t_fk2` FOREIGN KEY (`part_number`) REFERENCES `item_t` (`part_number`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table rfq_order_line_t
-- 

/*!40000 ALTER TABLE `rfq_order_line_t` DISABLE KEYS */;
INSERT INTO `rfq_order_line_t`(`rfq_no`,`part_number`,`quantity`) VALUES
('0608-001','000020',3),
('0704-001','000018',3),
('0704-001','000019',7),
('0804-001','000016',5),
('0804-001','000017',7),
('0905-001','000013',3),
('0905-001','000014',7),
('0905-001','000015',3),
('1002-001','000011',5),
('1002-001','000012',7),
('1103-001','000007',4),
('1103-001','000008',3),
('1204-001','000005',17),
('1204-001','000006',10),
('1304-001','000003',3),
('1304-001','000004',14),
('1504-001','000001',25),
('1504-001','000002',7),
('1508-001','218419',3),
('1603-001','000009',5),
('1603-001','000010',15),
('1605-001','000025',4),
('1605-002','000014',1),
('1605-003','000013',3),
('1605-004','000013',1),
('1605-004','000014',3),
('1605-005','000011',1),
('1605-005','000012',5),
('1605-006','000005',8),
('1605-006','000006',1),
('1605-007','000009',3),
('1605-007','000010',4),
('1605-008','000020',1),
('1605-008','000021',3),
('1605-009','000018',4),
('1605-009','000019',3),
('1605-010','000007',4),
('1605-010','000008',2),
('1605-011','000022',5),
('1605-011','000023',2),
('1605-012','000011',1),
('1605-012','000012',1),
('1605-013','000023',23),
('1605-014','000020',4),
('1605-014','000021',9),
('1605-015','000024',4),
('1605-015','000025',1),
('1605-016','000024',3),
('1605-017','000001',5),
('1605-017','000002',9),
('1605-018','000013',1),
('1605-018','000014',1),
('1605-019','585878',10);
/*!40000 ALTER TABLE `rfq_order_line_t` ENABLE KEYS */;

-- 
-- Definition of rfq_t
-- 

DROP TABLE IF EXISTS `rfq_t`;
CREATE TABLE IF NOT EXISTS `rfq_t` (
  `rfq_no` char(8) NOT NULL,
  `date_of_request` date NOT NULL,
  `payment_terms` varchar(7) NOT NULL,
  `delivery_terms` varchar(8) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `pq_no` char(8) DEFAULT NULL,
  PRIMARY KEY (`rfq_no`),
  KEY `rfq_t_fk1` (`customer_id`),
  KEY `rfq_t_fk2` (`supplier_id`),
  KEY `rfq_t_fk3` (`pq_no`),
  CONSTRAINT `rfq_t_fk1` FOREIGN KEY (`customer_id`) REFERENCES `customer_t` (`customer_id`),
  CONSTRAINT `rfq_t_fk2` FOREIGN KEY (`supplier_id`) REFERENCES `supplier_t` (`supplier_id`),
  CONSTRAINT `rfq_t_fk3` FOREIGN KEY (`pq_no`) REFERENCES `pq_t` (`pq_no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table rfq_t
-- 

/*!40000 ALTER TABLE `rfq_t` DISABLE KEYS */;
INSERT INTO `rfq_t`(`rfq_no`,`date_of_request`,`payment_terms`,`delivery_terms`,`customer_id`,`supplier_id`,`pq_no`) VALUES
('0608-001','2006-08-25','30 Days','DAP',10,10,'0608-001'),
('0704-001','2007-04-05','15 Days','FOB',9,9,'0704-001'),
('0804-001','2008-04-25','15 Days','DAP',8,8,'0804-001'),
('0905-001','2009-05-05','15 Days','FOB',7,7,'0905-001'),
('1002-001','2010-02-14','COD','CIF',6,6,'1002-001'),
('1103-001','2011-03-25','30 Days','DAP',5,4,'1103-001'),
('1204-001','2012-04-05','15 Days','FOB',4,3,'1204-001'),
('1304-001','2013-04-25','30 Days','DAP',3,2,'1304-001'),
('1504-001','2015-04-05','15 Days','FOB',1,1,'1504-001'),
('1508-001','2015-08-01','15 Days','DAP',18,19,NULL),
('1603-001','2016-03-14','COD','CIF',8,5,'1603-001'),
('1605-001','2016-05-12','COD','Ex-works',4,13,NULL),
('1605-002','2016-05-12','60 Days','FOB',12,7,NULL),
('1605-003','2016-05-14','COD','DAP',11,7,NULL),
('1605-004','2016-05-14','COD','FOB',2,7,NULL),
('1605-005','2016-05-14','15 Days','Ex-works',9,6,NULL),
('1605-006','2016-05-14','30 Days','FOB',7,3,NULL),
('1605-007','2016-05-14','30 Days','DAP',13,5,NULL),
('1605-008','2016-05-14','30 Days','Ex-works',6,11,NULL),
('1605-009','2016-05-14','15 Days','FOB',10,10,NULL),
('1605-010','2016-05-14','30 Days','FOB',15,4,NULL),
('1605-011','2016-05-14','15 Days','Ex-works',3,12,NULL),
('1605-012','2016-05-14','15 Days','FOB',8,6,NULL),
('1605-013','2016-05-14','COD','CIF',13,12,NULL),
('1605-014','2016-05-14','15 Days','Ex-works',3,11,NULL),
('1605-015','2016-05-14','15 Days','CIF',1,13,NULL),
('1605-016','2016-05-16','COD','FOB',6,14,NULL),
('1605-017','2016-05-16','30 Days','DAP',12,1,NULL),
('1605-018','2016-05-18','COD','Ex-works',12,7,NULL),
('1605-019','2016-05-18','COD','FOB',17,5,NULL),
('1607-001','2016-07-10','COD','FOB',9,6,NULL);
/*!40000 ALTER TABLE `rfq_t` ENABLE KEYS */;

-- 
-- Definition of sidr_order_line_t
-- 

DROP TABLE IF EXISTS `sidr_order_line_t`;
CREATE TABLE IF NOT EXISTS `sidr_order_line_t` (
  `so_no` int(11) NOT NULL,
  `part_number` varchar(11) NOT NULL,
  `reic_unit_price` double NOT NULL,
  `quantity` int(11) NOT NULL,
  `item_total` double NOT NULL,
  PRIMARY KEY (`so_no`,`part_number`),
  KEY `sidr_order_line_t_fk2` (`part_number`),
  CONSTRAINT `sidr_order_line_t_fk1` FOREIGN KEY (`so_no`) REFERENCES `sidr_t` (`so_no`),
  CONSTRAINT `sidr_order_line_t_fk2` FOREIGN KEY (`part_number`) REFERENCES `item_t` (`part_number`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table sidr_order_line_t
-- 

/*!40000 ALTER TABLE `sidr_order_line_t` DISABLE KEYS */;
INSERT INTO `sidr_order_line_t`(`so_no`,`part_number`,`reic_unit_price`,`quantity`,`item_total`) VALUES
(1001,'000013',60,3,180),
(1001,'000014',8,2,16),
(1001,'000015',8,3,24),
(1002,'000011',139.98,5,699.9),
(1002,'000012',12.5,2,25),
(1003,'000007',11,4,44),
(1003,'000008',3.3,3,9.9),
(1004,'000005',3.3,2,6.6),
(1004,'000006',19999.98,2,39999.96),
(1005,'000003',1419.96,3,4259.88),
(1005,'000004',576.15,1,576.15),
(1006,'000001',135,2,270),
(1006,'000002',125,3,375),
(1007,'000009',8,5,40),
(1007,'000010',8,1,8);
/*!40000 ALTER TABLE `sidr_order_line_t` ENABLE KEYS */;

-- 
-- Definition of sidr_t
-- 

DROP TABLE IF EXISTS `sidr_t`;
CREATE TABLE IF NOT EXISTS `sidr_t` (
  `so_no` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `so_date` date NOT NULL,
  `delivery_terms` varchar(8) NOT NULL,
  `customer_po_no` char(15) NOT NULL,
  `si_no` int(11) NOT NULL,
  `dr_no` int(11) NOT NULL,
  `total_sales` double NOT NULL,
  `vat_sales` double NOT NULL,
  `add_12_percent_vat` double NOT NULL,
  `invoice_total` double NOT NULL,
  PRIMARY KEY (`so_no`),
  KEY `sidr_t_fk` (`customer_id`),
  CONSTRAINT `sidr_t_fk` FOREIGN KEY (`customer_id`) REFERENCES `customer_t` (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table sidr_t
-- 

/*!40000 ALTER TABLE `sidr_t` DISABLE KEYS */;
INSERT INTO `sidr_t`(`so_no`,`customer_id`,`so_date`,`delivery_terms`,`customer_po_no`,`si_no`,`dr_no`,`total_sales`,`vat_sales`,`add_12_percent_vat`,`invoice_total`) VALUES
(1001,7,'2009-05-21','FOB','S09-00020061',2006,2006,220,0,26.4,220),
(1002,6,'2010-02-21','CIF','33400',2005,2005,724.9,0,86.99,724.9),
(1003,5,'2011-03-31','DAP','2011-03-004',2004,2004,53.9,0,6.47,53.9),
(1004,4,'2012-04-15','FOB','20042',2003,2003,40006.56,0,4800.79,40006.56),
(1005,3,'2013-05-06','DAP','130506012',2002,2002,4836.03,0,580.32,4836.03),
(1006,1,'2015-04-16','FOB','2015041603',2001,2001,645,0,77.4,645),
(1007,8,'2016-03-26','CIF','03262016-01',2000,2000,48,0,5.76,48);
/*!40000 ALTER TABLE `sidr_t` ENABLE KEYS */;

-- 
-- Definition of supplier_t
-- 

DROP TABLE IF EXISTS `supplier_t`;
CREATE TABLE IF NOT EXISTS `supplier_t` (
  `supplier_id` int(11) NOT NULL,
  `supplier_name` varchar(70) NOT NULL,
  `contact_person` varchar(70) NOT NULL,
  `contact_number` varchar(25) NOT NULL,
  `email_address` varchar(50) NOT NULL,
  `address` varchar(255) NOT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table supplier_t
-- 

/*!40000 ALTER TABLE `supplier_t` DISABLE KEYS */;
INSERT INTO `supplier_t`(`supplier_id`,`supplier_name`,`contact_person`,`contact_number`,`email_address`,`address`) VALUES
(1,'Gulf Machine Supplies','A. Baum','4268-54-72','baum@gulfss.com','5089 Calero Avenue'),
(2,'Twenty-First Century Materials','D.W. Kadarauch','760541','kadarauch@21centurymats.com','103 Harriet Street'),
(3,'Precision Products','Elisabete Regis Guillaumon','(02)570517','erguillaumon@precision.com','Rua Dona Antonia De Queiros 381, Sao Paolo'),
(4,'Impact Enterprises','Gunther Spielmann','213445','gspielmann@yahoo.com','Mechitaristengasse 5, Vienna'),
(5,'Western Technological Supply','W.E. Macdonald','3762855','macdonald@wts.com','5063 Richmond Mall, Vancouver'),
(6,'Lone Star State Research Suppliers','Charles Baron','512/478-0788','cbaron@lonestar.com','198 Fayetteville Road, Memphis'),
(7,'ABC Company','Shannon Cu','09102345371','scu@abccompany.com.ph','8839 Ventura Blvd., Blanchetown'),
(8,'Balibago Tire Center','Precious Marie','09777543213','balibagomarie@hotmail.com','45 Block 2 Corner Gumamela St. Diliman QC'),
(9,'Plasticell','Emily Rose','143341','plasticell@yahoo.com','1 Corner Potato St. Makati City'),
(10,'Ocram Marketing','Prima Lou','4302871','primalou@yahoo.com','543 Serendra Bldg. Taguig City'),
(11,'Electrak Corporation','Kara Somera','2723296','karasomera@hotmail.com','28 Morgan St. Katipunan Avenue'),
(12,'Novelink Inc.','Jennylyn Sta. Ana','6916969','jennylynstaana@hotmail.com','96 Majalay St. Cubao QC'),
(13,'Forms International Ent., Corp','Natasha White','3110653','nwhite@hotmail.com','46 Red St. Novaliches QC'),
(14,'Walk In Builders Depot','Sasha Maria','4553552','sashamaria@yahoo.com','123 Fairview Terraces Avenue'),
(15,'GGEZ Technologies','Gigi Layug','3112113','ggezhello@yahoo.com','2 Corner St. Pasig City'),
(16,'Impaq Corporation','Mr. Impaq','09224547895','support@impaq.com','Paseo de Roxas, Makati City'),
(17,'Wilcon Builders Depot','Mr. Almario','09123456789','support@wilcon.com','Taguig City'),
(18,'Accent Micro Technologies, Inc.','Izza Abriera','09325867890','izza.abriera@amti.com.ph','8th Floor, Philippine Stock Exchange Building, East Tower, Ortigas Center, Pasig City'),
(19,'RosenQueen Co.','Rozalin','+639665156872','rozalin@rosenqueen.com','Veldime');
/*!40000 ALTER TABLE `supplier_t` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2016-07-20 17:28:46
-- Total time: 0:0:0:0:184 (d:h:m:s:ms)
