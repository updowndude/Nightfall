using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nightfall
{
    public partial class frmConsole : Form
    {
        //whats the main chacter names
        string _strMyText = "";

        //sets that value 
        //same for the others
        public string strMyText
        {
            //handes the set 
            set { _strMyText = value; }
        }

        //allys names 
        string _strAllyOneName = "";
        string _strAllyTwoName = "";

        public string strAllyOneName
        {
            set { _strAllyOneName = value; }
        }

        public string strAllyTwoName
        {
            set { _strAllyTwoName = value; }
        }

        //whats there gender
        bool _blnGender = false;

        public bool blnGender
        {
            set { _blnGender = value; }
        }

        //text for when a games is loaded
        string _strLoad = "";

        public string strload
        {
            set { _strLoad = value; }
        }

        //anwswer to the riddle
        string _strAnswer = "";

        public string strAnswer
        {
            set { _strAnswer = value; }
        }

        //the gobal varibale
        struct  gobalvar
        {
            // Sets day/night
            public bool blnDayNight;
            // This sets whether or not the player is participating in a battle or event. 
            public bool blnModeBattle;
            // This is the current room.
            public string strCurrentRoom;
            //creates instances of enemy class to hold current enemies during battle
            public Enemy enemyOne;
            public Enemy enemyTwo;
            public Enemy enemyThree;
            public Enemy enemyFour;
            //true = alive/existing, false = dead/not existing
            public bool enemyOneAlive;
            public bool enemyTwoAlive;
            public bool enemyThreeAlive;
            public bool enemyFourAlive;
            //creates instance of enemy class that player is currently targeting in battle
            public Enemy currentTarget;
            //an integer to track which enemy is currently targeted to prevent confusion when more than one of the same enemy is present in a battle
            public int intCurrTar;
            //true = alive, false = dead to prevent player from continuing to attack already dead enemies
            public bool blnCurrentTargetAlive;
            //player can have two allies
            public Ally allyOne;
            public Ally allyTwo;
            //sets player character properties
            public Player_Char myCharacter;
            //true = alive/existing, false = dead/not existing
            public bool blnPlayerAlive;
            public bool blnAllyOneAlive;
            public bool blnAllyTwoAlive;
            //global variables for quest flags
            public bool blnRedMacheteGet;
            public bool blnRedDoorOpen;
            public bool blnBlueLodestoneGet;
            public bool blnBlueDoorOpen;
            public bool blnBossFought;
            // no npc
            public string strNPC;
            // toggles the room description to dialogue and vice-versa.
            public bool blnModeTalk;
            //sounds
            public System.Media.SoundPlayer splyBattleWin;
            public System.Media.SoundPlayer splyYouDied;
            public System.Media.SoundPlayer splyJungleTheme;
            public System.Media.SoundPlayer splyIndustrialTheme;
            public System.Media.SoundPlayer splyFightItOut;
            public System.Media.SoundPlayer splyRunSafe;
            public System.Media.SoundPlayer splySpellCast;
            // Changes the theme as a function. 1 = Jungle/Plantlife, 2 = Steampunk/Water, 3 = Metal/Cybernetic
            /////////////////////// Rooms ////////////////////////////////
            public string[] aryStrRoom;
            ////////////// Descriptions ///////////////
            public string[] aryStrRoomDesc;
            //items
            public Items smallHP;
            public Items smallMP;
            //list of label for items
            public Label[] aryLblItems;
            //text for when user inter acts with item
            public string strItemInteract;
            //what items are for rooms
            public string[] arystrWhatItemsIs;
            //what person they when item to be used on
            public string strPerson;
        }

        //makes an copy of goblal var
        gobalvar stValues = new gobalvar();

        public frmConsole()
        {
            InitializeComponent();
        }

        //loads the form
        private void frmConsole_Load(object sender, EventArgs e)
        {
            //sets up the rooms
            stValues.aryStrRoom = new string[]{
            // Dark Jungle  0 - 11
            "1-1 Jungle Entrance", "1-2 Boiler Room", "1-3 Jungle Chamber", "1-4 Jungle Fork", "1-5 Jungle Hallway", "1-6 Jungle Hallway",
            "1-7 Bunker Entrance", "1-8 Bunker Interior", "1-9 Gearbox Chamber", "1-10 Jungle Portal", "1-11 Spider's Nest", "1-12 Jungle Temple", 
            // Steampunk  12 - 31
            "2-1 Boiler Room", "2-2 East Wing A", "2-3 East Wing B", "2-4 Mechanical Support Bay A", "2-5 Men's Bathroom", "2-6 Mechanical Support Bay B", "2-7 Women's Bathroom",
            "2-8 Center Hall", "2-9 Gearbox Area A", "2-10 Gearbox Area B", "2-11 Gearbox Area C", "2-12 Gearbox Area D", "2-13 West Wing A", "2-14 West Wing B",
            "2-15 Turbine Room", "2-16 Primary Control Area A", "2-17 Primary Control Area B", "2-18 Generator Room", "2-19 Elevator Room",
            // Metal 32 - 52
            "3-1 Metal Fortress Basement", "3-2 Armory A", "3-3 Armory B", "3-4 Armory C", "3-5 Armory Command Center", "3-6 Cybernetica Alpha", "3-7 Cybernetica Beta",
            "3-8 Cybernetica Delta", "3-9 Cybernetica Gamma", "3-10 Bunker Entrance", "3-11 Bunker interior A", "3-12 Bunker interior B", "3-13 Kitchen", "3-14 Bunker interior C",
            "3-15 Bunker interior D", "3-16 Red Room", "3-17 Secret Love Chamber", "3-18 Metal Temple", "3-19 Metal Shrine", "3-20 Pure Light Room"

        };
            //what the room is about
            stValues.aryStrRoomDesc = new string[]{
            "The jungle seems to close in on you as you enter. It is hot, dank, and murky here. From somewhere further in, you hear a strange sort of growl.",
            "An ancient boiler room of a long-defunct factory. Machinery, the purpose of which you do not know, lines the concrete walls. In the center of the room is an enormous boiler. It makes you nervous to look at it for long.",
            "You are following a thin, winding trail through the dense jungle. You wonder if you are the first non-animal life to set foot here.",
            "The path splits here. To the northeast, you can only see more jungle, but you can hear a faint chittering. From the southeast comes a faintly oily smell.",
            "You are startled by a sudden metallic clanging and the grinding sound of some vast machinery starting up. Who built these machines, and why here?",
            "The jungle thins out a little here. To the south, you can see a massive concrete structure. The path to it, however, is blocked by vines.",
            "You are at the entrance to a bunker. Its mammoth size makes you feel like one of the many tiny ants you have stepped on getting here. The door gapes open ominously.",
            "The interior of the jungle bunker has obviously been through much. The scorch marks on the wall indicate some kind of explosion. There are vaguely-human shaped masses lying in the corner, but you don't want to look too closely.",
            "You are inside a strange clockwork mechanism. The gears turn and grind, but you cannot discover the purpose, no matter where you look. There is a room to the north, but the entrance is blocked by mystical energy. The chittering sound you heard earlier is much louder now.",
            "A swirling portal beckons you from the center of the room. It is the only way forward.",
            "You have entered what is obviously a spider's lair. Thick, sticky cobwebs drape the trees, and here and there you can make out wrapped bundles of what you can only assume are future meals.",
            "A majestic temple in the heart of the jungle. The sight of it leaves you in awe.",
            "The jungle thins out a little here. To the south, you can see a massive concrete structure. You have already chopped down the vines blocking your path.",
            "The gears have stopped. The room is too still now, as though it is waiting for something. From the north, you can feel the strange sting of magic. The chittering sound you heard earlier is much louder now."
        };
            //sets values of evething to default
            stValues.blnDayNight = false;
            stValues.blnModeBattle = false;
            stValues.strCurrentRoom = "";
            stValues.enemyOne = new Enemy("", 0, 0, "");
            stValues.enemyTwo = new Enemy("", 0, 0, "");
            stValues.enemyThree = new Enemy("", 0, 0, "");
            stValues.enemyFour = new Enemy("", 0, 0, "");
            stValues.enemyOneAlive = false;
            stValues.enemyTwoAlive = false;
            stValues.enemyThreeAlive = false;
            stValues.enemyFourAlive = false;
            stValues.currentTarget = null;
            stValues.intCurrTar = 0;
            stValues.blnCurrentTargetAlive = false;
            stValues.allyOne = new Ally("", 0, 0);
            stValues.allyTwo = new Ally("", 0, 0);
            stValues.myCharacter = new Player_Char("Pretty Polly", 100, 20, 50, true);
            stValues.blnPlayerAlive = true;
            stValues.blnAllyOneAlive = true;
            stValues.blnAllyTwoAlive = true;
            stValues.blnRedMacheteGet = false;
            stValues.blnRedDoorOpen = false;
            stValues.blnBlueLodestoneGet = false;
            stValues.blnBlueDoorOpen = false;
            stValues.blnBossFought = false;
            stValues.strNPC = "";
            stValues.blnModeTalk = false;
            //where the sound is
            stValues.splyBattleWin = new System.Media.SoundPlayer(@"applause2_x.wav");
            stValues.splyYouDied = new System.Media.SoundPlayer(@"Sad_Trombone.wav");
            stValues.splyJungleTheme = new System.Media.SoundPlayer(@"Spooky.wav");
            stValues.splyIndustrialTheme = new System.Media.SoundPlayer(@"Industrial_1.wav");
            stValues.splyFightItOut = new System.Media.SoundPlayer(@"TWIST_A.wav");
            stValues.splyRunSafe = new System.Media.SoundPlayer(@"exit_cue_y.wav");
            stValues.splySpellCast = new System.Media.SoundPlayer(@"chime_up.wav");
            //makes to two items
            stValues.smallHP = new Items(10,"Restore 20 HP");
            stValues.smallMP = new Items(10,"Restore 20 MP");
            stValues.aryLblItems = new Label[4];
            //adds items label to the list of labels 
            stValues.aryLblItems[0] = lblItem1;
            stValues.aryLblItems[1] = lblItem2;
            stValues.aryLblItems[2] = lblItem3;
            stValues.aryLblItems[3] = lblItem4;
            stValues.strItemInteract = "";
            stValues.arystrWhatItemsIs = new string[4];
            stValues.strPerson = "";

            // Initially hides the menu
            muConControl.Hide();

            // Initially hides the battle screen
            picModeBattle.Hide();

            // Allows for the word-wrap
            lblRoomDesc.MaximumSize = new Size(550, 0);

            // Controls //

            // Controls become enabled if there is something to interact with //

            btnSpell.Enabled = true;
            btnAttack.Enabled = false;
            btnRunAway.Enabled = false;
            btnGrabItem.Enabled = true;
            btnInspect.Enabled = true;

            //sets initial player & ally characters
            stValues.allyOne.initAlly(1);
            stValues.allyTwo.initAlly(3);
            lblNameAllyOne.Text = stValues.allyOne.strName;
            lblNameAllyTwo.Text = stValues.allyTwo.strName;
            pbarHealthYours.Value = stValues.myCharacter.intHealth;
            pbarManaYours.Value = stValues.myCharacter.intSpellPoints;
            pbarHealthAllyOne.Value = stValues.allyOne.intHealth;
            pbarHealthAllyTwo.Value = stValues.allyTwo.intHealth;

            // Switches the text that indicates if it is night or day //
            if (stValues.blnDayNight == false) // 0 is 'night'
            {
                lblNightDay.ForeColor = System.Drawing.Color.DarkGreen; // changes font color to green
                lblNightDay.Text = "Nightfall";
            }

            else if (stValues.blnDayNight == true) // 1 is 'day'
            {
                lblNightDay.ForeColor = System.Drawing.Color.Yellow; // changes font color to yellow
                lblNightDay.Text = "Daybreak";
            }
        }

        public void changeTheme(int intTheme)
        {
            //changes the theme of the room
            if (intTheme == 1)
            {
                //changes the backgrond image 
                //same for the others
                panRoomDesc.BackgroundImage = Properties.Resources.darkjungle;
            }

            else if (intTheme == 2)
            {
                panRoomDesc.BackgroundImage = Properties.Resources.steampunk;
            }

            else if (intTheme == 3)
            {
                panRoomDesc.BackgroundImage = Properties.Resources.robotic;
            }

        }

        ////////////// This is going to look like a huge mess ////////////////

        // Change room functions

        //a method to move between rooms in the dungeon. Each move passes in an integer standing for the destination room number that tells the method which room to load
        public void moveToRoom(int intRoomNum)
        {
            //makes copy of message form
            frmMessages fMessage =new frmMessages();

            if (intRoomNum == 0)
            {
                //buidl the rooom
                //same for others
                moveToroomHelper("Frog", 1, stValues.aryStrRoom[0], stValues.aryStrRoom[0], "Proceed East to Jungle Chamber A", "", "");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[0];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                //nav2.Enabled = true;
                btnNav2.Enabled = false;

                //nav3.Enabled = true;
                btnNav3.Enabled = false;

                //odds for the battle 
                //similar for others
                lowBattleOdds();
            }

            if(intRoomNum == 1)
            {
                moveToroomHelper("", 2, stValues.aryStrRoom[1], stValues.aryStrRoom[1], "Proceed South to Jungle Hallway A", "", "");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[1];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                //nav2.Enabled = true;
                btnNav2.Enabled = false;

                //nav3.Enabled = true;
                btnNav3.Enabled = false;

                //pplayts a song
                //similar for others
                stValues.splyIndustrialTheme.PlayLooping();

                lowBattleOdds();
            }

            if(intRoomNum == 2)
            {
                moveToroomHelper("", 1, stValues.aryStrRoom[2], stValues.aryStrRoom[2], "Proceed West to Jungle Entrance", "Proceed North to Boiler Room", "Proceed East to Jungle Hallway B");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[2];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                btnNav2.Enabled = true;
                //nav2.Enabled = false;

                btnNav3.Enabled = true;
                //nav3.Enabled = false;

                medBattleOdds();
            }

            if(intRoomNum == 3)
            {
                moveToroomHelper("", 1, stValues.aryStrRoom[3], stValues.aryStrRoom[3], "Proceed West to Jungle Hallway A", "Proceed Northeast to Jungle Hallway C", "Proceed Southeast to Jungle Hallway D");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[3];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                btnNav2.Enabled = true;
                //nav2.enabled = false;

                btnNav3.Enabled = true;
                //nav3.Enabled = false;

                lowBattleOdds();
            }

            if(intRoomNum == 4)
            {
                moveToroomHelper("", 1, stValues.aryStrRoom[4], stValues.aryStrRoom[4], "Proceed Southwest to Jungle Hallway B", "Proceed East to Gearbox Chamber", "");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[4];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                btnNav2.Enabled = true;
                //nav2.Enabled = false;

                //nav3.Enabled = true;
                btnNav3.Enabled = false;
            }

            if(intRoomNum == 5)
            {
                moveToroomHelper("", 1, stValues.aryStrRoom[5], stValues.aryStrRoom[5], "Proceed Northwest to Jungle Hallway B", "Proceed South to Bunker Entrance", "");

                //changes room dialog slightly if blocked path is open
                if (stValues.blnRedDoorOpen == false)
                {
                    lblRoomDesc.Text = stValues.aryStrRoomDesc[5];
                }

                else
                {
                    lblRoomDesc.Text = stValues.aryStrRoomDesc[12];
                }

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                if (stValues.blnRedDoorOpen == true)
                {
                    btnNav2.Enabled = true;
                    //nav2.Enabled = false;
                }

                else
                {
                    btnNav2.Enabled = false;
                }

                //nav3.Enabled = true;
                btnNav3.Enabled = false;

                highBattleOdds();
            }

            if(intRoomNum == 6)
            {
                moveToroomHelper("", 3, stValues.aryStrRoom[6], stValues.aryStrRoom[6], "Proceed North to Jungle Hallway D", "Proceed West to Bunker Interior", "");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[6];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                btnNav2.Enabled = true;
                //nav2.Enabled = false;

                //nav3.Enabled = true;
                btnNav3.Enabled = false;

                medBattleOdds();
            }

            if(intRoomNum == 7)
            {
                moveToroomHelper("", 3, stValues.aryStrRoom[7], stValues.aryStrRoom[7], "Proceed East to Bunker Entrance", "", "");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[7];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                //nav2.Enabled = true;
                btnNav2.Enabled = false;

                //nav3.Enabled = true;
                btnNav3.Enabled = false;

                lowBattleOdds();

                if (stValues.blnBlueLodestoneGet == false)
                {
                    stValues.blnBlueLodestoneGet = true;
                    AddMoveLbx("Blue Key got");
                }
            }

            if(intRoomNum == 8)
            {
                moveToroomHelper("", 2, stValues.aryStrRoom[8], stValues.aryStrRoom[8], "Proceed West to Jungle Hallway C", "Proceed North to Dark Jungle Portal", "Proceed Southeast to Spider's Nest");

                if (stValues.blnBlueDoorOpen == false)
                {
                    lblRoomDesc.Text = stValues.aryStrRoomDesc[8];
                }

                else
                {
                    lblRoomDesc.Text = stValues.aryStrRoomDesc[13];
                }

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                if (stValues.blnBlueDoorOpen == true)
                {
                    btnNav2.Enabled = true;
                    btnNav2.Enabled = false;
                }

                else
                {
                    btnNav2.Enabled = false;
                }

                btnNav3.Enabled = true;
                //nav3.Enabled = false;
            }

            if(intRoomNum == 9)
            {
                moveToroomHelper("Ghost", 3, stValues.aryStrRoom[9], stValues.aryStrRoom[9], "Proceed South to Gearbox Chamber", "", "Warp to the Temple");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[9];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                //nav2.Enabled = true;
                btnNav2.Enabled = false;

                btnNav3.Enabled = true;
                //nav3.Enabled = false;

                fMessage.blnClear = true;
                fMessage.blnExit = true;
                fMessage.blnLabelRiddle = true;
                fMessage.blnRiddle = true;
                fMessage.blnTextBox = true;
                fMessage.strMessage = "You are approached by a riddle-loving metal titan. He kneels down to you and says, \"Before you can pass through the dark portal, you must answer my riddle. Are you ready to hear it, puny adventurers ?";

                fMessage.ShowDialog();

                if(_strAnswer == "Metal Titan")
                {
                    lblRoomDesc.Text = "The Metal Titan then evaporates into a gaseous cloud that quick dissipates, out of shame.";
                    moveToRoom(11);
                }
                else
                {
                    lblRoomDesc.Text = "He then smashes you by clapping his huge iron hands together, killing you and your party instantly.";
                }
            }

            if(intRoomNum == 10)
            {
                moveToroomHelper("",1, stValues.aryStrRoom[10], stValues.aryStrRoom[10], "Proceed Northwest to Gearbox Chamber", "", "");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[10];

                btnNav1.Enabled = true;
                //nav1.Enabled = false;

                //nav2.Enabled = true;
                btnNav2.Enabled = false;

                //nav3.Enabled = true;
                btnNav3.Enabled = false;

                spiderFight();

                if (stValues.blnRedMacheteGet == false)
                {
                     stValues.blnRedMacheteGet = true;
                     AddMoveLbx("Red Key got");
                }
            }

            if(intRoomNum == 11)
            {
                moveToroomHelper("", 3, stValues.aryStrRoom[11], stValues.aryStrRoom[11], "", "", "");
                lblRoomDesc.Text = stValues.aryStrRoomDesc[11];

                //nav1.Enabled = true;
                btnNav1.Enabled = false;

                //nav2.Enabled = true;
                btnNav2.Enabled = false;

                //nav3.Enabled = true;
                btnNav3.Enabled = false;

                if (stValues.blnBossFought == false)
                {
                    bossBattle();
                }
            }
        }
       
        //helps build a rooom
        private void moveToroomHelper(string strPerons,int intTheme, string strRoom,string strRoomTitle,string strNavText1, string strNavText2, string strNavText3)
        {
            //makes a room object
            Random ranItem = new Random();

            //item if its in the room
            int intHpHappen = 0;
            int intMpHappen = 0;

            //walks thought the list of labels
            for (int lcv = 0; lcv < stValues.aryLblItems.Length; lcv++)
            {
                //sets the rooms label to nothign
                stValues.aryLblItems[lcv].Text = "";

                //random value for item
                intHpHappen = ranItem.Next(5) + 1;
                intMpHappen = ranItem.Next(10) + 1;

                //health item was there
                if(intHpHappen == 1)
                {
                    //changes the list to knew that items is
                    stValues.arystrWhatItemsIs[lcv] = stValues.smallHP.strName;
                    //changes lable to text
                    stValues.aryLblItems[lcv].Text = "Items";
                }
                //magic item was there
                else if (intMpHappen == 1)
                {
                    //same as before
                    stValues.arystrWhatItemsIs[lcv] = stValues.smallMP.strName;
                    stValues.aryLblItems[lcv].Text = "Items";
                }
            }

            //sets the text of npc
            stValues.strNPC = strPerons;
            //changes the theme of the room
            changeTheme(intTheme);
            //changes the currrent vlaue
            stValues.strCurrentRoom = strRoom;
            //rooms title changes
            lblRoomTitle.Text = strRoomTitle;

            //sets the text for the nav buttons
            btnNav1.Text = strNavText1;
            btnNav2.Text = strNavText2;
            btnNav3.Text = strNavText3;

            //clear the lisbox
            lbxBattle.Items.Clear();
        }

        //user mosue leaves menu strip
        private void menuConsole_MouseLeave(object sender, EventArgs e)
        {
            //hide the menu stip
            muConControl.Hide();
        }
    
        //user mouse entered menu stip
        private void menuConsole_MouseHover(object sender, EventArgs e)
        {
            //show the menu stip
            muConControl.Show();
        }
        //user mouse entere menu stip backgrond
        private void menuPanel_MouseEnter(object sender, EventArgs e)
        {
            //show the menu stip
            muConControl.Show();
        }

        //user click the quit item
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the game
            this.Close();
        }

        //player attacks enemies
        private void btnAttack_Click(object sender, EventArgs e)
        {
            //if the main chacter is alive
            if (stValues.blnPlayerAlive == true)
            {
                //random number generator to determine player's attack
                Random ranHowHard = new Random();

                //sets player & ally current attack to a random number within their attack power range 
                int playerHit = ranHowHard.Next(stValues.myCharacter.intAttack) + 1;
                int allyOneHit = ranHowHard.Next(stValues.allyOne.intAttack) + 1;
                int allyTwoHit = ranHowHard.Next(stValues.allyTwo.intAttack) + 1;

                if (stValues.blnCurrentTargetAlive == true)
                {
                    if (stValues.blnPlayerAlive == true)
                    {
                        //if player performs a critical hit, a method is called to shake the form
                        if (playerHit >= stValues.currentTarget.intHealth * .40 && stValues.currentTarget.intHealth > 10)
                        {
                            Shake(this);
                        }

                        //removes player's hit from enemy's health
                        stValues.currentTarget.intHealth -= playerHit;

                        //lets user know how hard they hit
                        AddMoveLbx("You hit " + stValues.currentTarget.strName + " for " + playerHit + " point(s) of damage");


                        //checks if player character kills an enemy
                        deadEnemy();

                        //1st ally's turn
                        if (stValues.currentTarget.intHealth > 0 && stValues.blnAllyOneAlive == true)
                        {
                            //shakes form if ally performs critical hit
                            if (allyOneHit >= stValues.currentTarget.intHealth * .40 && stValues.currentTarget.intHealth > 10)
                            {
                                Shake(this);
                            }

                            //removes 1st ally's hit from enemy's health
                            stValues.currentTarget.intHealth -= allyOneHit;

                            //lets user know how hard 1st ally hit
                            AddMoveLbx(stValues.allyOne.strName + " hit " + stValues.currentTarget.strName + " for " + allyOneHit + " point(s) of damage");

                            //checks if 1st ally kills an enemy
                            deadEnemy();
                        }

                        //if player character kills enemy, 1st ally waits for new target
                        else if (stValues.currentTarget.intHealth <= 0 && stValues.blnAllyTwoAlive == true)
                        {
                            AddMoveLbx(stValues.allyOne.strName + " is awaiting new orders.");
                        }

                        //2nd ally's turn
                        if (stValues.currentTarget.intHealth > 0 && stValues.blnAllyTwoAlive == true)
                        {
                            //shakes for if 2nd lly performs a critical hit
                            if (allyTwoHit >= stValues.currentTarget.intHealth * .40 && stValues.currentTarget.intHealth > 10)
                            {
                                Shake(this);
                            }

                            //removes 2nd ally's hit from enemy's health
                            stValues.currentTarget.intHealth -= allyTwoHit;

                            //lets user know how hard 2nd ally hit
                            AddMoveLbx(stValues.allyTwo.strName + " hit " + stValues.currentTarget.strName + " for " + allyTwoHit + " points of damage");

                            //checks if 2nd ally kills an enemy
                            deadEnemy();
                        }

                        //if player character or 1st ally kill enemy, 2nd ally waits for new target
                        else if (stValues.currentTarget.intHealth <= 0 && stValues.blnAllyTwoAlive == true)
                        {
                            AddMoveLbx(stValues.allyTwo.strName + " is awaiting new orders.");
                        }
                    }

                    //battle ends when all enemies are dead
                    if (stValues.enemyOneAlive == false && stValues.enemyTwoAlive == false && stValues.enemyThreeAlive == false && stValues.enemyFourAlive == false)
                    {
                        stValues.splyBattleWin.Play();
                        AddMoveLbx("You've won!");
                        toExploreMode();
                    }

                    //battle passes to enemy turn if any enemies are still alive
                    else
                    {
                        toEnemyTurn();
                    }
                }

                //user tries to attack without selecting a target
                else
                {
                    AddMoveLbx("Select a foe to fight!");
                }
            }
        }

        //game checks if an enemy has been killed after player's turn, 1st ally's turn(if alive), and 2nd ally's turn(if alive)
        private void deadEnemy()
        {
            //lets user know when 1st enemy has been defeated
            if (stValues.currentTarget.intHealth <= 0 && stValues.intCurrTar == 1)
            {
                AddMoveLbx(stValues.currentTarget.strName + " is defeated!");
                stValues.blnCurrentTargetAlive = false;
                stValues.enemyOneAlive = false;
                lblEnemy1.Text = "";
                stValues.intCurrTar = 0;
            }

            //lets user know when 2nd enemy has been defeated
            else if (stValues.currentTarget.intHealth <= 0 && stValues.intCurrTar == 2)
            {
                AddMoveLbx(stValues.currentTarget.strName + " is defeated!");
                stValues.blnCurrentTargetAlive = false;
                stValues.enemyTwoAlive = false;
                lblEnemy2.Text = "";
                stValues.intCurrTar = 0;

            }

            //lets user know when 3rd enemy has been defeated
            else if (stValues.currentTarget.intHealth <= 0 && stValues.intCurrTar == 3)
            {
                AddMoveLbx(stValues.currentTarget.strName + " is defeated!");
                stValues.blnCurrentTargetAlive = false;
                stValues.enemyThreeAlive = false;
                lblEnemy3.Text = "";
                stValues.intCurrTar = 0;
            }

            //lets user know when 4th enemy has been defeated
            else if (stValues.currentTarget.intHealth <= 0 && stValues.intCurrTar == 4)
            {
                AddMoveLbx(stValues.currentTarget.strName + " is defeated!");
                stValues.blnCurrentTargetAlive = false;
                stValues.enemyFourAlive = false;
                lblEnemy4.Text = "";
                stValues.intCurrTar = 0;
            }
        }
        private void toEnemyTurn()
        {
            //creates random object for enemy attack
            Random ranEnemyHit = new Random();

            //a variable to hold how hard the enemy will hit
            int intCurrentEnemyHit = 0;

            //creates a random object to determine which ally the enemy will attack
            Random randWhoHit = new Random();

            //a variable to hold which ally is being hit
            int intCharHit = 0;

            if (stValues.enemyOneAlive == true && stValues.blnPlayerAlive == true)
            {
                //determines how much the enemy is hitting for this turn
                intCurrentEnemyHit = ranEnemyHit.Next(stValues.enemyOne.intAttack) + 1;

                //checks how many player party members are still alive
                if (stValues.blnAllyOneAlive == true && stValues.blnAllyTwoAlive == false)
                {
                    intCharHit = randWhoHit.Next(2);

                    //enemy attacks player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyOne.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy attacks 1st ally
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyOne.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                        //if ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyOne.Value)
                        {
                            AddMoveLbx(stValues.allyOne.strName + " has been defeated!");
                            stValues.blnAllyOneAlive = false;
                            pbarHealthAllyOne.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from the 1st ally's current health
                        else
                        {
                            pbarHealthAllyOne.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if 1st ally is dead but 2nd is alive
                else if (stValues.blnAllyOneAlive == false && stValues.blnAllyTwoAlive == true)
                {
                    intCharHit = randWhoHit.Next(2);

                    //enemy is attacking player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyOne.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 2nd ally
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyOne.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyTwo.strName);

                        //if 2nd ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyTwo.Value)
                        {
                            AddMoveLbx(stValues.allyTwo.strName + " has been defeated!");
                            stValues.blnAllyTwoAlive = false;
                            pbarHealthAllyTwo.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from 2nd ally's current health
                        else
                        {
                            pbarHealthAllyTwo.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                    //if both allies are alive
                    else if (stValues.blnAllyOneAlive == true && stValues.blnAllyTwoAlive == true)
                    {
                        intCharHit = randWhoHit.Next(3);

                        //enemy is attacking player character
                        if (intCharHit == 0)
                        {
                            AddMoveLbx(stValues.enemyOne.strName + " did " + intCurrentEnemyHit + " point(s) of damage to" + stValues.myCharacter.strName);

                            //if player's health drops to zero or less, the game is over
                            if (intCurrentEnemyHit > pbarHealthYours.Value)
                            {
                                defeated();
                            }

                            //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                            else
                            {
                                pbarHealthYours.Value -= intCurrentEnemyHit;
                            }
                        }

                        //enemy is attacking 1st ally 
                        else if (intCharHit == 1)
                        {
                            AddMoveLbx(stValues.enemyOne.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                            //if ally's health drops to zero or less, they are dead
                            if (intCurrentEnemyHit > pbarHealthAllyOne.Value)
                            {
                                AddMoveLbx(stValues.allyOne.strName + " has been defeated!");
                            stValues.blnAllyOneAlive = false;
                                pbarHealthAllyOne.Value = 0;
                            }

                            //if ally's health does not drop to 0, the enemy's hit is subtracted from the 1st ally's current health
                            else
                            {
                                pbarHealthAllyOne.Value -= intCurrentEnemyHit;
                            }
                        }

                        //enemy is attacking 2nd ally
                        else if (intCharHit == 2)
                        {
                            AddMoveLbx(stValues.enemyOne.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyTwo.strName);

                            //if 2nd ally's health drops to zero or less, they are dead
                            if (intCurrentEnemyHit > pbarHealthAllyTwo.Value)
                            {
                                AddMoveLbx(stValues.allyTwo.strName + " has been defeated!");
                            stValues.blnAllyTwoAlive = false;
                                pbarHealthAllyTwo.Value = 0;
                            }

                            //if ally's health does not drop to 0, the enemy's hit is subtracted from 2nd ally's current health
                            else
                            {
                                pbarHealthAllyTwo.Value -= intCurrentEnemyHit;
                            }
                        }
                    }

                        //if both allies are dead, player character is attacked
                        else
                        {
                            AddMoveLbx(stValues.enemyOne.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                            //if player's health drops to zero or less, the game is over
                            if (intCurrentEnemyHit > pbarHealthYours.Value)
                            {
                                defeated();
                            }

                            //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                            else
                            {
                                pbarHealthYours.Value -= intCurrentEnemyHit;
                            }
                        }
            }

            if (stValues.enemyTwoAlive == true && stValues.blnPlayerAlive == true)
            {
                //determines how much the enemy is hitting for this turn
                intCurrentEnemyHit = ranEnemyHit.Next(stValues.enemyTwo.intAttack) + 1;

                //checks how many player party members are still alive
                if (stValues.blnAllyOneAlive == true && stValues.blnAllyTwoAlive == false)
                {
                    intCharHit = randWhoHit.Next(2);

                    //enemy attacks player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyTwo.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drop to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                     //enemy attacks 1st ally
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyTwo.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                        //if ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyOne.Value)
                        {
                            AddMoveLbx(stValues.allyOne.strName + " has been defeated!");
                            stValues.blnAllyOneAlive = false;
                            pbarHealthAllyOne.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from the 1st ally's current health
                        else
                        {
                            pbarHealthAllyOne.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if 1st ally is dead but 2nd is alive
                else if (stValues.blnAllyOneAlive == false && stValues.blnAllyTwoAlive == true)
                {
                    intCharHit = randWhoHit.Next(2);

                    //enemy is attacking player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyTwo.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                     //enemy is attacking 2nd ally
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyTwo.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyTwo.strName);

                        //if 2nd ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyTwo.Value)
                        {
                            AddMoveLbx(stValues.allyTwo.strName + " has been defeated!");
                            stValues.blnAllyTwoAlive = false;
                            pbarHealthAllyTwo.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from 2nd ally's current health
                        else
                        {
                            pbarHealthAllyTwo.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if both allies are alive
                else if (stValues.blnAllyOneAlive == true && stValues.blnAllyTwoAlive == true)
                {
                    intCharHit = randWhoHit.Next(3);

                    //enemy is attacking player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyTwo.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 1st ally 
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyTwo.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                        //if ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyOne.Value)
                        {
                            AddMoveLbx(stValues.allyOne.strName + " has been defeated!");
                            stValues.blnAllyOneAlive = false;
                            pbarHealthAllyOne.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from the 1st ally's current health
                        else
                        {
                            pbarHealthAllyOne.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 2nd ally
                    else if (intCharHit == 2)
                    {
                        AddMoveLbx(stValues.enemyTwo.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyTwo.strName);

                        //if 2nd ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyTwo.Value)
                        {
                            AddMoveLbx(stValues.allyTwo.strName + " has been defeated!");
                            stValues.blnAllyTwoAlive = false;
                            pbarHealthAllyTwo.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from 2nd ally's current health
                        else
                        {
                            pbarHealthAllyTwo.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if both allies are dead, player character is attacked
                else
                {
                    AddMoveLbx(stValues.enemyTwo.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                    //if player's health drops to zero or less, the game is over
                    if (intCurrentEnemyHit > pbarHealthYours.Value)
                    {
                        defeated();
                    }

                    //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                    else
                    {
                        pbarHealthYours.Value -= intCurrentEnemyHit;
                    }
                }
            }

            if (stValues.enemyThreeAlive == true && stValues.blnPlayerAlive == true)
            {
                //determines how much the enemy is hitting for this turn
                intCurrentEnemyHit = ranEnemyHit.Next(stValues.enemyThree.intAttack) + 1;

                //checks how many player party members are still alive
                if (stValues.blnAllyOneAlive == true && stValues.blnAllyTwoAlive == false)
                {
                    intCharHit = randWhoHit.Next(2);

                    //enemy attacks player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyThree.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy attacks 1st ally
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyThree.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                        //if ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyOne.Value)
                        {
                            AddMoveLbx(stValues.allyOne.strName + " has been defeated!");
                            stValues.blnAllyOneAlive = false;
                            pbarHealthAllyOne.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from the 1st ally's current health
                        else
                        {
                            pbarHealthAllyOne.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if 1st ally is dead but 2nd is alive
                else if (stValues.blnAllyOneAlive == false && stValues.blnAllyTwoAlive == true)
                {
                    intCharHit = randWhoHit.Next(2);

                    //enemy is attacking player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyThree.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 2nd ally
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyThree.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyTwo.strName);

                        //if 2nd ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyTwo.Value)
                        {
                            AddMoveLbx(stValues.allyTwo.strName + " has been defeated!");
                            stValues.blnAllyTwoAlive = false;
                            pbarHealthAllyTwo.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from 2nd ally's current health
                        else
                        {
                            pbarHealthAllyTwo.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if both allies are alive
                else if (stValues.blnAllyOneAlive == true && stValues.blnAllyTwoAlive == true)
                {
                    intCharHit = randWhoHit.Next(3);

                    //enemy is attacking player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyThree.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 1st ally 
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyThree.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                        //if ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyOne.Value)
                        {
                            AddMoveLbx(stValues.allyOne.strName + " has been defeated!");
                            stValues.blnAllyOneAlive = false;
                            pbarHealthAllyOne.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from the 1st ally's current health
                        else
                        {
                            pbarHealthAllyOne.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 2nd ally
                    else if (intCharHit == 2)
                    {
                        AddMoveLbx(stValues.enemyThree.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyTwo.strName);

                        //if 2nd ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyTwo.Value)
                        {
                            AddMoveLbx(stValues.allyTwo.strName + " has been defeated!");
                            stValues.blnAllyTwoAlive = false;
                            pbarHealthAllyTwo.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from 2nd ally's current health
                        else
                        {
                            pbarHealthAllyTwo.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if both allies are dead, player character is attacked
                else
                {
                    AddMoveLbx(stValues.enemyThree.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                    //if player's health drops to zero or less, the game is over
                    if (intCurrentEnemyHit > pbarHealthYours.Value)
                    {
                        defeated();
                    }

                    //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                    else
                    {
                        pbarHealthYours.Value -= intCurrentEnemyHit;
                    }
                }
            }

            if (stValues.enemyFourAlive == true && stValues.blnPlayerAlive == true)
            {
                //determines how much the enemy is hitting for this turn
                intCurrentEnemyHit = ranEnemyHit.Next(stValues.enemyFour.intAttack) + 1;
                //checks how many player party members are still alive
                if (stValues.blnAllyOneAlive == true && stValues.blnAllyTwoAlive == false)
                {
                    intCharHit = randWhoHit.Next(2);

                    //enemy attacks player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyFour.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy attacks 1st ally
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyFour.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                        //if ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyOne.Value)
                        {
                            AddMoveLbx(stValues.allyOne.strName + " has been defeated!");
                            stValues.blnAllyOneAlive = false;
                            pbarHealthAllyOne.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from the 1st ally's current health
                        else
                        {
                            pbarHealthAllyOne.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if 1st ally is dead but 2nd is alive
                else if (stValues.blnAllyOneAlive == false && stValues.blnAllyTwoAlive == true)
                {
                    intCharHit = randWhoHit.Next(2);

                    //enemy is attacking player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyFour.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 2nd ally
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyFour.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyTwo.strName);

                        //if 2nd ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyTwo.Value)
                        {
                            AddMoveLbx(stValues.allyTwo.strName + " has been defeated!");
                            stValues.blnAllyTwoAlive = false;
                            pbarHealthAllyTwo.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from 2nd ally's current health
                        else
                        {
                            pbarHealthAllyTwo.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if both allies are alive
                else if (stValues.blnAllyOneAlive == true && stValues.blnAllyTwoAlive == true)
                {
                    intCharHit = randWhoHit.Next(3);

                    //enemy is attacking player character
                    if (intCharHit == 0)
                    {
                        AddMoveLbx(stValues.enemyFour.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                        //if player's health drops to zero or less, the game is over
                        if (intCurrentEnemyHit > pbarHealthYours.Value)
                        {
                            defeated();
                        }

                        //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                        else
                        {
                            pbarHealthYours.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 1st ally 
                    else if (intCharHit == 1)
                    {
                        AddMoveLbx(stValues.enemyFour.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyOne.strName);

                        //if ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyOne.Value)
                        {
                            AddMoveLbx(stValues.allyOne.strName + " has been defeated!");
                            stValues.blnAllyOneAlive = false;
                            pbarHealthAllyOne.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from the 1st ally's current health
                        else
                        {
                            pbarHealthAllyOne.Value -= intCurrentEnemyHit;
                        }
                    }

                    //enemy is attacking 2nd ally
                    else if (intCharHit == 2)
                    {
                        AddMoveLbx(stValues.enemyFour.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.allyTwo.strName);

                        //if 2nd ally's health drops to zero or less, they are dead
                        if (intCurrentEnemyHit > pbarHealthAllyTwo.Value)
                        {
                            AddMoveLbx(stValues.allyTwo.strName + " has been defeated!");
                            stValues.blnAllyTwoAlive = false;
                            pbarHealthAllyTwo.Value = 0;
                        }

                        //if ally's health does not drop to 0, the enemy's hit is subtracted from 2nd ally's current health
                        else
                        {
                            pbarHealthAllyTwo.Value -= intCurrentEnemyHit;
                        }
                    }
                }

                //if both allies are dead, player character is attacked
                else
                {
                    AddMoveLbx(stValues.enemyFour.strName + " did " + intCurrentEnemyHit + " point(s) of damage to " + stValues.myCharacter.strName);

                    //if player's health drops to zero or less, the game is over
                    if (intCurrentEnemyHit > pbarHealthYours.Value)
                    {
                        defeated();
                    }

                    //if player's health does not drops to 0, the enemy's hit is subtracted from the player's current health
                    else
                    {
                        pbarHealthYours.Value -= intCurrentEnemyHit;
                    }
                }
            }

            if (stValues.blnPlayerAlive == true)
            {
                //turns control over to player for player's turn
                btnAttack.Enabled = true;
            }
        }

        private void bossBattle()
        {
            //sets battle mode to active
            stValues.blnModeBattle = true;
            stValues.splyFightItOut.PlayLooping();

            //enables buttons for battle use, disables exploration buttons
            btnAttack.Enabled = true;
            btnUseItem.Enabled = true;
            btnRunAway.Enabled = true;
            btnSpell.Enabled = false;
            btnInspect.Enabled = false;
            btnGrabItem.Enabled = false;
            btnNav1.Enabled = false;
            btnNav2.Enabled = false;
            btnNav3.Enabled = false;

            //creates boss enemy that will only be fought once
            stValues.enemyOne.initEnemy(5);
            stValues.blnBossFought = true;

            //pulls enemy information from class properties & sets current enemy properties to same
            stValues.enemyOneAlive = true;
            lblEnemy1.Text = stValues.enemyOne.strName;
            AddMoveLbx("You've been attacked by " + stValues.enemyOne.strName + "!");
            AddMoveLbx("It has " + stValues.enemyOne.intHealth + " health!");
            stValues.currentTarget = stValues.enemyOne;
        }

        //you will be attacked by spiders every time you enter the spider's nest
        private void spiderFight()
        {
            //sets battle mode to active
            stValues.blnModeBattle = true;
            stValues.splyFightItOut.PlayLooping();

            //enables buttons for battle use, disables exploration buttons
            btnAttack.Enabled = true;
            btnUseItem.Enabled = true;
            btnRunAway.Enabled = true;
            btnSpell.Enabled = false;
            btnInspect.Enabled = false;
            btnGrabItem.Enabled = false;
            btnNav1.Enabled = false;
            btnNav2.Enabled = false;
            btnNav3.Enabled = false;

            //makes an enemy
            //same for others
            stValues.enemyOne.initEnemy(6);
            lblEnemy1.Text = stValues.enemyOne.strName;
            stValues.enemyOneAlive = true;
            AddMoveLbx("You've been attacked by " + stValues.enemyOne.strName + "!");
            AddMoveLbx("It has " + stValues.enemyOne.intHealth + " health!");
            stValues.currentTarget = stValues.enemyOne;

            stValues.enemyTwo.initEnemy(7);
            lblEnemy2.Text = stValues.enemyTwo.strName;
            stValues.enemyTwoAlive = true;
            AddMoveLbx("You've been attacked by " + stValues.enemyTwo.strName + "!");
            AddMoveLbx("It has " + stValues.enemyTwo.intHealth + " health!");

            stValues.enemyThree.initEnemy(7);
            lblEnemy3.Text = stValues.enemyThree.strName;
            stValues.enemyThreeAlive = true;
            AddMoveLbx("You've been attacked by " + stValues.enemyThree.strName + "!");
            AddMoveLbx("It has " + stValues.enemyThree.intHealth + " health!");

            stValues.enemyFour.initEnemy(7);
            lblEnemy4.Text = stValues.enemyFour.strName;
            stValues.enemyFourAlive = true;
            AddMoveLbx("You've been attacked by " + stValues.enemyFour.strName + "!");
            AddMoveLbx("It has " + stValues.enemyFour.intHealth + " health!");
        }

        //a method to shake the form when a critical hit is performed
        private void Shake(Form frmConsole)
        {
            //variable to hold form's original position
            var vOriginal = frmConsole.Location;

            //random number generator to give form points to shake to
            Random ranRnd = new Random(1337);

            //variable for how many times/how long the form shakes
            const int intShake_Amplitude = 10;

            //shakes form 
            for (int i = 0; i < intShake_Amplitude; i++)
            {
                //shakes form along both x and y axis
                frmConsole.Location = new Point(vOriginal.X + ranRnd.Next(-intShake_Amplitude, intShake_Amplitude), vOriginal.Y + ranRnd.Next(-intShake_Amplitude, intShake_Amplitude));
                System.Threading.Thread.Sleep(20);
            }

            //returns form to original position
            frmConsole.Location = vOriginal;

            AddMoveLbx("A powerful blow!");
        }

        private void btnRunAway_Click(object sender, EventArgs e)
        {
            //creates a random object to see if player escapes successfully
            Random ranRunAway = new Random();

            int intRan = ranRunAway.Next(2);

            //player successfully runs, ends battle
            if(intRan == 1)
            {
                AddMoveLbx("You got away!");
                stValues.splyRunSafe.Play();
                stValues.enemyOneAlive = false;
                lblEnemy1.Text = "";
                stValues.enemyTwoAlive = false;
                lblEnemy2.Text = "";
                stValues.enemyThreeAlive = false;
                lblEnemy3.Text = "";
                stValues.enemyFourAlive = false;
                lblEnemy4.Text = "";
                toExploreMode();
            }

            //player is unsuccessful at running, enemy gets free turn
            else
            {
                AddMoveLbx("You were stopped by the enemy!");
                toEnemyTurn();
            }
        }

        //ends game when player's HP drops to 0 or below
        private void defeated()
        {
            pbarHealthYours.Value = 0;
            stValues.splyYouDied.Play();
            AddMoveLbx("You have been defeated!");
            stValues.blnPlayerAlive = false;
            btnAttack.Enabled = false;
            btnDropItem.Enabled = false;
            btnGrabItem.Enabled = false;
            btnInspect.Enabled = false;
            btnRunAway.Enabled = false;
            btnSpell.Enabled = false;
            btnTalk.Enabled = false;
            btnUseItem.Enabled = false;
        }

        //player can cast a spell that will increase either health or attack power for the main character as well as switch from day to night and vice versa
        private void btnSpell_Click(object sender, EventArgs e)
        {
            stValues.splySpellCast.Play();
            //checks if main character has enough spell points to cast
            if (stValues.myCharacter.intSpellPoints >= 15)
            {
                //if currently Night, spell will increase health
                if (stValues.blnDayNight == false)
                {
                    pbarManaYours.Value -= 15;
                    stValues.myCharacter.intSpellPoints -= 15;
 
                    if (pbarHealthYours.Value <= pbarHealthYours.Maximum / 2)
                    {
                        stValues.myCharacter.intHealth += stValues.myCharacter.intHealth;
                        pbarHealthYours.Value = stValues.myCharacter.intHealth;
                    }

                    else
                    {
                        stValues.myCharacter.intHealth = pbarHealthYours.Maximum;
                        pbarHealthYours.Value = pbarHealthYours.Maximum;
                    }

                    //spell switches day and night
                    AddMoveLbx("You feel healthier!");
                    stValues.blnDayNight = true;
                    lblNightDay.ForeColor = System.Drawing.Color.Yellow; 
                    lblNightDay.Text = "Daybreak";
                }

                //if currently Day, spell will increase attack
                else if(stValues.blnDayNight == true)
                {
                    pbarManaYours.Value -= 15;
                    stValues.myCharacter.intSpellPoints -= 15;
                    stValues.myCharacter.intAttack += 10;
                    AddMoveLbx("You feel stronger!");
                    stValues.blnDayNight = false;
                    lblNightDay.ForeColor = System.Drawing.Color.DarkGreen;
                    lblNightDay.Text = "Nightfall";
                }
            }

               //if character does not have enough spell points to cast spell, program lets them know
            else
            {
                AddMoveLbx("You don't have enough mana to cast your spell.");
            }

            //sets music back to background music
            if (stValues.strCurrentRoom == stValues.aryStrRoom[1] || stValues.strCurrentRoom == stValues.aryStrRoom[6] || stValues.strCurrentRoom == stValues.aryStrRoom[7] || stValues.strCurrentRoom == stValues.aryStrRoom[8])
            {
                stValues.splyIndustrialTheme.PlayLooping();
            }

            else
            {
                stValues.splyJungleTheme.PlayLooping();
            }
        }

        //user click the talk buton
        private void btnTalk_Click(object sender, EventArgs e)
        {


            // Check to see if there is an NPC and if the player is in battle. In battle, no talking allowed. This isn't Dragonball Z.
            if (stValues.strNPC == "" && stValues.blnModeBattle == false)
            {
                AddMoveLbx("There is no one here to talk to!"); // If there is no one to talk to, this message is displayed.
            }

            else if (stValues.blnModeBattle == true) // shut up and fight
            {
                AddMoveLbx("These enemies aren't interested in talking."); // You do not talk about fight club
            }

                // "modeBattle" MUST be set to 0 for all of these!
                // NPC will be mentioned by name. These do not need to be added to the database, unless btnTalk_Click sets off an Event.
                // modeTalk must be set to '1' in every dialogue.

            else if (stValues.strNPC == "Frog" && stValues.blnModeBattle == false) 
            {
                stValues.blnModeTalk = true;
                lblRoomDesc.Text = "Frog: 'Ribbit ribbit, I am an average frog. Nothing to be alarmed about. Carry on. Ribbit, ribbit.'";
            }
        }

        // Items
        // These are event handlers that deal with interactions with 'items'.
        //user click the inspect button
        private void btnInspect_Click(object sender, EventArgs e)
        {
            //mekses sure item isn't inspect before
           //same for the others
            if((stValues.strItemInteract == "Item 1") && (stValues.aryLblItems[0].Text == "Items"))
            {
                //dipsalys what the items is
                stValues.aryLblItems[0].Text = stValues.arystrWhatItemsIs[0];
            }
            //now what the items is
            else
            {
                //adds to the battls listbox
                AddMoveLbx("can't inspect an item you know what is");
            }

            if((stValues.strItemInteract == "Item 2") && (stValues.aryLblItems[1].Text == "Items"))
            {
                stValues.aryLblItems[1].Text = stValues.arystrWhatItemsIs[1];
            }
            else
            {
                //adds to the battls listbox
                AddMoveLbx("can't inspect an item you know what is");
            }

            if ((stValues.strItemInteract == "Item 3") && (stValues.aryLblItems[2].Text == "Items"))
            {
                stValues.aryLblItems[2].Text = stValues.arystrWhatItemsIs[2];
            }
            else
            {
                //adds to the battls listbox
                AddMoveLbx("can't inspect an item you know what is");
            }

            if ((stValues.strItemInteract == "Item 4") && (stValues.aryLblItems[3].Text == "Items"))
            {
                stValues.aryLblItems[3].Text = stValues.arystrWhatItemsIs[3];
            }
            else
            {
                //adds to the battls listbox
                AddMoveLbx("can't inspect an item you know what is");
            }
        }

        //user picsk up an item
        private void btnGrabItem_Click(object sender, EventArgs e)
        {
            //same for the others
            //if they click the an items label
            if (stValues.strItemInteract == "Item 1")
            {
                //items is one of the two items
                if((stValues.aryLblItems[0].Text == "Restore 20 HP") || (stValues.aryLblItems[0].Text == "Restore 20 MP"))
                {
                    //grabs the item
                    grabHelper(0);
                }
                //not item
                else
                {
                    //display what the user should do
                    AddMoveLbx("Inspect an item first");
                }
            }
            else if (stValues.strItemInteract == "Item 2")
            {
                if ((stValues.aryLblItems[1].Text == "Restore 20 HP") || (stValues.aryLblItems[1].Text == "Restore 20 MP"))
                {
                    grabHelper(1);
                }
                else
                {
                    AddMoveLbx("Inspect an item first");
                }
            }
            else if (stValues.strItemInteract == "Item 3")
            {
                if ((stValues.aryLblItems[2].Text == "Restore 20 HP") || (stValues.aryLblItems[2].Text == "Restore 20 MP"))
                {
                    grabHelper(2);
                }
                else
                {
                    AddMoveLbx("Inspect an item first");
                }
            }
            else if (stValues.strItemInteract == "Item 4")
            {
                if ((stValues.aryLblItems[3].Text == "Restore 20 HP") || (stValues.aryLblItems[3].Text == "Restore 20 MP"))
                {
                    grabHelper(3);
                }
                else
                {
                    AddMoveLbx("Inspect an item first");
                }
            }
            else
            {
                AddMoveLbx("What Item do you");
            }
        }

        //handes the grab
        private void grabHelper (int intWhichItem)
        {
            //adds the down drop list
            cmbItems.Items.Add(stValues.aryLblItems[intWhichItem].Text);
            //changes that labels text to nothing
            stValues.aryLblItems[intWhichItem].Text = "";
            //dipslayt item item in the textbox over the combox
            txtItems.Text = cmbItems.Items[0].ToString();
        }

        //user click the drop item
        private void btnDropItem_Click(object sender, EventArgs e)
        {
            //drop the first item
            if(cmbItems.Items.Count == 0)
            {
                //dispalky what the user should ndo
                AddMoveLbx("Sorry you need to have items before you can use them");
            }
            //drop the end
            else
            {
                //handles the drop
                dropHelper();
            }
        }

        //works the drop does
        private void dropHelper ()
        {
            //walks the list in the combox 
            for (int lcv = 0; lcv < cmbItems.Items.Count; lcv++)
            {
                //where the text in the textbox matchs items in the combo box
                if (txtItems.Text == (string)cmbItems.Items[lcv])
                {
                    //remove that item
                    cmbItems.Items.RemoveAt(lcv);
                    //stops the loop
                    break;
                }
            }

            //fi the taht remove all of the items
            if (cmbItems.Items.Count == 0)
            {
                //display nothign
                txtItems.Text = "";
            }
            //items remains
            else
            {
                //set the tetbox to the first item
                txtItems.Text = cmbItems.Items[0].ToString();
            }
        }

        //user lcik the button
        private void btnUseItem_Click(object sender, EventArgs e)
        {
            //see theres items
            if (cmbItems.Items.Count != 0)
            {
                //see if the click the main chacter
                if (stValues.strPerson == lblYourName.Text)
                {
                    //check the main chacter is live
                    if (stValues.myCharacter.intHealth >= 1)
                    {
                        //check what item there are using
                        //same fot hte othere
                        if (txtItems.Text == "Restore 20 MP")
                        {
                            //adds to there healht
                            pbarManaYours.Value += 20;
                            //remove the item
                            dropHelper();
                        }
                        else if (txtItems.Text == "Restore 20 HP")
                        {
                            pbarHealthYours.Value += 20;
                            dropHelper();
                        }
                    }
                    //chacter is died
                    else
                    {
                        //siaply what the user shoudl do
                        AddMoveLbx("Character must be alive");
                    }
                }
                //user lcik the ally 
               //same for thje other ally
                else if (stValues.strPerson == lblYourName.Text)
                {
                    if (stValues.blnAllyOneAlive == true)
                    {
                        //allys only have health
                      if (txtItems.Text == "Restore 20 HP")
                        {
                            pbarHealthAllyOne.Value += 10;
                            dropHelper();
                        }
                      //user try to use the magic item
                      else
                        {
                            //disaply whta the user shouuld do
                            AddMoveLbx("Sorry only main character have mana");
                        }
                    }
                    else
                    {
                        AddMoveLbx("Character must be alive");
                    }
                }
                else if (stValues.strPerson == lblYourName.Text)
                {
                    if (stValues.blnAllyTwoAlive == true)
                    {
                        if (txtItems.Text == "Restore 20 HP")
                        {
                            pbarHealthAllyTwo.Value += 10;
                            dropHelper();
                        }
                        else
                        {
                            AddMoveLbx("Sorry only main character have mana");
                        }
                    }
                    else
                    {
                        AddMoveLbx("Character must be alive");
                    }
                }
                //got to select chacter first
                else
                {
                    //disaply whta the user shouuld do
                    AddMoveLbx("Who using the item");
                }
            }
            //needs items
            else
            {
                //disaply whta the user shouuld do
                AddMoveLbx("Sorry need items");
            }
        }

        private void lblRoomDesc_Click(object sender, EventArgs e)
        {
            // Clicking a 'talk' dialogue (Literally clicking on lblRoomDesc) should always revert the text back to the appropriate room's description.
            // modeTalk must be set back to '0' in every instance of this event handler being used.

            if (stValues.blnModeTalk == true && stValues.strCurrentRoom == stValues.aryStrRoom[0])
            {
                lblRoomDesc.Text = stValues.aryStrRoomDesc[0];
                lblRoomTitle.Text = stValues.aryStrRoom[0];
                stValues.blnModeTalk = false;
            }
        }

        private void lowBattleOdds()
        {
            //random chance for battle to start
            Random ranFightItOut = new Random();

            //make it a one in three chance for random battle
            int battleStart = ranFightItOut.Next(3);

            //battle happens
            if (battleStart == 1)
            {
                //calls battle method
                toBattle();

            }

            //battle does not happen
            else
            {
                AddMoveLbx("It seems safe enough here for now.");
            }
        }

        private void medBattleOdds()
        {
            //random chance for battle to start
            Random ranFightItOut = new Random();

            //make it a one in two chance for random battle
            int intBattleStart = ranFightItOut.Next(2);

            //battle happens
            if (intBattleStart == 1)
            {
                //calls battle method
                toBattle();
            }

            //battle does not happen
            else
            {
                AddMoveLbx("It seems safe enough here for now.");
            }
        }

        private void highBattleOdds()
        {
            //random chance for battle to start
            Random ranFightItOut = new Random();

            //make it a three in four chance for random battle
            int intBattleStart = ranFightItOut.Next(4);

            //battle happens
            if (intBattleStart != 1)
            {
                //calls battle method
                toBattle();
            }

            //battle does not happen
            else
            {
                AddMoveLbx("It seems safe enough here for now.");
            }
        }

        private void toBattle()
        {
            //sets battle mode to active
            stValues.blnModeBattle = true;
            stValues.splyFightItOut.PlayLooping();

            //enables buttons for battle use, disables exploration buttons
            btnAttack.Enabled = true;
            btnUseItem.Enabled = true;
            btnRunAway.Enabled = true;
            btnSpell.Enabled = false;
            btnInspect.Enabled = false;
            btnGrabItem.Enabled = false;
            btnNav1.Enabled = false;
            btnNav2.Enabled = false;
            btnNav3.Enabled = false;

            //creates random object to determine which enemy/enemies will be fought
            Random ranEnemyToFight = new Random();

            //creates random object to determine how many enemies will be fought
            Random ranNumEnemies = new Random();

            //randomly decides how many enemies will be fought (1-4)
            int intNumberFoes = ranNumEnemies.Next(4) + 1;

            //randomly decides which enemy will be fought
            int intWhichEnemy = ranEnemyToFight.Next(5);

            //sets enemy to be fought to enemy from array
            stValues.enemyOne.initEnemy(intWhichEnemy);

            //pulls enemy information from class properties & sets current enemy properties to same
            stValues.enemyOneAlive = true;
            lblEnemy1.Text = stValues.enemyOne.strName;
            AddMoveLbx("You've been attacked by " + stValues.enemyOne.strName + "!");
            AddMoveLbx("It has " + stValues.enemyOne.intHealth + " health!");
            stValues.currentTarget = stValues.enemyOne;

            //creates up to four enemies 
            if (intNumberFoes > 1)
            {
                //randomly decides which enemy will be fought for second foe
                intWhichEnemy = ranEnemyToFight.Next(5);

                //sets second enemy to be fought to enemy from array
                stValues.enemyTwo.initEnemy(intWhichEnemy);

                //pulls second enemy information from class properties & sets current enemy properties to same
                stValues.enemyTwoAlive = true;
                lblEnemy2.Text = stValues.enemyTwo.strName;
                AddMoveLbx("You've been attacked by " + stValues.enemyTwo.strName + "!");
                AddMoveLbx("It has " + stValues.enemyTwo.intHealth + " health!");

                if(intNumberFoes > 2)
                {
                    //randomly decides which enemy will be fought for third foe
                    intWhichEnemy = ranEnemyToFight.Next(5);

                    //sets third enemy to be fought to enemy from array
                    stValues.enemyThree.initEnemy(intWhichEnemy);

                    //pulls third enemy information from class properties & sets current enemy properties to same
                    stValues.enemyThreeAlive = true;
                    lblEnemy3.Text = stValues.enemyThree.strName;
                    AddMoveLbx("You've been attacked by " + stValues.enemyThree.strName + "!");
                    AddMoveLbx("It has " + stValues.enemyThree.intHealth + " health!");

                    if(intNumberFoes > 3)
                    {
                        //randomly decides which enemy will be fought for fourth foe
                        intWhichEnemy = ranEnemyToFight.Next(5);

                        //sets fourth enemy to be fought to enemy from array
                        stValues.enemyFour.initEnemy(intWhichEnemy);

                        //pulls fourth enemy information from class properties & sets current enemy properties to same
                        stValues.enemyFourAlive = true;
                        lblEnemy4.Text = stValues.enemyFour.strName;
                        AddMoveLbx("You've been attacked by " + stValues.enemyFour.strName + "!");
                        AddMoveLbx("It has " + stValues.enemyFour.intHealth + " health!");
                    }
                }
            }
        }

        private void toExploreMode()
        {
            //makes an copy of message ofrm
            frmMessages fMessage = new frmMessages();
            //,makes an random object
            Random ranDrop = new Random();

            //drop item after battle
            int intDropHappen = 0;

            //10% of battle get item
            intDropHappen = ranDrop.Next(10) + 1;

            //disables battle/event mode
            stValues.blnModeBattle = false;

            //enables buttons for exploration, disables buttons for battle
            btnNav1.Enabled = true;
            btnNav2.Enabled = true;
            btnNav3.Enabled = true;
            btnAttack.Enabled = false;
            btnRunAway.Enabled = false;
            btnSpell.Enabled = true;
            btnInspect.Enabled = true;
            btnGrabItem.Enabled = true;

            //if battle has item
            if(intDropHappen == 1)
            {
                //see what that items is
                intDropHappen = ranDrop.Next(1);

                //user got an health item
                if(intDropHappen == 1)
                {
                    //same for the magic item
                    //adds that to the combox 
                    cmbItems.Items.Add(stValues.smallHP.strName);
                    // displaty the top item
                    txtItems.Text = cmbItems.Items[0].ToString();
                }
                //user got an magic item
                else
                {
                    cmbItems.Items.Add(stValues.smallMP.strName);
                    txtItems.Text = cmbItems.Items[0].ToString();
                }
            }

            //sets music back to background music

            if (stValues.strCurrentRoom == stValues.aryStrRoom[1] || stValues.strCurrentRoom == stValues.aryStrRoom[6] || stValues.strCurrentRoom == stValues.aryStrRoom[7] || stValues.strCurrentRoom == stValues.aryStrRoom[8])
            {
                stValues.splyIndustrialTheme.PlayLooping();
            }

            else
            {
                stValues.splyJungleTheme.PlayLooping();
            }

            //see if there in the last rooom
            if (stValues.strCurrentRoom == "1-12 Jungle Temple")
            {
                //disaply a message
                fMessage.blnRiddle = true;
                //what the message is
                fMessage.strMessage = "The evil unicorn falls to his knees, breathing heavily, near the throes of death. \"You fools \", he pants, \"Putting my master in prison won't bring peace to this world. You are merely pawns for the real enemy - the Council of Nations! They are only interested in power and squashing anyone who stands up to them. YOU WILL REGRET THIS. \" but with a mighty swing of your sword, you put down the final enemy standing between you and your objective.You are a mercenary first, and all the political nonsense comes second to completing your mission." + "The Consul has been brought out and arrested. Princess Miranda sends you another message: \"Excellent work, " + stValues.myCharacter.strName + "! Because of your bravery, the world is one step closer to living in peace once more! \" However, the dying evil unicorn's words echo in your mind, and you can only wonder if that is truly the case";
                //show thaat form
                fMessage.ShowDialog();
            }
        }

        // This was the original size of the dungeon. Rooms 0 - 11 have been implemented, and some of the names have been changed.
        // This list is for reference to the -original- design only. The final project version only contains the first level.

            //// Dark Jungle  0 - 11
            //"1-1 Jungle Entrance", "1-2 Jungle Chamber A", "1-3 Jungle Hallway A", "1-4 Jungle Hallway B", "1-5 Jungle Hallway C1", "1-6 Jungle Hallway C2",
            //"1-7 Jungle Chamber B", "1-8", "1-9 Jungle Hallway D", "1-10 Jungle Chamber C", "1-11 Jungle Chamber D", "1-12 Jungle Hidden Chamber", 

            //// Steampunk  12 - 31
            //"2-1 Boiler Room", "2-2 East Wing A", "2-3 East Wing B", "2-4 Mechanical Support Bay A", "2-5 Men's Bathroom", "2-6 Mechanical Support Bay B", "2-7 Women's Bathroom",
            //"2-8 Center Hall", "2-9 Gearbox Area A", "2-10 Gearbox Area B", "2-11 Gearbox Area C", "2-12 Gearbox Area D", "2-13 West Wing A", "2-14 West Wing B",
            //"2-15 Turbine Room", "2-16 Primary Control Area A", "2-17 Primary Control Area B", "2-18 Generator Room", "2-19 Elevator Room",

            //// Metal 32 - 52
            //"3-1 Metal Fortress Basement", "3-2 Armory A", "3-3 Armory B", "3-4 Armory C", "3-5 Armory Command Center", "3-6 Cybernetica Alpha", "3-7 Cybernetica Beta",
            //"3-8 Cybernetica Delta", "3-9 Cybernetica Gamma", "3-10 Bunker Entrance", "3-11 Bunker interior A", "3-12 Bunker interior B", "3-13 Kitchen", "3-14 Bunker interior C",
            //"3-15 Bunker interior D", "3-16 Red Room", "3-17 Secret Love Chamber", "3-18 Metal Temple", "3-19 Metal Shrine", "3-20 Pure Light Room"

        private void nav1_Click(object sender, EventArgs e)
        {
            // nav 1
            // changeTheme(1);
            //same for ohters
            //where the user can mvoe
            if (stValues.strCurrentRoom == stValues.aryStrRoom[0])
            {
                //move to thaat rooom
                moveToRoom(2);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[1])
            {
                moveToRoom(2);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[2])
            {
                moveToRoom(0);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[3])
            {
                moveToRoom(2);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[4])
            {
                moveToRoom(3);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[8])
            {
                //plays music
                stValues.splyJungleTheme.PlayLooping();
                moveToRoom(4);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[9])
            {
                stValues.splyIndustrialTheme.PlayLooping();
                moveToRoom(8);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[10])
            {
                stValues.splyIndustrialTheme.PlayLooping();
                moveToRoom(8);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[5])
            {
                moveToRoom(3);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[6])
            {
                stValues.splyJungleTheme.PlayLooping();
                moveToRoom(5);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[7])
            {
                moveToRoom(6);
            }
            //no rooms was chonicen
            else
            {
                //disaply whta the user shouuld do
                AddMoveLbx("Where are you going?");
            }


        } // ^ Nav 1

        private void nav2_Click(object sender, EventArgs e)
        {
            // nav 2
            if (stValues.strCurrentRoom == stValues.aryStrRoom[2])
            {
                stValues.splyIndustrialTheme.PlayLooping();
                moveToRoom(1);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[3])
            {
                moveToRoom(4);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[4])
            {
                stValues.splyIndustrialTheme.PlayLooping();
                moveToRoom(8);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[8])
            {
                stValues.splyJungleTheme.PlayLooping();
                moveToRoom(9);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[6])
            {
                stValues.splyIndustrialTheme.PlayLooping();
                moveToRoom(7);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[5])
            {
                moveToRoom(6);
            }

            else
            {
                AddMoveLbx("Where are you going?");
            }
            
        } // ^ Nav 2

        private void nav3_Click(object sender, EventArgs e)
        {
            // nav 3
            if (stValues.strCurrentRoom == stValues.aryStrRoom[2])
            {
                moveToRoom(3);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[3])
            {
                moveToRoom(5);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[8])
            {
                stValues.splyJungleTheme.PlayLooping();
                moveToRoom(10);
            }

            else if (stValues.strCurrentRoom == stValues.aryStrRoom[9])
            {
                moveToRoom(11);
            }

            else
            {
                AddMoveLbx("Where are you going?");
            }

        }// ^ Nav 3

        //sets current battle target to whichever enemy name is clicked
        private void lblEnemy1_Click(object sender, EventArgs e)
        {
            if(stValues.enemyOneAlive == true)
            {
                stValues.currentTarget = stValues.enemyOne;
                stValues.blnCurrentTargetAlive = true;
                stValues.intCurrTar = 1;
            }

            //if enemy is already dead, cannot be selected
            else
            {
                lbxBattle.Text = ("There's nothing there!");
            }
        }

        private void lblEnemy2_Click(object sender, EventArgs e)
        {
            if(stValues.enemyTwoAlive == true)
            {
                stValues.currentTarget = stValues.enemyTwo;
                stValues.blnCurrentTargetAlive = true;
                stValues.intCurrTar = 2;
            }

            else
            {
                lbxBattle.Text = ("There's nothing there!");
            }
        }

        private void lblEnemy3_Click(object sender, EventArgs e)
        {
            if(stValues.enemyThreeAlive == true)
            {
                stValues.currentTarget = stValues.enemyThree;
                stValues.blnCurrentTargetAlive = true;
                stValues.intCurrTar = 3;
            }

            else
            {
                lbxBattle.Text = ("There's nothing there!");
            }
        }

        private void lblEnemy4_Click(object sender, EventArgs e)
        {
            if(stValues.enemyFourAlive == true)
            {
                stValues.currentTarget = stValues.enemyFour;
                stValues.blnCurrentTargetAlive = true;
                stValues.intCurrTar = 4;
            }

            else
            {
                lbxBattle.Text = ("There's nothing there!"); 
            }
        }
        //user whens to save there game
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //see if it all works
            try
            {
                //makes an save file object
                StreamWriter saveGame;
                //display where they when that file
                sfdSave.ShowDialog();
                //String roomNow = currentRoom.ToString();
                //makes string of all non string varibles
                string strMainHealth = pbarHealthYours.Value.ToString();
                string strMainAttk  = stValues.myCharacter.intAttack.ToString();
                string strMainSpell = pbarManaYours.Value.ToString();
                string strMainGender = stValues.myCharacter.blnGender.ToString();
                string strAllyOneHealth = pbarHealthAllyOne.Value.ToString();
                string strAlly1Alive = stValues.blnAllyOneAlive.ToString();
                string strAllyTwoHealth = pbarHealthAllyTwo.Value.ToString();
                string strAlly2Alive = stValues.blnAllyTwoAlive.ToString();
                string strGotRedKey = stValues.blnRedMacheteGet.ToString();
                string strIsRedDoorOpen = stValues.blnRedDoorOpen.ToString();
                string strGotBlueKey = stValues.blnBlueLodestoneGet.ToString();
                string strsIsBlueDoorOpen = stValues.blnBlueDoorOpen.ToString();
                //ameks the file
                saveGame = File.CreateText(sfdSave.FileName);
                //saveGame.WriteLine(roomNow);
                //writes the line to the file
                saveGame.WriteLine(stValues.myCharacter.strName);
                saveGame.WriteLine(strMainHealth);
                saveGame.WriteLine(strMainAttk);
                saveGame.WriteLine(strMainSpell);
                saveGame.WriteLine(strMainGender);
                saveGame.WriteLine(stValues.allyOne.strName);
                saveGame.WriteLine(strAllyOneHealth);
                saveGame.WriteLine(strAlly1Alive);
                saveGame.WriteLine(stValues.allyTwo.strName);
                saveGame.WriteLine(strAllyTwoHealth);
                saveGame.WriteLine(strAlly2Alive);
                saveGame.WriteLine(strGotRedKey);
                saveGame.WriteLine(strIsRedDoorOpen);
                saveGame.WriteLine(strGotBlueKey);
                saveGame.WriteLine(strsIsBlueDoorOpen);
                saveGame.WriteLine(stValues.strCurrentRoom);
                saveGame.Close();
            }
            //error happen
            catch
            {
                //dispaly a message
                MessageBox.Show("The system was unable to save your file at this time.");
            }
        }
        //loads a file
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFile("");
        }

        //shows the form
        private void frmConsole_Shown(object sender, EventArgs e)
        {
            //amkes copy of play info
            frmplayerInfo fPlayerInfo = new frmplayerInfo();
            //amkes copy of message form
            frmMessages fMessages = new frmMessages();

            //set there names and gender
            stValues.splyJungleTheme.PlayLooping();
            stValues.myCharacter.strName = _strMyText;
            stValues.allyOne.strName = _strAllyOneName;
            stValues.allyTwo.strName = _strAllyTwoName;

            //old game
            if (_strLoad != "")
            {
                //loads the game
                loadFile(_strLoad);
            }
            // new game
            else
            {
                //set threre names
                lblYourName.Text = _strMyText;
                lblNameAllyOne.Text = _strAllyOneName;
                lblNameAllyTwo.Text = _strAllyTwoName;

                //palces where they should be
                _strLoad = loadRoom(_strLoad);

                //if the user is a femlae
                if (_blnGender == true)
                {
                    //same for male
                    //sets that value for the main chacter
                    stValues.myCharacter.blnGender = _blnGender;
                    //dipslay that item
                    picGender.Image = Image.FromFile("Sfemale.png");
                }
                //main chacter is male
                else
                {
                    stValues.myCharacter.blnGender = _blnGender;
                    picGender.Image = Image.FromFile("Smale.png");
                }

                //selects what should be ispaly
                fMessages.blnRiddle = true;
                //what that text shoud be
                fMessages.strMessage = "You have decided to take on this mission with " + stValues.allyOne.strName + " and " + stValues.allyTwo.strName + "." + "You and your team have been dropped off 20km south of Stexom, the capital city of the metal nation to arrest the Consul in the name of the Council of Nations." + " Princess Miranda of Drensbery sends you a communication!" + "Princess Miranda: " + stValues.myCharacter.strName + ", we've tracked the Consul to an underground fortress in this location. He is being protected by a host of odd minions. As long as he is taking orders from Vorgon, then Vorgon will remain a threat to the world, so this mission is imperative. Once the Consul is removed from power, Vorgon will have to come out of hiding to continue giving orders to his henchmen. The Consul himself, although not dangerous by himself, is very eccentric and has an odd propensity for puzzles and riddles. Reaching him will require a bit more cleverness than what can be offered through pure brute force. Good luck to you!";

                //shows the form
                fMessages.ShowDialog();
            }
        }

        //abuot the porject
        private void aboutThisProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //makes an copy about form
            frmAbout fAbout = new frmAbout();
            //shows the about form
            fAbout.ShowDialog();
        }
        //disaply whta the user shouuld do
        private void AddMoveLbx(string strMessage)
        {
            //add that item to listbox
            lbxBattle.Items.Add(strMessage);
            //adds a garbage item
            lbxBattle.Items.Add("dfdfdfd");
            //selects the garbage item
            lbxBattle.SelectedIndex = lbxBattle.Items.Count -1;
            //remove that item
            lbxBattle.Items.RemoveAt(lbxBattle.Items.Count - 1);
        }
        //places the partry
        private string loadRoom(string strValue)
        {
            //saves there room number
            int intCnt = 0;

            //if its a new game
            if (strValue == "")
            {
                //game begins in 1st room
                moveToRoom(0);
            }
            //not a new game
            else
            {
                //alks the the list of rooms
                for (int lcv = 0; lcv < stValues.aryStrRoom.Length; lcv++)
                {
                    //finds where the patryt is
                    if (strValue == stValues.aryStrRoom[lcv])
                    {
                        //sets that loaction
                        intCnt = lcv;
                        //stops the loop
                        break;
                    }
                }
                //moves the partyy
                moveToRoom(intCnt);
                //change value given back to nothing
                strValue = "";
            }
            //get back the valus is
            return strValue;
        }
        //loads the file
        private void loadFile (string strFile)
        {
            //see if everthing works
            try
            {
                //reads the file
                StreamReader inputStuff;
                //where the file is open form
                if (strFile == "")
                {
                    //user open file dialog form conosle fomr
                    ofdOpen.ShowDialog();
                    //opoens the file
                    inputStuff = File.OpenText(ofdOpen.FileName);
                }
                //user opens the file on in welocome screen
                else
                {
                    //opens that file
                    inputStuff = File.OpenText(strFile);
                }

                //reads in the values
                stValues.myCharacter.strName = inputStuff.ReadLine();
                stValues.myCharacter.intHealth = int.Parse(inputStuff.ReadLine());
                stValues.myCharacter.intAttack = int.Parse(inputStuff.ReadLine());
                stValues.myCharacter.intSpellPoints = int.Parse(inputStuff.ReadLine());
                stValues.myCharacter.blnGender = bool.Parse(inputStuff.ReadLine());
                stValues.allyOne.strName = inputStuff.ReadLine();
                stValues.allyOne.intHealth = int.Parse(inputStuff.ReadLine());
                stValues.blnAllyOneAlive = bool.Parse(inputStuff.ReadLine());
                stValues.allyTwo.strName = inputStuff.ReadLine();
                stValues.allyTwo.intHealth = int.Parse(inputStuff.ReadLine());
                stValues.blnAllyTwoAlive = bool.Parse(inputStuff.ReadLine());
                stValues.blnRedMacheteGet = bool.Parse(inputStuff.ReadLine());
                stValues.blnRedDoorOpen = bool.Parse(inputStuff.ReadLine());
                stValues.blnBlueLodestoneGet = bool.Parse(inputStuff.ReadLine());
                stValues.blnBlueDoorOpen = bool.Parse(inputStuff.ReadLine());
                //where the patryt is
                _strLoad = inputStuff.ReadLine();
                //close the file
                inputStuff.Close();
            }

            //something happend
            catch
            {
                //dispply a  message
                MessageBox.Show("The system is unable to load your game at this time.");
            }

            //sets the labels text
            //and other items values
            lblYourName.Text = stValues.myCharacter.strName;
            pbarHealthYours.Value = stValues.myCharacter.intHealth;
            lblNameAllyOne.Text = stValues.allyOne.strName;
            pbarHealthAllyOne.Value = stValues.allyOne.intHealth;
            lblNameAllyTwo.Text = stValues.allyTwo.strName;
            pbarHealthAllyTwo.Value = stValues.allyTwo.intHealth;
            _strLoad = loadRoom(_strLoad);

            //what gender the main charcets is
            if(stValues.myCharacter.blnGender == true)
            {
                //show that image
                picGender.Image = Image.FromFile("Sfemale.png");
            }
            //user is a male
            else
            {
                //show that image
                picGender.Image = Image.FromFile("Smale.png");
            }
        }

        //user start a new game
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //makes an copy of weleomc scren
            frmWelcomeScreen wScreen = new frmWelcomeScreen();

            //shows the weleomce scren
            wScreen.Show();

            //closs the thsi form
            this.Close();
        }

        //user click the item label
        //same for the others
        private void lblItem1_Click(object sender, EventArgs e)
        {
            //sets what they have click
            stValues.strItemInteract = "Item 1";
        }

        private void lblItem2_Click(object sender, EventArgs e)
        {
            stValues.strItemInteract = "Item 2";
        }

        private void lblItem4_Click(object sender, EventArgs e)
        {
            stValues.strItemInteract = "Item 4";
        }

        private void lblItem3_Click(object sender, EventArgs e)
        {
            stValues.strItemInteract = "Item 3";
        }

        //updats the textbox for combox
        private void cmbItems_TextChanged(object sender, EventArgs e)
        {
            //sets the text for textbox
            txtItems.Text = cmbItems.Text;
        }

        //samme for others
        //user pick that chacter
        private void lblYourName_Click(object sender, EventArgs e)
        {
            //sets that text to what person they selected 
            stValues.strPerson = lblYourName.Text;
        }

        private void lblNameAllyOne_Click(object sender, EventArgs e)
        {
            stValues.strPerson = lblNameAllyOne.Text;
        }

        private void lblNameAllyTwo_Click(object sender, EventArgs e)
        {
            stValues.strPerson = lblNameAllyTwo.Text;
        }
    }
}
