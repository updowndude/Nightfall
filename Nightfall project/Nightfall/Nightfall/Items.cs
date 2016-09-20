using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightfall
{
    class Items
    {
        //value of the items effect
        int _intValue = 0;
        // name of the item
        string _strName = "";

        //get the value of effect of item for other class
        public int intValue
        {
            //get back value of effect
            get { return _intValue; }
        }

        //get the value of effect of item for other class
        public string strName
        {
            //get back the name
            get { return _strName; }
        }

        //makes an item
        public Items (int intRestore, string strItemName)
        {
            //set its effect value
            _intValue = intRestore;
            //set its name
            _strName = strItemName;
        }
    }
}
