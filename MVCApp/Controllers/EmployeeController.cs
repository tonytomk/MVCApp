using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class EmployeeController : Controller
    {

        //// GET: Employee
        //public ActionResult Index()
        //{
        //    using (EmployeeContext employee = new EmployeeContext())
        //    {
        //        List<Employee> empl = employee.Employees.ToList();
        //        return View(empl);
        //    }

        //}

        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();

            return View(employees);
        }


        // GET: Employee
        public ActionResult Details(int id)
        {
            using (EmployeeContext employee=new EmployeeContext())
            {
                Employee empl= employee.Employees.Single(x=> x.EmployeeId==id);
                return View(empl);
            }
           
        }
    }
}