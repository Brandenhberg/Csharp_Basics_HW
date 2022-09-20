using CSharp_Basics_HW.Models;



namespace CSharp_Basics_HW
{
    internal static class EmployeesMockDatabase
    {

        private static List<Employee> employees = new List<Employee>();
        public static List<Employee> Employees { get => employees; }

        public static void AddNewEmployee(Employee newEmployee) => employees.Add(newEmployee);

        public static IEnumerable<Models.Task> TasksOfSelectedEmployee(string nickname)
        {
            Employee empl = employees.First(e => e.Nickname == nickname);

            return empl.AllTasks;
        }


        //TODO MODIFY EMPLOYEE
    }
}
