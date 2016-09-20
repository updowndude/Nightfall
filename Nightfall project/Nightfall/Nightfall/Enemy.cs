using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightfall
{
    //class to create enemies for the player to fight
    class Enemy
    {
        //creates variables for enemy name, health points, attack power, element
        private String _strEnemyName;
        private int _intEnemyHealthPoints;
        private int _intEnemyAttackPow;
        private String _strEnemyElement;

        //a constructor for an Enemy that takes four arguments
        public Enemy(String _strEnemyName, int _intEnemyHealthPoints, int _intEnemyAttackPow, String _strEnemyElement)
        {
            strName = _strEnemyName;
            intHealth = _intEnemyHealthPoints;
            intAttack = _intEnemyAttackPow;
            strElement = _strEnemyElement;
        }

        //getter and setter for the Name property
        public String strName
        {
            get { return _strEnemyName; }
            set { _strEnemyName = value; }
        }

        //getter and setter for the Health property
        public int intHealth
        {
            get {return _intEnemyHealthPoints; }
            set { _intEnemyHealthPoints = value; }
        }

        //getter and setter for the Attack property
        public int intAttack
        {
            get { return _intEnemyAttackPow; }
            set { _intEnemyAttackPow = value; }
        }

        //getter and setter for the Element property
        public String strElement
        {
            get { return _strEnemyElement; }
            set { _strEnemyElement = value; }
        }

        //allows creation of enemies with set initial values
        public void initEnemy(int val)
        {    
            if(val == 0)
            {
                //makes an enemy
                //same for the others
                helper("Angry Monkey",100,25, "Plant");
            }

            if(val == 1)
            {
                helper("Cheeky Chipmunk", 30, 10, "Plant");
            }

            if (val == 2)
            {
                helper("Scolding Squirrel", 14, 5, "Plant");
            }

            if (val == 3)
            {
                helper("Bitey Badger", 45, 45, "Plant");
            }

            if (val == 4)
            {
                helper("Gnarly Gnu", 80, 45, "Plant");
            }

            if(val == 5)
            {
                helper("Unxious Unicorn", 1000, 50, "Ice");
            }

            if(val == 6)
            {
                helper("Giant Spitting Spider", 50, 25, "Poison");
            }

            if(val == 7)
            {
                helper("Spitting Spider", 20, 10, "Poison");
            }
        }
        private void helper (string strName,int intHp,int intAp,string strElement)
        {
            //set an enemy name,health,attack, and there element
            _strEnemyName = strName;
            _intEnemyHealthPoints = intHp;
            _intEnemyAttackPow = intAp;
            _strEnemyElement = strElement;
        }
    }
}
