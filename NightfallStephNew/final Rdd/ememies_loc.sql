-- database used
use Mega_Man_Final_Fantasy;

-- view is like a table 
-- detale view if its there
create or replace view ememy_Loc as
-- columns form table that view makes
select e.Enemy_id,gs.Game_state_id,r.Room_id, e.Enemy_name, e.Health_point, r.Room_name
-- jions enemies, enemy assignment, rooms and, games states 
from ((Enemies e join Enemy_assignmen ea on e.Enemy_id = ea.Enemy_id) 
join  Rooms r on r.Room_id = ea.Room_id) 
join Game_States gs on r.Room_id = gs.Room_id; 

-- counts enemy in the enemy 
select count(Enemy_id) as Enemies_Number,Room_id, Room_name 
-- from enemy loc view 
from ememy_Loc
-- adds up enemy in same room
group by Room_id
-- greatest to smallest by number room
order by Enemies_Number desc