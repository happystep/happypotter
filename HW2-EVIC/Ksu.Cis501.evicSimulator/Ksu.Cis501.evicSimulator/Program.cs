using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    public class Program
    {
        /// <summary>
        /// list of main menu options that help the program keep track of where the program is at
        /// </summary>
        private static string[] options = { "System Status", "Warning Messages", "Personal Settings", "Temperature Information", "Trip Information" };
        
        /// <summary>
        /// Keeps track of where the user is at
        /// </summary>
        private static int index = 0;

        /// <summary>
        /// 
        /// </summary>
        private static bool _Simulator = false;

        private static Status status = new Status();
        private static Temperature temp = new Temperature();
        private static Trip trip = new Trip();
        private static Warning warning = new Warning();
        private static Menu personalSettings = new Menu();

        private static Random r = new Random();

        

        public static void Main(string[] args)
        {
            Console.WriteLine("Which mode would you like to enter?");
            Console.WriteLine("1) Simulation");
            Console.WriteLine("2) Regular Run");

            try
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                if ( answer == 1)
                {
                    _Simulator = true;
                }
                else if (answer == 2)
                {
                    _Simulator = false;
                    while (true)
                    {
                        MainMenu();
                    }//big looooooooooooooooooop!!
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           

        }
        
        public static void MainMenu()
        {
            ConsoleKeyInfo keypress = Console.ReadKey();
            
            switch (keypress.Key)
            {
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    MoveRight();    
                    break;
                case ConsoleKey.UpArrow:
                    MoveUpDown();
                    break;
                case ConsoleKey.DownArrow:
                    MoveUpDown();
                    break;
                case ConsoleKey.Spacebar:
                    BarSpace();
                    break;
                default:
                    break;
            }

        }//end mainmenu
        
        public static void BarSpace()
        {
            switch(index)
            {
                case 0://change oil to 3000 miles
                    status.Reset();
                    break;
                case 1://empty
                    break;
                case 2: //personal settings
                    personalSettings.toggle();
                    break;
                case 3://empty
                    break;
                case 4://reset the trip to 0
                    trip.Reset();
                    break;
            }
                
        }

        /// <summary>
        /// Moves nad displays the main menu to the option indicated down 
        /// </summary>
        public static void MoveUpDown()
        {
           
            switch (index)
            {
                case 0:
                    //system status
                    status.toggle();
                    status.display(r.Next(1, 100000), r.Next(1, 3000));
                    break;
                case 1:
                    //warning messages
                    warning.toggle(false, true, false);
                    warning.display();
                    break;
                case 2:
                    personalSettings.display();
                    break;
                case 3:
                    temp.toggle();
                    temp.display(r.Next(20,112), r.Next(32, 112));
                    break;
                case 4:
                    trip.toggle();
                    trip.display(r.Next(1, 20000), r.Next(1, 5000));
                    break;
                default:
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
        }
    }
}
