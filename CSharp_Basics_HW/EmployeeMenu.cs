using CSharp_Basics_HW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_HW
{
    internal class EmployeeMenu
    {
        TaskMenu taskMenu

        public EmployeeMenu()
        {
            ShowMainMenu();
        }

        public void ShowMainMenu()
        {
            int pressedKey;
            ConsoleKeyInfo keyInfo;

          

            string inputValue = Console.ReadLine();
            bool parsed = int.TryParse(inputValue, out pressedKey);


            do
            {
                WriteMenuOnConsole();
            }
            while (!parsed);


            switch (pressedKey)
            {
                case (1):
                {
                    Console.WriteLine();
                    break;
                }
                case (2):
                {
                    
                    break;
                }
            }


        }

        private void WriteMenuOnConsole()
        {
            Console.Clear();

            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Show Employees");
            Console.WriteLine("3. Choose Employee");
            Console.WriteLine("4. Modify Employee");
            Console.WriteLine("5. Back to Main Menu");
            Console.WriteLine("6. Exit");
            
        }

        public void ShowSubMenu()
        {

        }


        private void AddEmployee()
        {
            Employee newEmployee = new();
            Console.WriteLine("Name: ");
            newEmployee.Name = Console.ReadLine();
            Console.Write("Surename: ");
            newEmployee.Surname = Console.ReadLine();
            Console.WriteLine("Nickname: ");
            newEmployee.Nickname = Console.ReadLine();
            Console.WriteLine("Want ot add a task? y/n: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            
            switch (keyInfo.Key)
            {
                case ConsoleKey.N:
                    {
                        //return to main Menu;
                        break;
                    }
                case ConsoleKey.Y:
                    {

                        break;
                    }
                default:
                    break;

            }

        }
    }
}
