using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_HW.Menus
{
    internal class TaskMenu
    {
        public TaskMenu()
        {

        }


        public void WriteTaskMainMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Create Task.");
            Console.WriteLine("2. Find task by ID.");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Your choise: ");
            ConsoleKeyInfo key = Console.ReadKey(true);

            ProcessRequest(key);

            return key;
        }


        private void ProcessRequest(ConsoleKeyInfo key)
        {
            key.Key switch
            {
                ConsoleKey.D1, ConsoleKey.NumPad1 => TaskMockDatabase.
                Co
            }
        }
    }
}
