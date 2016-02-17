using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    public class Menu
    {
        public static bool _isMetric = false;
        public static bool _isToggled = false; //toggled means metric system on

        public Menu()
        {

        }

        public virtual void toggle()
        {
            if (_isMetric == false)
            {
                _isMetric = true;
                _isToggled = true;
            }
            else if (_isMetric == true)
            {
                _isMetric = false;
                _isToggled = false;
            } 
        }

        public virtual void display()
        {
            Console.Clear();
            Console.WriteLine("Personal Settings");

            if (_isMetric == false)
            {
                Console.WriteLine("US Units");
            }
            else if (_isMetric == true)
            {
                Console.WriteLine("Metric Units");
            }


        }
        public  override string ToString()
        {
            return "Personal Settings";
        }

        public static double ConvertToKM(double mi)
        {
            return mi * 1.609344;
        }

        public static double ConvertToMI(double km)
        {
            return km / 1.609344;
        }

    }//end class menu

    public class Status : Menu
    {

        double _odometer = 0;
        double _oilChange = 0;
        bool _isOdometer = false;

        public double Oil
        {
            get { return _oilChange; }
        }

        public override void toggle()
        {

            if (_isOdometer == false)
            {
                _isOdometer = true;
            }
            else if (_isOdometer == true)
            {
                _isOdometer = false;
            }
          
        }
        public void display(int randomOdometer, int randomOilChange)
        {
            Console.Clear();
            Console.WriteLine("System Status");

            _odometer = randomOdometer;
            _oilChange = randomOilChange;

            if (_isMetric == false && _isOdometer == true)
            {
                Console.WriteLine(_odometer.ToString() + " mi");
            }

            else if (_isMetric == true && _isOdometer == true)
            {
                _odometer = Menu.ConvertToKM(_odometer);

                Console.WriteLine(_odometer.ToString() + " km");

            }

            //settings for oil change
            if (_isMetric == false && _isOdometer == false)
            {
                Console.WriteLine("Next oil change in " + _oilChange.ToString() + " mi");
            }
            else if (_isMetric == true && _isOdometer == false)
            {
                _odometer = Menu.ConvertToKM(_odometer);
                Console.WriteLine("Next oil change in " + _oilChange.ToString()+ " km");
            }
            else if (_isMetric == false && _isOdometer == true && _isToggled == true)
            {
                _odometer = Menu.ConvertToMI(_odometer);
                Console.WriteLine(_odometer.ToString() + " mi");
            }

        }

        public void Reset()
        {
            Console.Clear();
            Console.WriteLine("System Status");

            if (_isMetric == true)
            {
                Console.WriteLine("Next oil change in 4828.032 km");
            }
            else
            {
                Console.WriteLine("Next oil change in 3000 mi");
            }
        }
    }

    public class Temperature : Menu
    {
        double _insideTemperature;
        double _outsideTemperature;
        bool _isInside = false;

        public override void toggle()
        {
           if (_isInside == false)
            {
                _isInside = true;
            }
           else if (_isInside == true)
            {
                _isInside = false;
            }
        }

        public void display(int insideTemp, int outsideTemp)
        {
            Console.Clear();
            Console.WriteLine("Temperature Information");

            _outsideTemperature = outsideTemp;
            _insideTemperature = insideTemp;
            //inside variations
            if (_isInside == true && _isMetric == false)
            {
                Console.WriteLine(_insideTemperature + "°F Inside");
            }
            else if (_isInside == true && _isMetric == true)
            {
                _insideTemperature = ConvertToCelsius(_insideTemperature);
                    //(((_insideTemperature * 9) / 5) + 32);
                Console.WriteLine(_insideTemperature + "°C Inside");
            }
            //ouside variations
            else if (_isInside == false && _isMetric == false)
            {
                Console.WriteLine(_outsideTemperature + "°F Outside");
            }
            else if (_isInside == false && _isMetric == true)
            {
                
                _outsideTemperature = ConvertToCelsius(_outsideTemperature);
                //(((_outsideTemperature * 9) / 5) + 32);
                Console.WriteLine(_outsideTemperature + "°C Outside");
            }


        }

        /// <summary>
        /// converts parameter (farhernheit to celsius)
        /// </summary>
        /// <param name="f">farenheit number</param>
        /// <returns>new number in celsius units</returns>
        public double ConvertToCelsius(double f)
        {
            double c = (5.0 / 9.0) * (f-32);
            return c;
        }

        /// <summary>
        /// Converts parameter to farhenheit
        /// </summary>
        /// <param name="c">celsius number</param>
        /// <returns>resulting farhenheit number</returns>
        public double ConvertToFarhenheit(double c)
        {
            double f = ((c * 9)/5) + 32;
            return f;
        }

    } 

    public class Trip : Menu
    {
        bool _isTripA = false;

        public override void toggle()
        {
            if(_isTripA == false)
            {
                _isTripA = true;
            }
            else if (_isTripA == true)
            {
                _isTripA = false;
            }            
        }

        double _tripA = 0;
        double _tripB = 0;

        public void display(int tripA, int tripB)
        {
            Console.Clear();
            Console.WriteLine("Trip Information");

            _tripA = tripA;
            _tripB = tripB;
            //initial print
            if (_isTripA == true && _isMetric == false )
            {
                Console.WriteLine("Trip-A: " + _tripA);
            }
            else if (_isTripA == false && _isMetric == true)
            {
                _tripB = Menu.ConvertToKM(_tripB);
                Console.WriteLine("Trip-B: " + _tripB);
            }
            else if (_isTripA == true && _isMetric == true)
            {
                _tripA = Menu.ConvertToKM(_tripA);
                Console.WriteLine("Trip-A: " + _tripA);
            }
            else if (_isTripA == false && _isMetric == false)
            {
                Console.WriteLine("Trip-B: " + _tripB);
            }
            else if (_isTripA == true && _isMetric == false && _isToggled == false)
            {
                _tripA = Menu.ConvertToMI(_tripA);
                Console.WriteLine("Trip-A: " + _tripA);
            }

        } 

        public void Reset()
        {
            Console.Clear();
            Console.WriteLine("Trip Information");
            if (_isTripA == true)
            {
                _tripA = 0;

            }
            else
            {
                _tripB = 0;
            }
        }//do we want to display after resetting
    }

    public class Warning : Menu
    {
        bool _doorAjar = false;
        bool _CheckEngine = false;
        bool _oilChange = false;
            
        public void toggle(bool a, bool b, bool c)
        { 
            //door settings
            if (_doorAjar == false  && a == true)
            {
                _doorAjar = true;
            }
            else if (_doorAjar == true && a == true)
            {
                _doorAjar = false;
            }
            //enginee settings
            else if (_CheckEngine == false && b == true)
            {
                _CheckEngine = true;
            }
            else if (_CheckEngine == true && b == true)
            {
                _CheckEngine = false;
            }
            // oil settings
            else if (_oilChange == false && c == true)
            {
                _oilChange = true;
            }
            else if (_oilChange == true && c == true)
            {
                _oilChange = false;
            } 
        }

        

        public override void display()
        {
            Console.Clear();
            Console.WriteLine("Warning Messages");
           if (_doorAjar == true)
            {
                Console.WriteLine("Door Ajar!");
            }
           else if (_CheckEngine == true)
            {
                Console.WriteLine("Check Engine Soon!");

            }
           else if (_oilChange == true)
            {
                Console.WriteLine("Oil Change!");
            }

        }
       
       

    }
    


}
