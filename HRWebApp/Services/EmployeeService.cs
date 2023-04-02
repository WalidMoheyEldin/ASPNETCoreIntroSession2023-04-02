using HRWebApp.Models;

namespace HRWebApp.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }

    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Employee { Name = $"Employee {i}", Salary = i * 1000 });
            }

            return employees;
        }
    }
}
