using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    class TemperatureInfo
    {
        double _outsideTemperature;
        double _insideTemperature;

        // no parameter constructor
        public TemperatureInfo()
        {
            _outsideTemperature = 0;
            _insideTemperature = 0;

        }

        public TemperatureInfo(double outsideTemperature, double insideTemperature)
        {
            _outsideTemperature = outsideTemperature;
            _insideTemperature = insideTemperature;
        }

        /// <summary>
        /// This method returns a string for outside temprature message
        /// </summary>
        /// <returns>returns the strings</returns>
        public string OutsideTemperatureMessage()
        {
            return _outsideTemperature.ToString();
        }








    }
}
