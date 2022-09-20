using CSharp_Basics_HW.Models;

namespace CSharp_Basics_HW
{
    internal static class TasksMockDatabase
    {
        static List<Models.Task> tasks = new List<Models.Task>();

        public static List<Models.Task> Tasks { get => tasks; }

        public static void AddnewNewtask(Models.Task newTask) => tasks.Add(newTask);
        public static Models.Task FindTaskById(string taskId) => tasks.FirstOrDefault(t => t.TaskId == taskId);

        //public void AssignTask(string taskId, Employee empl)
        //{

        //}       
    }
}
