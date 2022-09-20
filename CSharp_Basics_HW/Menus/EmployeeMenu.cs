using CSharp_Basics_HW.Models;

namespace CSharp_Basics_HW.Menus
{
    internal class EmployeeMenu
    {
        TaskMenu taskMenu;

        public EmployeeMenu(TaskMenu taskMenu)
        {
            this.taskMenu = taskMenu;

            EmployeeMenuHandler();
        }

        private void EmployeeMenuHandler()
        {
            WriteMenuOnConsole();

            ConsoleKeyInfo key = Console.ReadKey(true);

            bool flag = false;

            do
            {

            } while (!flag);


            bool val = key.Key switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => AddEmployee(),
                ConsoleKey.D2 or ConsoleKey.NumPad2 => AddEmployee(),
                ConsoleKey.D3 or ConsoleKey.NumPad3 => AddEmployee(),
                ConsoleKey.D4 or ConsoleKey.NumPad4 => AddEmployee(),
                ConsoleKey.D5 or ConsoleKey.NumPad5 => AddEmployee(),
                _ => false

            };
            


            string inputValue = Console.ReadLine();
            //bool parsed = int.TryParse(inputValue, out pressedKey);

        }

        public void WriteMenuOnConsole()
        {
            Console.Clear();

            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Show Employees");
            Console.WriteLine("3. Choose Employee");
            Console.WriteLine("4. Modify Employee");
            Console.WriteLine("5. Back to Main Menu");
            Console.WriteLine("6. Exit");
        }

        private void WriteSubMenu()
        {

        }

        private bool AddEmployee()
        {
            bool flag = false;



            Employee newEmployee = new();
            Console.WriteLine("Name: ");
            newEmployee.Name = Console.ReadLine();
            Console.Write("Surename: ");
            newEmployee.Surname = Console.ReadLine();
            Console.WriteLine("Nickname: ");
            newEmployee.Nickname = Console.ReadLine();
            Console.WriteLine("Want to add a task? y/n: ");
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



            //EmployeesMockDatabase.Employees.Add()
            return flag;
        }
    }
}
