using CSharp_Basics_HW.Models;

namespace CSharp_Basics_HW
{
    internal static class TasksMockDatabase
    {
        static List<Models.Task> tasks = new List<Models.Task>();

        //public  TasksMockDatabase()
        //{
        //    tasks = new List<Models.Task>();
        //}

        //public TasksMockDatabase(Models.Task newTask)
        //{
        //    tasks = new List<Models.Task>() { newTask };
        //}

        public static List<Models.Task> Tasks
        {
            get => tasks;
        }


        public static void CreateNewtask()
        {
            tasks.Add(new Models.Task());
        }



        public Models.Task FindTaskById(string taskId)
        {
            Models.Task task = tasks.FirstOrDefault(t => t.TaskId == taskId);

            return task;
        }

        public void AssignTask(string taskId, Employee empl)
        {

        }       
    }
}
