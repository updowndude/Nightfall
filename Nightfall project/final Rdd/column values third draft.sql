-- database used
USE mega_man_final_fantasy;
-- table and values for each row 
-- same for the other tables
INSERT INTO elements VALUES (default, "Ice"), 
							 (default, "Plant"), 
                             (default, "Micro-Bacterial Lifeforms"), 
                             (default, "Bird"), 
                             (default, "Gold"), 
                             (default, "Metal"), 
                             (default, "Lightning"), 
                             (default, "Lava"), 
                             (default, "Wind"), 
                             (default, "Holy"), 
                             (default, "Blood"), 
                             (default, "Whale"), 
                             (default, "Darkness"), 
                             (default, "Song"), 
                             (default, "Brains"), 
                             (default, "Water");
                         
INSERT INTO weapons VALUES (default, "Bone Knife", "Knife", 6, 11), 
						   (default, "Sharp Axe", "Axe", 10, 6), 
                           (default, "Nunchuks", "Staff", 7, 2), 
                           (default, "Masamune", "Long Sword", 11, 13), 
                           (default, "Stout Club", "Blunt", 5, 7), 
                           (default, "Gold Knuckles", "Bare", 9, 5), 
                           (default, "Dinner Tray", "Blunt", 2, 1), 
                           (default, "Cupid's Bow", "Bow", 5, 14), 
                           (default, "Harpoon", "Spear", 6, 10), 
                           (default, "Morning Star", "Club", 8, 15),
                           (default, "Old Pokey", "Short Sword", 7, 9),
                           (default, "Filleter", "Knife", 9, 6), 
                           (default, "Baseball Bat", "Club", 9, 3),
                           (default, "Carp", "Short Sword", 2, 16), 
                           (default, "Rolled-Up Newspaper", "Blunt", 5, 2),
                           (default, "Ice-Bolt Rifle", "Bow", 10, 1),
                           (default, "Flamethrower", "Bow", 9, 8);
                           
INSERT INTO items VALUES (default, "Health Potion", "Restores 10 HP", 99),
						 (default, "Magic Potion", "Restores 10 SP", 99),
                         (default, "Bell", "Revives a character", 50),
                         (default, "Antidote", "Cures poison", 99), 
                         (default, "Slap", "Cures confusion", 99), 
                         (default, "Alarm Clock", "Cures sleep", 99), 
                         (default, "Super Health Potion", "Restores 50 HP", 50), 
                         (default, "Super Magic Potion", "Restores 50 HP", 50), 
                         (default, "Elixir", "Restores all HP", 15), 
                         (default, "Ether", "Restores all SP", 15), 
                         (default, "Megalixir", "Restores all HP and SP", 5), 
                         (default, "Ambrosia", "Restores all HP and SP for entire party", 1), 
                         (default, "Jar of Bees", "15 damage to enemies, 15% to plant element", 99), 
                         (default, "Bomb", "50 damage to enemies, 50% to water element", 99), 
                         (default, "Stern Talking-To", "100 damage to enemies, 5% to water element", 1);
                         
INSERT INTO key_items VALUES (default, "Stone Key", "Opens a door somewhere", false), 
							 (default, "Cauldron", "Some witch might be looking for it", false), 
							 (default, "Secret Password", "Say the secret word...", false), 
							 (default, "Muddy Boot", "Is this treasure?", false), 
							 (default, "Locked Chest", "Where's the key?", false), 
							 (default, "Tiny Key", "Must open something...", false), 
							 (default, "Golden Crown", "Fit for a king", false), 
							 (default, "Used Tissue", "Eww Gross!", false), 
							 (default, "Musical Score", "Pretty catchy song", false), 
							 (default, "Baby Shoes", "Make you sad just looking at them", false), 
							 (default, "Cheese Wheel", "Looks tasty!", false),
                             (default, "Argonaut Fleece", "Gold but still so soft", false),
                             (default, "Red Paperclip", "Holds papers together", false), 
                             (default, "Glass of Milk", "Builds strong bones", false), 
                             (default, "Candle", "Lights the way", false), 
                             (default, "Happy Smile", "A thing of joy", false);
                             
