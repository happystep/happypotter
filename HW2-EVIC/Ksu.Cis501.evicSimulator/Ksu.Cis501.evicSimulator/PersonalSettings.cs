using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    public class PersonalSettings
    {
        //This class will check the current settings (us or metric) and change it to the other one IF theuser presses the space bar
        /// <summary>
        /// saves the default current setting 
        /// False: Metric
        /// True: Imperial
        /// </summary>
        bool _currentSet = false;

        bool _US;
        bool _metric;
        

        // no parameter constructor
        public PersonalSettings()
        {
            _US = false;
            _metric = false; 
        }

        /// <summary>
        /// Get/Set for US
        /// </summary>
        public bool ChangeToUS
            {
            get { return _US; }
            set { _US = value; }
            
        }

        /// <summary>
        /// Get/Set for Metrics
        /// </summary>
        public bool ChangeToMetric
        {
            get { return _metric; }
            set { _metric = value; }

        }

        /// <summary>
        /// returns the current setting
        /// </summary>
        public string CurrentSetting
        {
            get
            {
                if(_currentSet == true)
                {
                    return "Imperial ";
                }
                else
                {
                    return "Metric";
                }
            }
        }

        public double Change(double odometer)
        {
            double num = 0;
            if(_currentSet == true)
            {//its in imperial and gotta change it to metric
                num = odometer * 1.6;
            }
            else // its in metrics andgotta change to imperial
            {
                num = odometer / 1.6;
            }
            return num;
        }



        /// <summary>
        /// Displays the Current object
        /// </summary>
        /// <returns>the type of the current object</returns>
        public override string ToString()
        {
            return "Personal Settings";
        }
    }
}
