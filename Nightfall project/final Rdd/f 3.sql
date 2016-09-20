-- database used
use Mega_Man_Final_Fantasy;

-- testing deletes the function
-- drop function Main_Character;

-- changes the delimiter
delimiter //
-- makes a new funcation
create  function Main_Character (
-- take in number which is character id
 person_id int,
 -- what that name should be 
 newName varchar(30))
 -- what the return type is 
 returns varchar(30)
begin

-- makes variable
declare message varchar(30);

-- updates characters
update Characters
-- with new name 
set Character_name = newName
-- which chacter user whens to change
where Character_ID = person_id;

-- see if character they have entered is a main character
if  isMain in (select isMain
-- what table is used in the subquery
from Characters 
-- gets what character they have entered
where Character_ID = person_id) = 1 then
-- display a message
set message = 'Main Character was updated' ;
-- wasn't the main
else
-- dsiplay a message
set message =  'Normal character was updated';
-- close the if statement
end if;

-- get back message
return (message);
-- close funcation
end //
-- change back the delimiete
delimiter ;

-- test the funcation
select Main_Character(1,"bob")