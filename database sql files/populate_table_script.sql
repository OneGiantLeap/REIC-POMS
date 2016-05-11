/*REIC POMS SAMPLE CONTENT*/

/*
Suppliers: 15 done
Items: 25 done
Customers: 15 done
RFQ: 10 done
RFQ OL: 20 done
PQ: 10 done  
PQ OL: 20 done
PO: 7 done ---> Order description
PO OL: 15 done
SIDR: 7 done
SIDR OL: 15 done

ARRANGEMENT (Strictly like this due to the filled FKs)
supplier_t
item_t
customer_t
pq_t
pq_order_line_t
sidr_t
sidr_order_line_t
po_t
po_order_line_t
rfq_t
rfq_order_line_t
*/

/*SUPPLIERS*/
INSERT INTO supplier_t
(supplier_id, supplier_name, contact_person, contact_number, email_address, address)
VALUES
(1, 'Gulf Machine Supplies', 'A. Baum', '4268-54-72', 'baum@gulfss.com', '5089 Calero Avenue'),
(2, 'Twenty-First Century Materials', 'D.W. Kadarauch', '760541', 'kadarauch@21centurymats.com', '103 Harriet Street'),
(3, 'Precision Products', 'Elisabete Regis Guillaumon', '(02)570517', 'erguillaumon@precision.com', 'Rua Dona Antonia De Queiros 381, Sao Paolo'),
(4, 'Impact Enterprises', 'Gunther Spielmann', '213445', 'gspielmann@yahoo.com', 'Mechitaristengasse 5, Vienna'),
(5, 'Western Technological Supply', 'W.E. Macdonald', '3762855', 'macdonald@wts.com', '5063 Richmond Mall, Vancouver'),

(6, 'Lone Star State Research Suppliers', 'Charles Baron', '512/478-0788', 'cbaron@lonestar.com', '198 Fayetteville Road, Memphis'),
(7, 'ABC Company', 'Shannon Cu', '09102345371', 'scu@abccompany.com.ph', '8839 Ventura Blvd., Blanchetown'),
(8, 'Balibago Tire Center', 'Precious Marie', '09777543213', 'balibagomarie@hotmail.com', '45 Block 2 Corner Gumamela St. Diliman QC'),
(9, 'Plasticell', 'Emily Rose', '143341', 'plasticell@yahoo.com', '1 Corner Potato St. Makati City'),
(10, 'Ocram Marketing', 'Prima Lou', '4302871', 'primalou@yahoo.com', '543 Serendra Bldg. Taguig City'),

(11, 'Electrak Corporation', 'Kara Somera', '2723296', 'karasomera@hotmail.com', '28 Morgan St. Katipunan Avenue'),
(12, 'Novelink Inc.', 'Jennylyn Sta. Ana', '6916969', 'jennylynstaana@hotmail.com', '96 Majalay St. Cubao QC'),
(13, 'Forms International Ent., Corp', 'Natasha White', '3110653', 'nwhite@hotmail.com', '46 Red St. Novaliches QC'),
(14, 'Walk In Builders Depot', 'Sasha Maria', '4553552', 'sashamaria@yahoo.com', '123 Fairview Terraces Avenue'),
(15, 'GGEZ Technologies', 'Gigi Layug', '3112113', 'ggezhello@yahoo.com', '2 Corner St. Pasig City');

/*ITEMS*/
INSERT INTO item_t
(part_number, item_name, item_description, supplier_unit_price, mark_up_percentage, reic_unit_price, minimum_order_quantity, unit_of_measurement, from_date, to_date, supplier_id)
VALUES
('000001', 'Aluminum Wire Bonders', 'Gold and aluminum wire bonding', 100, 35, 135, 1, 'g', '2016-04-18', '2017-04-08',  1),
('000002', 'Vacuum Sealer', 'A device or substance used to seal something', 100, 25, 125, 2, 'g', '2016-04-18', '2017-04-18', 1),
('000003', 'Paper Tapes', 'Holds data as patterns of punched holes', 1234.75, 15, 1419.96, 2, 'g', '2015-06-30', '2016-06-30',  2),
('000004', 'Extruded Magazine', 'Type of magazine', 501, 15, 576.15, 3, 'lb', '2015-11-21', '2016-11-21', 2),
('000005', 'Mold Press', 'Used to form and consolidate curds', 3, 10, 3.30, 4, 'lb', '2016-03-26', '2016-04-26', 3),

