﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    public class Program
    {
        private static string[] options = { "System Status", "Warning Messages", "Personal Settings", "Temperature Info", "Trip Info" };

        private static int index = 0;

        private static object[] _MainMenu = new Object[5];

        private static int _loopStopCondition = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Which mode would you like to enter?");
            Console.WriteLine("1) Simulation");
            Console.WriteLine("2) Regular Run");

            



            while (_loopStopCondition != -1)
            {
                Console.WriteLine("hello");
                //_MainMenu[0] = new SystemStatus(false);
                //_MainMenu[1] = new WarningMessages();
                //_MainMenu[2] = new PersonalSettings();
                //_MainMenu[3] = new TemperatureInfo();
                //_MainMenu[4] = new TripInfo();

               // MainMenu();

                //Console.WriteLine("Enter -1 to exit program");
                //_loopStopCondition = Convert.ToInt32(Console.ReadLine());
                //Console.Clear();

            }//big looooooooooooooooooop!!

        }
        /*
        public static void MainMenu()
        {
            ConsoleKeyInfo keypress = Console.ReadKey();

            Console.WriteLine(_MainMenu[index]);
            
            switch (keypress.Key)
            {
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    MoveRight();    
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.Spacebar:
                    break;
                default:
                    break;
            }

        }//end mainmenu
        
        /// <summary>
        /// Moves and displays the main menu to the option indicated up
        /// </summary>
        public static void MoveUp()
        {
            switch(index)
            {
                case 0:
                    //system status

                    break;
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }




        }

        /// <summary>
        /// Moves nad displays the main menu to the option indicated down 
        /// </summary>
        public static void MoveDown()
        {
            SystemStatus ss = new SystemStatus(false);
            WarningMessages wm = new WarningMessages();
            PersonalSettings ps = new PersonalSettings();
            switch (index)
            {
                case 0:
                    //system status
                    _MainMenu[0] = ss;
                    if (ss.isItOdometer == true)
                    {
                        Console.WriteLine("Odometer is at " + _MainMenu[index].ToString());
                    }
                    else
                    {//display miles until next oil change
                        Console.WriteLine(ss.Miles + " until next oil change");
                    }
                    break;
                case 1:
                    
                    //warning messages
                    double miles = ss.Odometer;
                    wm.DisplayMessages(miles);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }



        /// <summary>
        /// Moves and displays the main menu to the option to the left
        /// </summary>
        public static void MoveLeft()
        {
            Console.Clear();
            if (index == 0)
            {
                index = 4;
                Console.WriteLine(options[index]);
            }
            else
            {
                index--;
                Console.WriteLine(options[index]);
            }
        }//end moveleft

        /// <summary>
        /// Moves and displays the main menu to the option to the right
        /// </summary>
        public static void MoveRight()
        {
            Console.Clear();
            if (index == 4)
            {
                index = 0;
                Console.WriteLine(options[index]);
            }
            else
            {
                index++;
                Console.WriteLine(options[index]);
            }
        }*/
    }
}
