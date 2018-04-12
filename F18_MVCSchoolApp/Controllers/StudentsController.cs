using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using F18_MVCSchoolApp.Models;

namespace F18_MVCSchoolApp.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            //Get the list of the Students from the DB
            var result = DbProvider.GetStudents();
            //return the list to the View
            return View(result);
        }

        public ActionResult Student(int id)
        {
            // TODO
            // replace the Student result with DbProvider.GetStudent(id)
            Student result = new Student()
            {
                Id = id,
                Name = "John Doe",
                Address = "Somestreet 1",
                City = "Odense",
                Email = "student@eal.dk",
                Zip = 5000,
                Mobile = 12345678 * id
            };
            return View(result);
        }
    }
}