using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    public class PersonalSettings
    {
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
        public bool ChangeUS
            {
            get
            {
                return _US;
            }
            set
            {
                _US = value;
            }
            
        }
        /// <summary>
        /// Get/Set for Metrics
        /// </summary>
        public bool ChangeMetric
        {
            get
            { return _metric; }
            set
            { _metric = value; }

        }










    }
}
