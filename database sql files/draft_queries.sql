/*ITEM DETAILS TAB - ITEM SEARCH*/
#Filtered by Item Name
SELECT part_number, item_name, item_description, unit_of_measurement, supplier_unit_price 
FROM item_t, supplier_t 
WHERE supplier_t.supplier_id = {0} 
AND item_t.supplier_id = supplier_t.supplier_id 
AND item_name LIKE '%{1}%';

#Filtered by Part Number
SELECT part_number, item_name, item_description, unit_of_measurement, TRUNCATE(supplier_unit_price, 2) 
FROM item_t, supplier_t 
WHERE supplier_t.supplier_id = {0} 
AND item_t.supplier_id = supplier_t.supplier_id
AND part_number LIKE '%{1}%';

SELECT part_number, item_name, item_description, unit_of_measurement, TRUNCATE(supplier_unit_price, 2) 
FROM item_t, supplier_t 
WHERE supplier_t.supplier_id =  1
AND item_t.supplier_id = supplier_t.supplier_id
AND part_number LIKE '%01%';