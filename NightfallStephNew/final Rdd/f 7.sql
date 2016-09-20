-- database used
use Mega_Man_Final_Fantasy;

-- only needs to work once
-- set global event_schedular = on
-- testing 
-- drop event Update_Info;

-- cahgnes delimiter 
delimiter //
-- makes event that only works once ever week
create event Update_Info on schedule every 1 week
do begin 
-- copy rows into archive
	insert Archive 
    -- all of columns from select
    SELECT * 
    -- table they are from
    FROM Game_State
    -- see if date is years old 
    -- character id is on a lsit
    where Save_Date_Time < now() - interval 2 year  &&  Character_ID in (
    -- gets characters id
    select Character_ID
    -- table they are from
    from Characters
    -- nothing in name and is the main character
    where Character_name = "" && isMain = 1);
    
    -- delete that from games states 
    -- same as the insert in the arachvie
	delete from Game_States where Save_Date_Time < now() - interval 2 year &&  Character_ID in (
    select Character_ID
    from Characters
    where Character_name = "" && isMain = 1);
    -- close the event
end//
-- changes the delimiter back
delimiter ;