('000006', 'Raised Floor System', 'Provides an elevated structural floor above a solid substrate', 9999.99, 100, 19999.98, 1, 'g', '2015-07-15', '2017-05-15', 3),
('000007', 'Wirebonders', 'Interconnections between an integrated circuit (IC) or other semiconductor device', 10, 10, 11, 3, 'lb', '2016-04-18', '2017-04-18', 4),
('000008', 'Multifunctional Bond Testers', 'Semiconductor manufacturing equipment/material', 3, 10, 3.30, 3, 'lb', '2016-12-28', '2017-12-28', 4),
('000009', 'Test Handlers', 'Designed to perform in-circuit tests and functional tests on printed circuit boards', 4, 100, 8, 1, 'lb', '2016-01-18', '2017-02-18', 5),
('000010', 'Digital Flat Panel X-Ray', 'a class of solid-state x-ray digital radiography devices ', 4, 100, 8, 1, 'lb', '2016-02-18', '2017-02-18', 5),

('000011', 'Reed Relay', 'A type of relay that uses an electromagnet to control one or more reed switches', 69.99, 100, 139.98, 1, 'g', '2016-03-25', '2017-03-25', 6),
('000012', 'OEM Spare Replacement', 'Machine Tool OEM Parts', 10, 25, 12.50, 2, 'lb', '2016-04-23', '2017-04-23',  6),
('000013', 'Wafer Handling Tools', 'Handling Tools and Accessories for Wafer', 30, 100, 60, 4, 'lb', '2016-04-30', '2017-05-31', 7),
('000014', 'Embossed Tape and Reel Materials', 'Object around which lengths of another material (usually long and flexible) are wound for storage', 4, 100, 8, 1, 'lb', '2015-08-18', '2016-08-18', 7),
('000015', 'Industrial Cleaning Materials', 'Products that can be used for cleaning', 4, 100, 8, 1, 'lb', '2015-04-15', '2016-04-15', 8),

('000016', 'ESD and Clean Room Products', 'Products that can be used for cleaning', 69.99, 100, 139.98, 1, 'g', '2016-10-25', '2017-10-25', 9),
('000017', 'Extruded Carriers', 'Tool for transportation', 10, 20, 12, 3, 'lb', '04/23/2016', '04/28/2016',  9),
('000018', 'Corrugated Sheet', 'Suitable for any domestic, industrial or agricultural application', 30, 100, 60, 3, 'lb', '2016-04-05', '2016-08-05', 10),
('000019', 'Accessory of Corrugated Products', 'Other accessories for said product', 4, 100, 8, 1, 'lb', '2016-04-18', '2017-04-18', 10),
('000020', 'L-Style Holder', 'Tool for holding and storing', 4, 100, 8, 1, 'lb', '2016-05-18', '2017-05-19', 11),

('000021', 'Corrugated Box', 'Corrugated fiberboard boxes with the functional physical, processing and end-use requirements', 100, 35, 135, 1, 'g', '2016-01-18', '2016-12-18', 11),
('000022', 'ESD PDB Rack', 'Tool for holding and storing', 100, 25, 125, 2, 'g', '2016-04-18', '2017-04-08', 12),
('000023', 'Condor Sigma', 'Most advanced bond tester on the market', 1234.75, 15, 1419.96, 2, 'g', '2016-02-14', '2016-07-14', 12),
('000024', 'Magazine Rack', 'Tool for holding and storing', 501, 15, 576.15, 1, 'lb', '2015-04-18', '2017-04-18', 13),
('000025', 'Hang ESD PSB Racks', 'Tool for holding and storing', 3, 10, 3.30, 3, 'lb', '2015-11-05', '2017-11-05', 13);

/*CUSTOMERS*/
INSERT INTO customer_t
(customer_id, business_name_style, tin_number, company_name, contact_person, contact_number, account_number, email_address, address)
VALUES
(1, 'Logistics', '2242-8887-9199-8848', 'AFG Company', 'Joy Hsien', '09224445555', '0251478498568754', 'joyhsien@afg.com', '299 Tomas Morato Ave, Quezon City'),
(2, 'Food', 'N/A', 'Harurot Co.', 'Auria M. Francisco', '09999993371', 'N/A', 'afrancisco@harurot.com.ph', '75 P. Domingo Street, Carmona, Makati City, 1207 Metro Manila'),
(3, 'Logistics', 'N/A', 'EMP Company', 'Andres Ramos', '7284878', '8748224455558888', 'aramos@empcompany.com', '7114 Kundiman Street, Sampaloc, 1008 Manila'),
(4, 'N/A', '8888-2222-5555-7777', 'Agetro Technologies', 'Romualdo Santos', '09123456789', 'N/A', 'rsantos@agetro.com.ph', '99 Commerce & Industry Plaza, 1030 Campus Avenue, Taguig, 1634 Metro Manila'),
(5, 'Logistics', '8887-8798-2224-0154', 'AVIS', 'Wilbert Ramos', '502-3344', 'N/A', 'wilbertramos@avis.com.ph', 'Lot 4, Allegis IT Park, Carmelray Industrial Park 2, Makiling Dr, Tulo, Calamba, 4029 Laguna'),