INSERT INTO shops VALUES (default, "Amballa",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "Dudesboro",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "Valmiens",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "Port Carmino",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "Vhenique",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "New Justinio",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "Marvra",'2016-02-01 19:00','2016-02-03 02:00'), 
						 (default, "Othens",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "St. Sebaste",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "Hest",'2016-02-01 19:00','2016-02-03 02:00'), 
						 (default, "Old Balik",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "Cryptberg",'2016-02-01 19:00','2016-02-03 02:00'), 
						 (default, "Guernsey",'2016-02-01 07:30','2016-02-01 19:30'), 
						 (default, "Fontana",'2016-02-01 19:00','2016-02-03 02:00'), 
						 (default, "Xanadu",'2016-02-01 19:00','2016-02-03 02:00');
                          
INSERT INTO spells VALUES (default, "Fire", "Casts a fire bolt", 3, 8,7),
						  (default, "Ice", "Casts a ball of ice", 3, 1,5), 
                          (default, "Heal", "Heals a party member's HP", 5, 10,null), 
						  (default, "Cure", "Cures abnormal status", 7, 3,null), 
                          (default, "Bolt", "Casts a bolt of lightning", 10, 7,10), 
                          (default, "Revive", "Revives a dead party member", 15, 11,null), 
                          (default, "Chaos", "Anything could happen", 20, 13,null), 
                          (default, "Toad", "Turns enemy into a toad", 5, 12,null), 
                          (default, "Death", "Insta-kills an enemy", 8, 15,null), 
                          (default, "Doom", "Counts down to an enemy's death", 10, 15,null), 
                          (default, "Def-UP", "Raises an ally's defense", 6, 6,null),
                          (default, "Str-DOWN", "Lowers an enemy's strength", 9, 5,null), 
                          (default, "Firestorm", "Rains down fire on all enemies", 20, 8,null), 
                          (default, "Icestorm", "Rains down ice on all enemies", 20, 1,5),
                          (default, "Thunder", "Rains down lightning on all enemies", 20, 7,7);
                          
INSERT INTO armor VALUES (default, "Bone Shirt", "A shirt made of bones. Scary!", 5, 15), 
						 (default, "Spiked Collar", "A tough-looking collar", 4, 6), 
                         (default, "Fluffy Vest", "Made of wool so soft you could fall asleep just looking at it", 7, 14), 
                         (default, "Rainbow Shades", "Cool-looking sunglasses", 8, 5),
                         (default, "Obsidian Mail", "Black, shiny", 10, 12),
                         (default, "Pink Tutu", "You feel more graceful with this on", 9, 9), 
                         (default, "Dragon Scale Pants", "Protecting your vital bits from fire since 1000 B.C.", 5, 8), 
                         (default, "Horned Helmet", "Just like the vikings wore!", 6, 11), 
                         (default, "Leather Chaps", "Breezy!", 4, 2), 
                         (default, "Prism Dress", "So everyone can reflect on your glory", 9, 10), 
                         (default, "Tap Shoes", "Can't you feel the rhythm?", 6, 14), 
                         (default, "Ice Skates", "Don't forget about the toepick", 8, 6), 
                         (default, "Opera Gloves", "For when you're feeling fancy", 4, 13), 
                         (default, "Brass Knuckles", "The gentleman's best friend", 7, 5), 
                         (default, "Baseball Cap", "It's your favorite team!", 2, 9);
                         
