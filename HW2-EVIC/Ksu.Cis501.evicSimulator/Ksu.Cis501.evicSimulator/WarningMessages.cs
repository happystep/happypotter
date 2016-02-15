using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
  public  class WarningMessages
    {
        bool _ajar;
        bool _checkEngine;
        bool _oilChange;

        //no parameter constructor
        public WarningMessages ()
        {
             _ajar = false;
            _checkEngine = false;
            _oilChange = false;
        }

        // three parameter constructor
        public WarningMessages(bool ajar, bool checkEngine, bool oilChange)
        {
            _ajar = ajar;
            _checkEngine = checkEngine;
            _oilChange = oilChange;
        }

        public void DisplayMessages(double miles)
        {
            if (_ajar == true)
            {
                Console.WriteLine("Door Ajar!");

            }
            if (_checkEngine == true)
            {
                Console.WriteLine("Check Engine!");

            }
            if (_oilChange == true)
            {
                Console.WriteLine("Oil Change in " + miles);
            }
        }




    }
}
