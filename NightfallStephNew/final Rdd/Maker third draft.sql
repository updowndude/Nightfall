-- drop the database if its there
drop database if exists Mega_Man_Final_Fantasy;
-- remakes database
create database Mega_Man_Final_Fantasy;
-- use the database just created
use Mega_Man_Final_Fantasy;

-- makes tables with their columns
create table Elements
(
	Element_ID int auto_increment primary key, 
    Element_Name varchar(20)
);

create table weapons
(
	Weapon_id int auto_increment primary key,
    Weapon_name varchar(20) not null,
    Weapon_type varchar(20),
    Damage int not null default 1, 
    Weapon_Element_ID int,
    -- makes a columns a foreign key 
    -- similar to other foregin keys
    constraint fk_Weapon_Element_id foreign key (Weapon_Element_id) references Elements(Element_id)
);

create table Items
(
	Item_id int auto_increment primary key,
	Item_name varchar(20) not null,
    Item_desc varchar(30),
    Max_held int
);

create table Key_Items
(
	Key_Item_ID int auto_increment primary key, 
    Key_Item_Name varchar(20) not null,
    Key_Item_Desc varchar(30), 
    Collected bool not null default false
);

create table Shops
(
	Shop_ID int auto_increment primary key, 
    City varchar(20),
    Open_hours datetime,
    Close_hours datetime
);

create table Spells
(
	Spell_id int auto_increment primary key,
	Spell_name varchar(20) not null,
    Spell_desc varchar(30),
    SP_cost int not null, 
    Spell_Element_ID int,
    Spell_damage int,
    constraint fk_Spell_Element_id foreign key (Spell_Element_id) references Elements(Element_id)
);

create table Armor
(
	Armor_id int auto_increment primary key,
    Armor_name varchar(20) not null,
    Armor_desc varchar(100),
    Defense int not null default 1, 
    Armor_Element_ID int, 
    constraint fk_Armor_Element_id foreign key (Armor_Element_id) references Elements(Element_id)
);

create table Shop_Inventory
(
	Shop_Inventory_ID int auto_increment primary key, 
    Shop_ID int,
    Item_ID int, 
    Weapon_ID int, 
    Armor_ID int, 
    Price int, 
    constraint fk_This_Shop_ID foreign key (Shop_ID) references Shops(Shop_ID),
    constraint fk_Item_ID foreign key (Item_ID) references Items(Item_ID), 
    constraint fk_Weapon_ID foreign key (Weapon_ID) references Weapons(Weapon_ID), 
    constraint fk_Armor_ID foreign key (Armor_ID) references Armor(Armor_ID)
);

create table Inventories
(
	Inventory_id int auto_increment primary key,
    Inv_Item_id int,
    Quantity int, 
    constraint fk_Inv_Item_id foreign key (Inv_Item_id) references Items(Item_id)
);

create table Kingdoms
(
	Kingdom_id int auto_increment primary key,
    Ruler varchar(20),
    Kingdom_Name varchar(20) not null,
    Population int, 
    Government_type varchar(20),
    Capitol varchar(20),
    Element_ID int, 
    constraint fk_Element_id foreign key (Element_id) references Elements(Element_id)
);

create table Experience
(
	Level_ID int auto_increment primary key, 
    Points_to_Next int
);

create table Characters 
(
	Character_id int auto_increment primary key,
    Character_name varchar(30) not null,
    Weapon_id int,
    Health_points int not null default 10,
    Spell_points int not null default 10,
    Attack int, 
    Defense int, 
    Kingdom_id int,
    Char_Inventory_id int,
    Current_Level int,
    isMain bool,
    inParty bool,
    Money_total int,
    constraint fk__Weapon_id foreign key (Weapon_id) references Weapons(Weapon_id),
    constraint Kingdom_id_fk foreign key (Kingdom_id) references Kingdoms(Kingdom_id),
	constraint fk_Char_Inventory_id foreign key (Char_Inventory_id) references Inventories(Inventory_id), 
    constraint fk_Current_Level foreign key (Current_Level) references Experience(Level_ID)
);

create table Char_Spells
(
	Char_Spell_ID int auto_increment primary key, 
    Spell_ID int, 
    Character_ID int, 
    constraint fk_Spell_ID foreign key (Spell_ID) references Spells(Spell_ID), 
    constraint fk_Character_ID foreign key (Character_ID) references Characters(Character_ID)
);

create table Char_Armor
(
	Char_Armor_ID int auto_increment primary key, 
    Character_ID int, 
    Armor_ID int, 
    constraint fk_Armor_Character_ID foreign key (Character_ID) references Characters(Character_ID), 
	constraint fk_Characters_Armor_ID foreign key (Armor_ID) references Armor(Armor_ID)
);

create table Enemy_Type
(
	Enemy_Type_ID int auto_increment primary key, 
    Type_Desc varchar(20)
);

create table Enemies
(
	Enemy_id int auto_increment primary key,
    Enemy_name varchar(20),
    Weapon_id int,
    Health_point int not null default 10,
    Attack int, 
    Defense int, 
    Enemy_Type int,
    Element_id int,
    Armor_id int,
    Spell_id int,
    Experience_id int not null,
    constraint Experience_id_fk foreign key (Experience_id) references Experience(Level_ID),
	constraint Spell_id_fk foreign key (Spell_id) references Spells(Spell_id),
    constraint Armor_id_fk foreign key (Armor_id) references Armor(Armor_id),
	constraint Weapon_id_fk foreign key (Weapon_id) references Weapons(Weapon_id),
    constraint fk__Element_id foreign key (Element_id) references Elements(Element_id), 
    constraint fk_type_id foreign key (Enemy_Type) references Enemy_Type(Enemy_Type_ID)
);

create table Rooms
(
	Room_id int auto_increment primary key,
    Room_name varchar(20) not null, 
    Key_Item_id int,
    constraint fk_KeyItem_id foreign key (Key_Item_id) references Key_Items(Key_Item_id)
);

create table Enemy_assignmen
(
	Enemy_assignmen_id int auto_increment primary key,
	Room_id int,
    Enemy_id int,
    constraint fk_Enemy_id foreign key (Enemy_id) references Enemies(Enemy_id),
    constraint fk_Room_id foreign key (Room_id) references Rooms(Room_id)
);

create table Game_Events
(
	Event_ID int auto_increment primary key, 
    Event_Name varchar(30)
);

create table Game_States
(
	Game_state_id int auto_increment primary key,
    Character_id int,
    Room_id int not null,
    Save_Date_Time datetime, 
	constraint Room_id_fk foreign key (Room_id) references Rooms(Room_id),
    constraint fk__Character_id foreign key (Character_id) references Characters(Character_id)
);

create table Event_States
(
	Event_State_ID int auto_increment primary key, 
    Game_state_id int, 
    Event_ID int, 
    Current_Event_State varchar(30) default "Not Found",
    constraint Game_Events_fk foreign key (Event_ID) references Game_Events(Event_ID)
);

create table Archive
(
	Archive_id int auto_increment primary key,
    Character_id int,
    Room_id int not null,
    Save_Date_Time datetime
);