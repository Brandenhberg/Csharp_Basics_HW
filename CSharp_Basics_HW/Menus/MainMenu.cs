using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_HW.Menus
{
    internal class MainMenu
    {
        TaskMenu taskMenu;
        EmployeeMenu employeeMenu;

        public MainMenu()
        {
            taskMenu = new(this);
            //employeeMenu = new(this);
        }


        public void MainMenuhandler()
        {
            bool isParsed = false;
            string optionValue = "";
            int optionValuetoInt = 0;

            do
            {
                optionValue = MenuWriter();
                isParsed = int.TryParse(optionValue, out optionValuetoInt);

            } while (isParsed == false || optionValuetoInt < 1 || optionValuetoInt > 3);


            switch (optionValuetoInt)
            {
                case 1:
                    Console.WriteLine("131");
                    //employeeMenu.EmployeeMenuHandler();
                    break;
                case 2:
                    Console.WriteLine("131");
                    //taskMenu.WriteTaskMainMenu();
                    break;
                case 3:
                    {
                        Console.WriteLine("Application Exit...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    break;
                default:
                    break;
            }

        }

        private string MenuWriter()
        {
            Console.Clear();
            Console.WriteLine("1. Add Employee.");
            Console.WriteLine("2. Create Employee.");
            Console.WriteLine("3. Exit.");
            Console.Write("Type Here: ");

            string selectedOption = Console.ReadLine();
            Console.WriteLine();



            return selectedOption;
        }

    }
}
