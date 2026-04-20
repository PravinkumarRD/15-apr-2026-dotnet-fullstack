using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers;

public class EmployeesController : Controller
{
    private readonly List<Employee> _employees;
    public EmployeesController()
    {
        _employees = new List<Employee>()
        {
            new Employee(){EmployeeId=101,EmployeeName="Ravi Kumar",City="Bangalore"},
            new Employee(){EmployeeId=102,EmployeeName="Suresh Reddy",City="Hyderabad"},
            new Employee(){EmployeeId=103,EmployeeName="Anil Kumar",City="Pune"},
            new Employee(){EmployeeId=104,EmployeeName="Sunil Kumar",City="Chennai"},
            new Employee(){EmployeeId=105,EmployeeName="Vijay Kumar",City="Mumbai"}
        };
    }
    public IActionResult Index()
    {
        return Content("<h1>Welcome To Bajaj Employees List Controller!</h1><hr/><h6>Core ODC! Bangalore!</h6>", "text/html");
    }
    public IActionResult CssFile()
    {
        return File("~/css/site.css", "text/css");
    }
    public IActionResult Data()
    {
        return Json(_employees);
    }
    public IActionResult JoiningRules()
    {
        return View("JoinRules");
    }
    public IActionResult List()
    {
        return View(_employees);
    }
}
