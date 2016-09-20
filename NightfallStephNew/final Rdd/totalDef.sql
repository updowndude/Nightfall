-- databased
use Mega_Man_Final_Fantasy;

-- testing
-- drop procedure defense_find;

-- changes the delimiter
delimiter //
-- makes a procedure
create  procedure defense_find (
-- takes in character di
in person_id int)
begin 

-- makes variables for a person defense
declare armor_def int;
declare person_def int;

-- adds up a character defense
select sum(a.Defense)
-- jions armor and char armor
from Armor a join Char_Armor cha on a.Armor_id = cha.Armor_id
-- gets only the person they when 
where cha.Character_ID = person_id into armor_def;

-- if don't have armor that value is set to 0
select ifnull(armor_def,0) into armor_def;

-- gets a defense
select Defense
-- from characters 
from Characters
-- gets only the person they when
where character_id = person_id into person_def;

-- adds them togther and display the result
select armor_def + person_def as Total_Defense;

-- ends the procedure
end //
-- changes the delimiter
delimiter ;

-- what character a person when to see there defense
call defense_find(1);