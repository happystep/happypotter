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

       public virtual void toggle()
        {
            if (_isMetric == false)
            {
                _isMetric = true;
            }
            else if (_isMetric == true)
            {
                _isMetric = false;
            } 
        }

        public virtual void display()
        {
            


        }


    }

    public class Status : Menu
    {

        double _odometer = 0;
        double _oilChange = 0;
        bool _isOdometer = false;

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
        public override void display()
        {
            //settings for odometer
            if (_isMetric == false && _isOdometer == true)
            {
                Console.WriteLine(_odometer.ToString());
            }

            else if (_isMetric == true && _isOdometer == true)
            {
                _odometer = _odometer * 1.6;
                Console.WriteLine(_odometer.ToString());

            }
            //settings for oil change
           else if (_isMetric == false && _isOdometer == false)
            {
                Console.WriteLine(_odometer.ToString());
            }
            else if (_isMetric == true && _isOdometer == false)
            {
                _odometer = _odometer * 1.6;
                Console.WriteLine(_odometer.ToString());

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

        public override void display()
        {
            //inside variations
            if (_isInside == true && _isMetric == false)
            {

                Console.WriteLine(_insideTemperature + "F Inside");
            }
            else if (_isInside == true && _isMetric == true)
            {
                _insideTemperature = (((_insideTemperature * 9) / 5) + 32);
                Console.WriteLine(_insideTemperature + "C Inside");
            }
            //ouside variations
            else if (_isInside == false && _isMetric == false)
            {
                Console.WriteLine(_outsideTemperature + "F Outside");
            }
            else if (_isInside == false && _isMetric == true)
            {
                _outsideTemperature = (((_outsideTemperature * 9) / 5) + 32);
                Console.WriteLine(_outsideTemperature + "C Outside");
            }


        }



    } 

    public class Trip :Menu
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

        double _tripA;
        double _tripB;

       public override void display ()
        {
            if (_isTripA == true)
            {
                Console.WriteLine("Trip-A: " + _tripA);
            }
            else if (_isTripA == false)
            {
                Console.WriteLine("Trip-B: " + _tripB);
            }

        } 



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
           if (_doorAjar == true)
            {
                Console.WriteLine("Door Ajar!");
            }
           else if (_CheckEngine == true)
            {
                Console.WriteLine("Check Engine Soon!");

            }
           else if (_oilChange)
            {
                Console.WriteLine("Oil Change!");
            }

        }
       
       

    }
    


}
