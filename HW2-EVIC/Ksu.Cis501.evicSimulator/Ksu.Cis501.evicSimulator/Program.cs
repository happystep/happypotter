using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis501.evicSimulator
{
    class Program
    {
        private static string[] options = { "System Status", "Warning Messages", "Personal Settings", "Temperature Info", "Trip Info" };

        private static int index = 0;

        public static void Main(string[] args)
        {
            MainMenu();

        }

        public static void MainMenu()
        {
            ConsoleKeyInfo keypress = Console.ReadKey();

            Console.WriteLine(options[index]);
            
            switch (keypress.Key)
            {
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    MoveRight();    
                    break;
                case ConsoleKey.Spacebar:
                    break;
                default:
                    break;
            }

        }//end mainmenu

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
