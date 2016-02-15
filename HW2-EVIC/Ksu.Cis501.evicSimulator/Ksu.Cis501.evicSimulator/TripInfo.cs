using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    public class TripInfo
    {
        double _tripA;
        double _tripB;

        //no paramter contructor
        public TripInfo()
        {
            _tripA = 0;
            _tripB = 0;

        }

        //two parameter constructor
        public TripInfo(double tripA, double tripB)
        {
            _tripA = tripA;
            _tripB = tripB;
        }

        /// <summary>
        /// This Method Resets Trip A value to 0
        /// </summary>
        public void ResetTripA()
        {
            _tripA = 0;
        }

        /// <summary>
        /// THis Method Resets Trip B value to 0
        /// </summary>
        public void ResetTripB()
        {
            _tripB = 0;
        }
        






    }
}
