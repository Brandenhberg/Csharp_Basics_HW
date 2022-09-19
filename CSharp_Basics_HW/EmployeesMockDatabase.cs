using CSharp_Basics_HW.Models;



namespace CSharp_Basics_HW
{
    internal class EmployeesMockDatabase
    {

        private List<Employee> employees;
        public List<Employee> Employees { get => employees; }


        public EmployeesMockDatabase()
        {
            employees = new List<Employee>();
        }

        public EmployeesMockDatabase(Employee newEmployee)
        {
            employees = new List<Employee>() { newEmployee };
        }

        public void AddNewEmployee(Employee newEmployee) => employees.Add(newEmployee);


        public IEnumerable<Models.Task> TasksOfSelectedEmployee(string nickname)
        {
            Employee empl = employees.First(e => e.Nickname == nickname);

            return empl.AllTasks;
        }


        //TODO MODIFY EMPLOYEE
    }
}
