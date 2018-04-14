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
            Student result = DbProvider.GetStudent(id);
            return View(result);
        }

        public ActionResult Edit(int id)
        {
            Student result = DbProvider.GetStudent(id);
            return View(result);
        }

        public ActionResult Edit2(int id)
        {
            Student result = DbProvider.GetStudent(id);
            return View(result);
        }

        //an API to show students details
        public ActionResult StudentsData()
        {
            var students = DbProvider.GetStudents();
            var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(students);
            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Playground()
        {
            return View();
        }
    }
}