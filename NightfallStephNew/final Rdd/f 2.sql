-- database used
use Mega_Man_Final_Fantasy;
-- display columns and for total price is all of the shop price added up
select k.Kingdom_id,k.Kingdom_Name,CONCAT('$', FORMAT(sum(si.price), 2)) as Total_price
-- joins kingdom , elements, weapons and, shop inventory 
from ((Kingdoms k join Elements e on e.Element_ID = k.Element_ID) join weapons w on e.Element_ID = w.Weapon_Element_ID) 
join Shop_Inventory si on w.Weapon_id =w.Weapon_id
-- adds toghter same kingdoms that have many shops
group by k.Kingdom_id
-- kingdoms top price is more than 2500
having Total_price > CONCAT('$', FORMAT(2500, 2))
-- orders from greatest to smallest based on total price
order by Total_price desc