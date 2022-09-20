using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_HW.Menus
{
    internal class TaskMenu : Interfaces.IBack
    {
        private readonly MainMenu mainMenu;

        public TaskMenu(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
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
        }


        private void ProcessRequest(ConsoleKeyInfo key)
        {
            
        }


        private void CreateTaskSubmenu()
        {

            //Models.Task newTask = new Models.Task();


            //Console.Write("Task ID: ");
            //newTask.TaskId = Console.ReadLine();
            //do
            //{
            //    Console.Write("Task ID: ");
            //    id = Console.ReadLine();

            //} while (string.IsNullOrEmpty(newTask.TaskId));

            //Console.WriteLine("TaskName: ");
            //newTask.TaskName = Console.ReadLine();

            //Console.Write("Date of registering now...");
            //newTask.DateOfCreation = DateTime.UtcNow;
            //Console.WriteLine(newTask.DateOfCreation.ToShortDateString());

            //Console.WriteLine("Description:");
            //newTask.Description = Console.ReadLine();

            //if (string.IsNullOrEmpty(newTask.Description))
            //{
            //    Console.WriteLine("Are you sure you want to let description blank? (y/n): ");

            //    ConsoleKeyInfo key = Console.ReadKey(true);

            //    switch (key.Key)
            //    {
            //        case ConsoleKey.N:
            //            //repeat alrorithm
            //            break;
            //        case ConsoleKey.Y:
            //        default:
            //            break;
            //    }
            //}    
        }


        private Models.Task GetTaskById()
        {
            Console.Write("Insert ID: ");
            string id = Console.ReadLine();

            do
            {
                Console.Clear();

                Console.Write("Insert ID: ");
                id = Console.ReadLine();

            } while (string.IsNullOrEmpty(id));



            Models.Task task = TasksMockDatabase.Tasks.FirstOrDefault(t => t.TaskId == id);

            //if(Stru)
            //{
            //    Console.WriteLine("Sorry :(. No task has been found...Try one more time.");
            //    Thread.Sleep(1000);
            //    WriteTaskMainMenu();
            //}

            return task;
        }

        public void Back()
        {
            //mainMenu.WriteToConsole();
        }
    }
}
