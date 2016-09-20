using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightfall
{
    //a class that is derived from the Ally class that will hold additional values specific to the main character
    class Player_Char : Ally
    {
        //variables to hold the main characters spell points and gender
        private int _intSpellPoints;
        private bool _blnGender;

        //a constructor for a player character that takes the properties of the Ally class and adds its own 
        public Player_Char(String _allyName, int _allyHealth, int _allyAttackPow, int _intSpellPoints, bool _blnGender) : base(_allyName, _allyHealth, _allyAttackPow)
        {
            intSpellPoints = _intSpellPoints;
            blnGender = _blnGender;
        }

        //getter and setter for spell points
        public int intSpellPoints
        {
            get { return _intSpellPoints; }
            set { _intSpellPoints = value; }
        }

        //getter and setter for player gender
        public bool  blnGender
        {
            get { return _blnGender; }
            set { _blnGender = value; }
        }
    }
}
