using HRWebApp.Models;
using HRWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRWebApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IActionResult Index()
        {
            IList<Employee> employees = employeeService.GetEmployees();
            return View(employees);
        }
    }
}