(6, 'IT', 'N/A', 'Villarica Enterprise', 'Mr. Villarica', '(02) 285 2740', 'N/A', 'support@villarica.com.ph', '3rd Floor, Lucky China Town Mall, Calle Felipe cor. La Chombre Streets Zone 28, Binondo, Manila, Metro Manila'),
(7, 'IT', 'N/A', 'Indie Enterprises', 'Samuel H. Magtanggol', '09123456789', 'N/A', 'sammagtanggol@indie.com.ph', '641 A. Mabini St, Sangandaan, Caloocan, 1116 Metro Manila'),
(8, 'Food', 'N/A', 'Food Group', 'Perlita A. Sanchez', '09123456789', 'N/A', 'foodie@foodgroup.com.ph', 'Level 3, Cyberzone Building B, SM Megamall, EDSA, corner Doña Julia Vargas Ave., Wack-Wack Greenhills, Mandaluyong, 1550 Metro Manila'),
(9, 'N/A', '0000-2156-5841-2587', '21/21 Co.', 'Pauline Abegonia', '09123456789', 'N/A', 'pabegonia@2121company.com', '95 Hermogenes Street, Sofia Subdivision, Del Pilar, San Fernando City, 2000 Pampanga'),
(10, 'N/A', 'N/A', 'Balay Dako', 'Paolo Vasquez', '09123456788', 'N/A', 'balaydako@yahoo.com.ph', '40th Floor, Petron Mega Plaza, 358 Sen. Gil J. Puyat Ave, Makati, Metro Manila'),

(11, 'Sports', 'N/A', 'Abencia & Co.', 'Lleonora Abencia', '09153909781', 'N/A', 'labencia@yahoo.com', '12/F Tower 2, the Enterprise Center, Paseo De Roxas Cor. Ayala Avenue, Makati City'),
(12, 'IT', 'N/A', 'Telstra', 'Laura Lee', '4317144', 'N/A', 'llee@telstra.com.ph', '10-12/F 6256 Ayala Ave., Makati City'),
(13, 'N/A', 'N/A', 'Joy Luck Club', 'Monica Roxas', '4211111', 'N/A', 'mroxas@joyluckclub.com.ph', '18 Adb Ave., Ortigas Center, Mandaluyong, 1550 Metro Manila'),
(14, 'N/A', '0000-2222-5841-2222', 'Dollar', 'Lorina Go', '09153903333', 'N/A', 'lorinago@yahoo.com', 'National Highway, Barangay 19 San Lorenzo, San Nicolas, 2901 Ilocos Norte'),
(15, 'N/A', 'N/A', 'Lucid Co.', 'Charita King', '09156666666', 'N/A', 'lucidco@yahoo.com.ph', 'San Antonio, Pasig, 1605 Kalakhang Maynila');

/*PQ - PRICE QUOTATION*/
INSERT INTO pq_t
(pq_no, pq_date, from_date, to_date, payment_terms, delivery_terms, bill_to, ship_to, in_favor_of, total_amount, customer_id)
VALUES
('0608-001', '2006-08-25', '2006-08-25','2006-12-25', '30 Days', 'DAP','REIC', 'Customer', 'REIC', 24, 10),
('0704-001', '2007-04-05', '2007-04-05','2007-07-05', '15 Days', 'FOB','REIC', 'Customer', 'REIC', 236.00, 9),
('0804-001', '2008-04-25', '2008-04-25', '2009-05-25', '30 Days', 'DAP','REIC', 'Customer', 'REIC',  783.90, 8),
('0905-001', '2009-05-05', '2009-05-05','2010-07-15', '15 Days', 'FOB','REIC', 'Customer', 'REIC',  260, 7),
('1002-001', '2010-02-14', '2010-02-14','2011-05-14', 'COD', 'CIF', 'REIC', 'Customer', 'REIC', 787.40, 6),

