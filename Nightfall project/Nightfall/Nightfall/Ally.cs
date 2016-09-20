using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightfall
{
    //a class to create ally characters for the player
    class Ally
    {
        //variables to hold ally name, health points, attack power
        private String _strAllyName;
        private int _intAllyHealth;
        private int _intAllyAttackPow;

        //constructor that takes three arguments
        public Ally(String _strAllyName, int _intAllyHealth, int _intAllyAttackPow)
        {
            strName = _strAllyName;
            intHealth = _intAllyHealth;
            intAttack = _intAllyAttackPow;
        }

        //getter and setter for Name property
        public String strName
        {
            get { return _strAllyName; }
            set { _strAllyName = value; }
        }

        //getter and setter for Health property
        public int intHealth
        {
            get { return _intAllyHealth; }
            set { _intAllyHealth = value; }
        }

        //getter and setter for attack property
        public int intAttack
        {
            get { return _intAllyAttackPow; }
            set { _intAllyAttackPow = value; }
        }

        //allows program to create allies with initial values
        public void initAlly(int intVal)
        {
            if (intVal == 1)
            {
                //makes an ally 
                //same for the others
                helper("Kestryl",120,35);
            }

            if (intVal == 2)
            {
                helper("Hammond", 75, 0);
            }

            if (intVal == 3)
            {
                helper("Illya", 100, 50);
            }

            if (intVal == 4)
            {
                helper("Gormis", 150, 25);
            }
        }
        private void helper (string strName,int intHp,int intAp)
        {
            //setups an ally name, health and, attack
            _strAllyName = strName;
            _intAllyHealth = intHp;
            _intAllyAttackPow = intAp;
        }
    }
}
