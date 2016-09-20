-- database used
use Mega_Man_Final_Fantasy;
-- display columns about the character
select Character_ID,Character_name,
-- adds a Characters Health, defense, items that have can restore health
-- with all of there Armor
Health_points + Defense + HP_Number + Armor_Total  as Total_Health
-- makes a table with columns
-- id of character and value of restore item they on them
from (select c.Character_ID,trim(substring(substring_index(it.Item_desc," ",2),
locate(" ",substring_index(it.Item_desc," ",2)),4)) as HP_Number,
-- columns used to in subquery table , adds up all of Characters armor
c.Character_name,c.Health_points , c.Defense , sum(a.Defense) as Armor_Total
-- joins armor, char armor, characters,inventories,char inventory, and items
from (((Armor a join Char_Armor ca on a.Armor_id = ca.Armor_id) 
join Characters c on c.Character_ID = ca.Character_ID) 
join Inventories inv on inv.Inventory_id = c.Char_Inventory_id) 
join Items it on it.Item_id = inv.Inventory_id
-- add togther with same name
group by Character_id)  SpaceCat
-- orders form highest to greatest based on there total health
order by Total_Health desc;