('1103-001', '2011-03-25', '2011-03-25','2012-03-25', '30 Days', 'DAP', 'REIC', 'Customer', 'REIC', 53.90, 5),
('1204-001', '2012-04-05', '2012-04-05', '2013-04-05', '15 Days', 'FOB', 'REIC', 'Customer', 'REIC', 200055.90, 4),
('1304-001', '2013-04-25', '2013-04-25','2014-04-25','30 Days', 'DAP', 'REIC', 'Customer', 'REIC', 12325.98, 3),
('1504-001', '2015-04-05', '2015-04-05', '2016-04-05','15 Days', 'FOB', 'REIC', 'Customer', 'REIC', 4250, 1),
('1603-001', '2016-03-14', '2016-03-14', '2016-05-14', 'COD', 'CIF','REIC', 'Customer', 'REIC', 160, 8);

/*PQ - PRICE QUOTATION - ORDER LINES TO THE CUSTOMER*/
INSERT INTO pq_order_line_t
(pq_no, part_number, reic_unit_price, quantity, item_total)
VALUES
('0608-001', '000020', 8, 3, 24),
('0704-001', '000018', 60, 3, 180),
('0704-001', '000019', 8, 7, 56),
('0804-001', '000016', 139.98, 5, 699.90),
('0804-001', '000017', 12, 7, 84),

('0905-001', '000013', 60, 3, 180),
('0905-001', '000014', 8, 7, 56),
('0905-001', '000015', 8, 3, 24),
('1002-001', '000011', 139.98, 5, 699.90),
('1002-001', '000012', 12.50, 7, 87.50),

('1103-001', '000007', 11, 4, 44),
('1103-001', '000008', 3.30, 3, 9.90),
('1204-001', '000005', 3.30, 17, 56.10),
('1204-001', '000006', 9999.99, 10, 199999.80),
('1304-001', '000003', 1419.96, 3, 4259.88),

('1304-001', '000004', 576.15, 14, 8066.10),
('1504-001', '000001', 125, 25, 3125),
('1504-001', '000002', 125, 7, 875),
('1603-001', '000009', 8, 5, 40),
('1603-001', '000010', 8, 15, 120);

/*SIDR - SALES INVOICE & DELIVERY RECEIPT*/
INSERT INTO sidr_t
(so_no, customer_id, so_date, delivery_terms, customer_po_no, si_no, dr_no, total_sales, vat_sales, add_12_percent_vat, invoice_total)
/*Made up Customer PO No. sample data; copied from Fuji Electric's PO to ATPI*/
/*NOT SURE how Invoice Total is supposed to be... (Compare the screens and the sample printout PDF*/
VALUES
('1001', 7, '2009-05-21','FOB', 'S09-00020061', '2006','2006', 220, 0, 26.4, 220),
('1002', 6, '2010-02-21', 'CIF', '33400', '2005','2005', 724.90, 0, 86.99, 724.90),
('1003', 5, '2011-03-31', 'DAP',  '2011-03-004', '2004', '2004', 53.90, 0, 6.47, 53.90),
('1004', 4, '2012-04-15','FOB', '20042', '2003', '2003', 40006.56, 0, 4800.79, 40006.56),
('1005', 3, '2013-05-06', 'DAP', '130506012', '2002', '2002', 4836.03, 0, 580.32, 4836.03),

('1006', 1, '2015-04-16', 'FOB', '2015041603', '2001', '2001', 645, 0, 77.40, 645),
('1007', 8, '2016-03-26', 'CIF', '03262016-01', '2000','2000', 48, 0, 5.76, 48);

/*SIDR - ORDER LINES*/
INSERT INTO sidr_order_line_t
(so_no, part_number, reic_unit_price, quantity, item_total)
VALUES 
('1001', '000013', 60, 3, 180),
('1001', '000014', 8, 2, 16),
('1001', '000015', 8, 3, 24),
('1002', '000011', 139.98, 5, 699.90),
('1002', '000012', 12.50, 2, 25),

('1003', '000007', 11, 4, 44),
('1003', '000008', 3.30, 3, 9.90),
('1004', '000005', 3.30, 2, 6.60),
('1004', '000006', 19999.98, 2, 39999.96),
('1005', '000004', 576.15, 1, 576.15),

('1005', '000003', 1419.96, 3, 4259.88),
('1006', '000001', 135, 2, 270),
('1006', '000002', 125, 3, 375),
('1007', '000009', 8, 5, 40),
('1007', '000010', 8, 1, 8);

