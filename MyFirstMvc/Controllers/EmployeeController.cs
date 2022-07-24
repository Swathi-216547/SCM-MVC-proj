using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMvc.Models;

namespace MyFirstMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeInfo()
        { 
            Employee employee= new Employee()
        {
            EmployeeId = 216547,
            EmployeeName = "Swathi",
            EmployeeLocation = "Bangalore"
        };
                return View(employee);
        }
    }
}