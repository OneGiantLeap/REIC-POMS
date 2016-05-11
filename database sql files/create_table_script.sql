Drop database reicpoms;
create database reicpoms;
use reicpoms;

CREATE TABLE supplier_t
(supplier_id INTEGER NOT NULL,
supplier_name VARCHAR(70) NOT NULL,
contact_person VARCHAR(70) NOT NULL,
contact_number VARCHAR(25) NOT NULL,
email_address VARCHAR(50) NOT NULL,
address VARCHAR(255) NOT NULL,
CONSTRAINT supplier_t_pk PRIMARY KEY (supplier_id));

CREATE TABLE item_t
(part_number VARCHAR(11) NOT NULL,
item_name VARCHAR(35) NOT NULL,
item_description TEXT,
supplier_unit_price DOUBLE NOT NULL,
mark_up_percentage INTEGER NOT NULL,
reic_unit_price DOUBLE NOT NULL,
minimum_order_quantity INTEGER NOT NULL,
unit_of_measurement VARCHAR(10) NOT NULL,
from_date DATE NOT NULL,
to_date DATE NOT NULL,
supplier_id INTEGER NOT NULL,
CONSTRAINT item_t_pk PRIMARY KEY (part_number),
CONSTRAINT item_t_fk FOREIGN KEY (supplier_id) REFERENCES supplier_t(supplier_id));

CREATE TABLE customer_t
(customer_id INTEGER NOT NULL,
business_name_style VARCHAR(40),
tin_number CHAR(15),
company_name VARCHAR(70) NOT NULL,
contact_person VARCHAR(70) NOT NULL,
contact_number VARCHAR(25) NOT NULL,
account_number VARCHAR(16),
email_address VARCHAR(50) NOT NULL,
address VARCHAR(255) NOT NULL,
CONSTRAINT customer_t_pk PRIMARY KEY (customer_id));

CREATE TABLE pq_t
(pq_no CHAR(8) NOT NULL,
pq_date DATE NOT NULL,
/*rfq_no CHAR(8) NOT NULL, -> FK is now on the many side, RFQ (051016)*/
from_date DATE NOT NULL,
to_date DATE NOT NULL,
payment_terms VARCHAR(7) NOT NULL,
delivery_terms VARCHAR(8) NOT NULL,
bill_to VARCHAR(8) NOT NULL, /*Pending Tita (051016)*/
ship_to VARCHAR(8) NOT NULL,
in_favor_of VARCHAR(8) NOT NULL,
total_amount DOUBLE NOT NULL,
customer_id INTEGER NOT NULL,
CONSTRAINT pq_t_pk PRIMARY KEY (pq_no),
CONSTRAINT pq_t_fk FOREIGN KEY (customer_id) REFERENCES customer_t(customer_id));

CREATE TABLE pq_order_line_t
(pq_no CHAR(8) NOT NULL,
part_number VARCHAR(11) NOT NULL, 
reic_unit_price DOUBLE NOT NULL, /*Added (051016)*/
quantity INTEGER NOT NULL,
item_total DOUBLE NOT NULL, /*Added (051016)*/
CONSTRAINT pq_order_line_t_pk PRIMARY KEY (pq_no, part_number),
CONSTRAINT pq_order_line_t_fk1 FOREIGN KEY (pq_no) REFERENCES pq_t(pq_no),
CONSTRAINT pq_order_line_t_fk2 FOREIGN KEY (part_number) REFERENCES item_t(part_number));

CREATE TABLE sidr_t
(so_no INTEGER NOT NULL,
customer_id INTEGER NOT NULL,
so_date DATE NOT NULL,
delivery_terms VARCHAR(8) NOT NULL,
customer_po_no CHAR(15) NOT NULL, /*Specified it's Customer's (051016); based char size from Fuji Electric's PO to ATPI*/
si_no INTEGER NOT NULL,
dr_no INTEGER NOT NULL,
total_sales DOUBLE NOT NULL, /*Moved from SIDR-OL (051016)*/
vat_sales DOUBLE NOT NULL, /*Moved from SIDR-OL (051016)*/
add_12_percent_vat DOUBLE NOT NULL, /*Moved from SIDR-OL (051016)*/
invoice_total DOUBLE NOT NULL,
CONSTRAINT sidr_t_pk PRIMARY KEY (so_no),
/*CONSTRAINT sidr_t_fk1 FOREIGN KEY (po_no) REFERENCES po_t(po_no), Removed as FK (051016)*/
CONSTRAINT sidr_t_fk FOREIGN KEY (customer_id) REFERENCES customer_t(customer_id));