/*PO - PURCHASE ORDER - To the SUPPLIER */
INSERT INTO po_t
(po_no, order_date, required_delivery_date, order_description, pq_no, payment_terms, delivery_terms, net_item_subtotal, delivery_cost, order_total, customer_id, supplier_id, so_no)
VALUES
('0905-001', '2009-05-10','2009-05-20','Object around which lengths of another material (usually long and flexible) are wound for storage', '0905-001','15 Days', 'FOB', 89.90, 100, 189.90, 7, 7, 1001),
('1002-001', '2010-02-16','2010-02-28','Machine Tool OEM Parts', '1002-001', 'COD', 'CIF', 1077, 100, 1177, 6, 6, 1002),
('1103-001', '2011-03-27','2011-04-05', 'Interconnections between an integrated circuit (IC) or other semiconductor device', '1103-001','30 Days', 'DAP',  53.90, 100, 153.90, 5, 4, 1003),
('1204-001', '2012-04-07',  '2012-04-15','Provides an elevated structural floor above a solid substrate', '1204-001', '15 Days', 'FOB',  200055.90, 100, 200155.90, 4, 3, 1004),
('1304-001', '2013-04-30',  '2013-05-10','Holds data as patterns of punched holes', '1304-001','30 Days', 'DAP', 12325.98, 100, 12425.98, 3, 2, 1005),

('1504-001', '2015-04-10', '2015-04-17', 'Aluminum wire bonding', '1504-001','15 Days', 'FOB',  4250, 200, 4250, 1, 1, 1006),
('1603-001', '2016-03-17', '2016-03-24', 'Designed to perform in-circuit tests and functional tests on printed circuit boards', '1603-001', 'COD', 'CIF', 160, 100, 260, 8, 5, 1007);

/*PO - PURCHASE ORDER - ORDER LINES - To the Supplier */
INSERT INTO po_order_line_t
(po_no, part_number, supplier_unit_price, quantity, item_total)
VALUES ('0905-001', '000013', 30, 3, 90),
('0905-001', '000014', 4, 2, 8),
('0905-001', '000015', 4, 3, 12),
('1002-001', '000011', 69.99, 5, 349.95),
('1002-001', '000012', 10, 2, 20),

('1103-001', '000007', 10, 4, 40),
('1103-001', '000008', 3, 3, 9),
('1204-001', '000005', 3, 2, 6),
('1204-001', '000006', 9999.99, 4, 39999.96),
('1304-001', '000003', 1234.75, 1, 1234.75),

('1304-001', '000004', 501, 1, 501),
('1504-001', '000001', 100, 3, 300),
('1504-001', '000002', 100, 2, 200),
('1603-001', '000009', 4, 5, 20),
('1603-001', '000010', 4, 2, 8);

/*RFQ - REQUESTS FOR PRICE QUOTATION*/
INSERT INTO rfq_t
(rfq_no, date_of_request, payment_terms, delivery_terms, customer_id, supplier_id, pq_no)
VALUES
('0608-001', '2006-08-25', '30 Days', 'DAP', 10, 10, '0608-001'),
('0704-001', '2007-04-05', '15 Days', 'FOB', 9, 9, '0704-001'),
('0804-001', '2008-04-25', '15 Days', 'DAP', 8, 8, '0804-001'),
('0905-001', '2009-05-05', '15 Days', 'FOB', 7, 7, '0905-001'),
('1002-001', '2010-02-14', 'COD', 'CIF', 6, 6, '1002-001'),

('1103-001', '2011-03-25', '30 Days', 'DAP', 5, 4, '1103-001'),
('1204-001', '2012-04-05', '15 Days', 'FOB', 4, 3, '1204-001'),
('1304-001', '2013-04-25', '30 Days', 'DAP', 3, 2, '1304-001'),
('1504-001', '2015-04-05', '15 Days', 'FOB', 1, 1, '1504-001'),
('1603-001', '2016-03-14', 'COD', 'CIF', 8, 5, '1603-001');

/*RFQ - REQUESTS FOR PRICE QUOTATION - ORDER LINES*/
INSERT INTO rfq_order_line_t
(rfq_no, part_number, quantity)
VALUES
('0608-001', '000020', 3),
('0704-001', '000018', 3),
('0704-001', '000019', 7),
('0804-001', '000016', 5),
('0804-001', '000017', 7),

('0905-001', '000013', 3),
('0905-001', '000014', 7),
('0905-001', '000015', 3),
('1002-001', '000011', 5),
('1002-001', '000012', 7),

('1103-001', '000007', 4),
('1103-001', '000008', 3),
('1204-001', '000005', 17),
('1204-001', '000006', 10),
('1304-001', '000004', 14),

('1304-001', '000003', 3),
('1504-001', '000001', 25),
('1504-001', '000002', 7),
('1603-001', '000009', 5),
('1603-001', '000010', 15);