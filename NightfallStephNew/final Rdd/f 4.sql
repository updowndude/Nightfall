-- database used
use Mega_Man_Final_Fantasy;

-- testing deletes triggers
-- drop trigger Monster_Count_Update;
-- drop trigger Monster_Count_Insert;

-- changes delimiter
delimiter //
-- sql sever you can both in one trigger 
-- makes trigger
-- same for the other tirgger but instead of insert is an update
create  trigger Monster_Count_Insert
-- works after a person as added enemey
after insert on Enemy_assignmen
-- works on every row
for each row
begin

-- makes a variable count of eneenys
declare RoomEnemyCount_Insert int;

-- makes a cloumns with the number of enemnys
select count(Enemy_id) into RoomEnemyCount_Insert
-- tables used
from Enemy_assignmen
-- current room a person in
where Room_id = new.Room_id;

-- more than 4 enemenys where in room
if RoomEnemyCount_Insert > 4 then
-- error for when count is above 4
signal sqlstate '22003' set message_text = 'Max number of enemies is four', mysql_errno = 7777;  
-- ends the if statement
end if;

-- ends trigger
end//
-- change back the delimiter
delimiter ;

delimiter //
create  trigger Monster_Count_Update
after update on Enemy_assignmen
for each row
begin

declare RoomEnemyCount_Update int;

select count(Enemy_id) into RoomEnemyCount_Update
from Enemy_assignmen
where Room_id = new.Room_id;

if RoomEnemyCount_Update > 4 then
signal sqlstate '22003' set message_text = 'Max number of enemies is four', mysql_errno = 7777;  
end if;

end//
delimiter ;

-- adds a new enemny
insert into Enemy_assignmen values
-- what thoses values should be
(default,1,3);