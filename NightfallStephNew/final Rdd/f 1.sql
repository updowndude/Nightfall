-- database used
use Mega_Man_Final_Fantasy;
-- display columns
select e.Enemy_id,e.Enemy_name,ex.Points_to_Next, s.Shop_ID,s.City
-- jions shop, shop inventorym weapons, enemies, and experience
from (((Shops s join Shop_Inventory si on s.Shop_ID = si.Shop_ID) join weapons w 
on w.Weapon_id = si.Weapon_id) join Enemies e on w.Weapon_id = e.Weapon_id) join Experience ex on ex.Level_ID = e.Experience_id
-- orders from greatest to smallest based on there experinece
order by ex.Points_to_Next desc