INSERT INTO shop_inventory VALUES (default, 1, 3, null, null, 15), 
								  (default, 1, 1, null, null, 15), 
                                  (default, 2, null, 15, null, 170), 
                                  (default, 2, 1, null, null, 20), 
                                  (default, 2, null, null, 3, 15), 
                                  (default, 3, 1, null, null, 80), 
                                  (default, 3, null, null, 5, 160), 
                                  (default, 3, null, 4, null, 100), 
                                  (default, 4, 1, null, null, 40), 
                                  (default, 4, null, null, 10, 400), 
                                  (default, 5, null, 13, null, 130), 
                                  (default, 5, 1, null, null, 35), 
                                  (default, 5, null, null, 7, 240), 
                                  (default, 6, 1, null, null, 30), 
                                  (default, 6, null, null, 5, 150);
                                  
INSERT INTO inventories VALUES (default, 1, 45), 
							   (default, 2, 14), 
                               (default, 3, 0), 
                               (default, 4, 10), 
                               (default, 5, 5), 
                               (default, 6, 7), 
                               (default, 7, 10), 
                               (default, 8, 14), 
                               (default, 9, 4), 
                               (default, 10, 8), 
                               (default, 11, 0), 
                               (default, 12, 0), 
                               (default, 13, 3), 
                               (default, 14, 0), 
                               (default, 15, 0);

INSERT INTO kingdoms VALUES (default, "King Justin the Fatuous", "Nehennia", 10000, "Hereditary Monarchy", "New Justinio", 9), 
							(default, "Bob", "Republic of Excellency", 5000, "True Democracy", "Dudesboro", 2), 
                            (default, "High Priestess Estara", "Klamiens", 40000, "Theocracy", "St. Marguerite", 10), 
                            (default, "Princess Miranda", "New Freedonia", 32015, "Republic", "Drensbery", 16), 
                            (default, "Lord Adagio", "Brenton", 20000, "Oligarchy", "Valmiens", 5), 
                            (default, "Duke Dracmano", "Falhallen", null, "Absolute Monarchy", "Castle Dracmano", 13), 
                            (default, "the Council", "United States of Carmidian", 17000, "Confederacy", "Xanadu", 8),
                            (default, "High Priest Vorgon", "Aesia", 7000, "Dictatorship", "Stexom", 6), 
                            (default, "Sir Heston", "Crezellan", 10000, "Republic", "Tremlo", 12), 
                            (default, "Queen Lalah", "Reyelles", 13000, "Monarchy", "Minoll", 1), 
                            (default, "Cardinal Ward", "Ojias", 23000, "Theocracy", "Holy Yarnom", 3), 
                            (default, "Azalia", "Village of Gears", 16500, "Communism", "Village of Gears", 7), 
                            (default, "Aegeus", "Avia", 20000, "Constitutional Democracy", "Strellia", 4), 
                            (default, "the Shadow Council", "City of Thieves", 2000, "Anarchy", null, 11), 
                            (default, "Julie", "Progrian", 28000, "Dictatorship", "Marvra", 14);
                            
INSERT INTO Experience VALUES (default, 25), 
							  (default, 50), 
                              (default, 100), 
                              (default, 250), 
                              (default, 500), 
                              (default, 900), 
                              (default, 1500), 
                              (default, 2500), 
                              (default, 4000), 
                              (default, 5000), 
                              (default, 7500), 
                              (default, 10000), 
                              (default, 15000), 
                              (default, 20000), 
                              (default, 25000);
                              
