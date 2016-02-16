using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    public class SystemStatus
    {
        double _odometer;
        double _milesNextOilChange;
        bool _US;
        bool _isItOdometer;
        

// constructors start here

        //base with one parameters
        public SystemStatus(bool isItUS)
        {
            _odometer = 0;
            _milesNextOilChange = 0;
            _US = isItUS;
        }

        //two parameter constructor	
        public SystemStatus(double odometer, double milesNextOilChange, bool isItUS)
        {
            _odometer = odometer;
            _milesNextOilChange = milesNextOilChange;
            _US = isItUS;
        }

        /// <summary>
        /// gets the latest odometer set
        /// </summary>
        public double Odometer
        {
            get { return _odometer; }
        }

        /// <summary>
        /// gets the number until the next oil change
        /// </summary>
        public double Miles
        {
            get { return _milesNextOilChange;  }
        }
       
        //checks if the current state is odometer or not 
        public bool isItOdometer
        {
            get { return _isItOdometer; }
            set { _isItOdometer = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double UnitConverter()
        {
            double nuNumber = 0;
            if(_US == false)
            {//convert to metric
                nuNumber = _odometer * 1.6;
            }
            else
            {
                //convert to us
                nuNumber = _odometer;
            }

            return nuNumber;
        }

        /// <summary>
        /// Displays the Current object
        /// </summary>
        /// <returns>the type of the current object</returns>
        public override string ToString()
        {
            return "System Status";
        }


    }
}
