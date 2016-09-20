-- database used
use Mega_Man_Final_Fantasy;
-- display colunoms with name of the monthn
select c.Character_ID,c.Character_name,monthname(gs.Save_Date_Time) as Q1,r.Room_name
-- joins character, game states, character and, rooms
from (Characters c join Game_States gs on c.Character_ID = gs.Character_ID)
 join Rooms r on r.Room_id = gs.Room_id
 -- game saves within first quator of year and are in first party
where (month(gs.Save_Date_Time) between 1 and 3) && inParty in (select inParty
-- tables used in the subquery
from Characters
-- in the first patry
where inParty = 1)