INSERT INTO Characters VALUES (default, null, 3, default, default, 5, 5, 7, 1, 1, true, true,500), 
							  (default, "Kestryl", 8, default, default, 6, 4, 13, 1, 1, false, true,450), 
                              (default, "Hammond", null, default, default, 0, 7, 12, 1, 2, false, true,100), 
                              (default, "Katya", 16, default, default, 4, 3, 10, 1, 1, false, false,900), 
                              (default, "Charnoth", 17, default, default, 5, 5, 7, 1, 1, false, false,999),
                              (default, "Festana", 10, default, default, 7, 5, 14, 1, 1, false, false,777), 
                              (default, "Gormis", 4, default, default, 5, 5, 15, 1, 1, false, false,.456), 
                              (default, "Adria", 5, default, default, 4, 5, 9, 1, 1, false, false,724), 
                              (default, "Rostock", 5, default, default, 6, 4, 3, 1, 1, false, false,958), 
                              (default, "Lherissa", 7, default, default, 4, 6, 8, 1, 1, false, false,9999), 
                              (default, "Drestin", 11, default, default, 5, 5, 13, 1, 1, false, false,1000), 
                              (default, "Clixquo", 2, default, 15, 6, 3, 3, 1, 1, false, false,548), 
                              (default, "Bodrick", 1, 20, default, 7, 5, 5, 1, 2, false, false,48), 
                              (default, "Illyia", 13, default, default, 3, 4, 11, 1, 1, false, false,99), 
                              (default, "Pom", 9, default, default, 5, 6, 10, 1, 1, false, false,null);
                              
INSERT INTO Char_Spells VALUES (default, 1, 1), 
							   (default, 2, 3), 
                               (default, 3, 3), 
                               (default, 4, 5), 
                               (default, 5, 12), 
                               (default, 6, 12), 
                               (default, 1, 12), 
                               (default, 2, 12), 
                               (default, 13, 9), 
                               (default, 4, 7), 
                               (default, 12, 14), 
                               (default, 9, 8), 
                               (default, 10, 8), 
                               (default, 6, 7), 
                               (default, 10, 6);
                               
INSERT INTO CHAR_ARMOR VALUES (default, 1, 1), 
							  (default, 1, 2), 
                              (default, 1, 8), 
                              (default, 2, 4), 
                              (default, 2, 6), 
                              (default, 3, 9), 
                              (default, 3, 12), 
                              (default, 3, 3), 
                              (default, 4, 10), 
                              (default, 4, 15), 
                              (default, 4, 5), 
                              (default, 1, 14), 
                              (default, 5, 8), 
                              (default, 10, 3), 
                              (default, 11, 6);
                              
INSERT INTO Enemy_Type VALUES (default, "Monster"), 
							  (default, "Fae"), 
                              (default, "Animal"), 
                              (default, "Haunt"), 
                              (default, "Mech"), 
                              (default, "Giant"), 
                              (default, "Human"), 
                              (default, "Ghoul"), 
                              (default, "Alien"), 
                              (default, "???"), 
                              (default, "Mythic"), 
                              (default, "Experiment"), 
                              (default, "Virus"), 
                              (default, "Avian"), 
                              (default, "Vehicle");
                              
INSERT INTO ENEMIES VALUES (default, "Giant Spider", null, 60, 5, 5, 1, 2, null, null,1), 
						   (default, "Annoying Fairy", 4, default, 10, 8, 2, 2, null, 12,2),
                           (default, "Wild Boar", null, 120, 20, 25, 3, 2, null, null,3), 
                           (default, "Disgusting Catfish", null, 200, 30, 40, 1, 16, null, 5,7), 
                           (default, "Sentinel", 15, 150, 50, 100, 4, 16, 8, 11,1), 
                           (default, "Hunter Droid", 12, 500, 60, 75, 5, 6, 5, 10,14), 
                           (default, "Metal Axe Warrior", 2, 350, 150, 40, 5, 6, 5, null,11), 
                           (default, "Iron Titan", 13, 1000, 200, 400, 6, 6, null, null,6), 
                           (default, "Suicide Droid", 12, 100, 500, 400, 5, 6, 5, null,8), 
                           (default, "Cybernetic Hunter-Killer", 16, 800, 300, 350, 5, 6, 5, null,11), 
                           (default, "Rabid Goat", null, 50, 10, 10, 3, 15, null, null,15), 
                           (default, "Angry Kobold", 1, 100, 15, 10, 1, 11, null, null,8), 
                           (default, "Atlas", null, 500, 800, 450, 6, 5, null, null,1), 
                           (default, "Puck", null, 300, 25, 25, 2, 9, null, 7,4), 
                           (default, "Ambidextrous Ant", 4, 13, 1, 1, 3, 3, null, null,15);
                           