CREATE TABLE sidr_order_line_t
(so_no INT NOT NULL,
part_number VARCHAR(11) NOT NULL,
reic_unit_price DOUBLE NOT NULL, /*Added (051016)*/
quantity INTEGER NOT NULL,
item_total DOUBLE NOT NULL, /*Added (051016)*/
CONSTRAINT sidr_order_line_t_pk PRIMARY KEY (so_no, part_number),
CONSTRAINT sidr_order_line_t_fk1 FOREIGN KEY (so_no) REFERENCES sidr_t(so_no),
CONSTRAINT sidr_order_line_t_fk2 FOREIGN KEY (part_number) REFERENCES item_t(part_number));

CREATE TABLE po_t
(po_no CHAR(8) NOT NULL,
order_date DATE NOT NULL,
required_delivery_date DATE NOT NULL,
order_description TEXT,
pq_no CHAR(8) NOT NULL,
payment_terms VARCHAR(7) NOT NULL,
/*account_number VARCHAR(16),*/
delivery_terms VARCHAR(8) NOT NULL,
net_item_subtotal DOUBLE NOT NULL,
delivery_cost DOUBLE,
order_total DOUBLE NOT NULL,
supplier_id INTEGER NOT NULL,
customer_id INTEGER NOT NULL,
so_no INTEGER, /*Added (051016)*/
CONSTRAINT po_t_pk PRIMARY KEY (po_no),
CONSTRAINT po_t_fk1 FOREIGN KEY (customer_id) REFERENCES customer_t(customer_id),
CONSTRAINT po_t_fk2 FOREIGN KEY (supplier_id) REFERENCES supplier_t(supplier_id), /*Added (051016)*/
CONSTRAINT po_t_fk3 FOREIGN KEY (pq_no) REFERENCES pq_t(pq_no),
CONSTRAINT po_t_fk4 FOREIGN KEY (so_no) REFERENCES sidr_t(so_no)); /*Added (051016)*/

CREATE TABLE po_order_line_t
(po_no CHAR(8) NOT NULL,
part_number VARCHAR(11) NOT NULL,
supplier_unit_price DOUBLE NOT NULL, /*Added (051016)*/
quantity INTEGER NOT NULL,
item_total DOUBLE NOT NULL,
CONSTRAINT po_order_line_t_pk PRIMARY KEY (po_no, part_number),
CONSTRAINT po_order_line_t_fk1 FOREIGN KEY (po_no) REFERENCES po_t(po_no),
CONSTRAINT po_order_line_t_fk2 FOREIGN KEY (part_number) REFERENCES item_t(part_number));

CREATE TABLE rfq_t
(rfq_no CHAR(8) NOT NULL,
date_of_request DATE NOT NULL,
payment_terms VARCHAR(7) NOT NULL,
/*account_number VARCHAR(16), -> No longer needed */
delivery_terms VARCHAR(8) NOT NULL,
customer_id INTEGER NOT NULL,
supplier_id INTEGER NOT NULL,
pq_no CHAR(8) NOT NULL, /*Not Null for SPR needs*/
CONSTRAINT rfq_t_pk PRIMARY KEY (rfq_no),
CONSTRAINT rfq_t_fk1 FOREIGN KEY (customer_id) REFERENCES customer_t(customer_id),
CONSTRAINT rfq_t_fk2 FOREIGN KEY (supplier_id) REFERENCES supplier_t(supplier_id),
CONSTRAINT rfq_t_fk3 FOREIGN KEY (pq_no) REFERENCES pq_t(pq_no)); /*Added (051016)*/

CREATE TABLE rfq_order_line_t
(rfq_no CHAR(8) NOT NULL,
part_number VARCHAR(11) NOT NULL,
quantity INTEGER NOT NULL,
CONSTRAINT rfq_order_line_t_pk PRIMARY KEY (rfq_no, part_number),
CONSTRAINT rfq_order_line_t_fk1 FOREIGN KEY (rfq_no) REFERENCES rfq_t(rfq_no),
CONSTRAINT rfq_order_line_t_fk2 FOREIGN KEY (part_number) REFERENCES item_t(part_number));