INSERT INTO ROOMS VALUES (default, "Spooky Chamber", null), 
						 (default, "Quiet Hallway", null), 
                         (default, "Vault", 5), 
                         (default, "Underground Lake", 9), 
                         (default, "Fairy Circle", 7), 
                         (default, "Death Chamber", null), 
                         (default, "Peaceful Meadow", null), 
                         (default, "Aerie", 14), 
                         (default, "Train Car", null),
                         (default, "Factory", null), 
                         (default, "Jazz Club", null), 
                         (default, "Clockworks", 11), 
                         (default, "Gazebo", 1), 
                         (default, "Steam Engine", 5), 
                         (default, "Waterfall", null);
                         
INSERT INTO Game_Events VALUES (default, "Crossing the River With Dogs"), 
						  (default, "Catching Ladybugs"), 
                          (default, "Towers of Hanoi"), 
                          (default, "A Secret Garden"), 
                          (default, "The Missing Piece"), 
                          (default, "Windy Days"), 
                          (default, "Waltzing Matilda"), 
                          (default, "Tisket, Tasket"), 
                          (default, "Mr. Whiskers"), 
                          (default, "Mr. Mulligan's Tie"), 
                          (default, "Maisie is Missing"), 
                          (default, "A Broken Cog"), 
                          (default, "Bloody Blade"), 
                          (default, "Wherefore Art Thou?"), 
                          (default, "Blinds");
                          
INSERT INTO Game_States VALUES (default, 1, 4,'2016-04-06 13:01'), 
							   (default, 1, 6,'2016-03-04 12:00'), 
                               (default, 3, 4,'2015-12-11 23:00'), 
                               (default, 2, 4,'2016-01-30 18:55'), 
                               (default, 3, 6,'2014-11-06 01:01'), 
                               (default, 2, 6,'2016-05-01 07:54'), 
                               (default, 5, 8,'2016-04-01 13:33'), 
                               (default, 10, 14,'2016-01-01 2:33'), 
                               (default, 11, 7,'2016-04-01 13:33'), 
                               (default, 4, 3,'2016-03-02 19:03'), 
                               (default, 7, 9,'2014-12-29 22:33'), 
                               (default, 15, 13,'2016-05-03 09:31'), 
                               (default, 9, 3,'2015-09-23 01:37'), 
                               (default, 8, 10,'2016-01-25 04:53'), 
                               (default, 9, 11,'2016-02-03 08:13');
                               
INSERT INTO Event_States VALUES (default, 1, 3, "Repeatable"), 
							   (default, 1, 4, default), 
                               (default, 1, 1, default),
                               (default, 1, 15, "Complete"), 
                               (default, 2, 13, default), 
                               (default, 6, 1, "Complete"), 
                               (default, 1, 2, "Repeatable"), 
                               (default, 4, 14, default), 
                               (default, 4, 13, "Complete"), 
                               (default, 3, 10, "Complete"), 
                               (default, 2, 8, "Repeatable"), 
                               (default, 5, 6, default), 
                               (default, 5, 10, default), 
                               (default, 7, 11, "Repeatable"), 
                               (default, 4, 5, default);
                               
insert into Enemy_assignmen value (default, 1,4),
								(default, 1,7),
								(default, 1,8),
								(default, 3,8),
								(default, 2,11),
								(default, 3,4),
								(default, 9,1),
								(default, 1,14),
								(default, 12,2),
								(default, 10,3),
								(default, 15,15),
								(default, 8,9),
								(default, 6,9),
								(default, 13,13),
								(default, 7,7);                              