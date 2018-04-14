using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace F18_MVCSchoolApp.Models
{
    public static class DbProvider
    {
        public static List<Student> GetStudents()
        {
            //reat the tgext from json file students
            var jsonTxt = System.IO.File.ReadAllText(@"C:\Pba\F18\Projects\F18_MVCSchoolApp\F18_MVCSchoolApp\App_Data\students.json");
            //deserialize the jsonTxt to a List of Students, using Newtonsoft.Json
            var allStudents = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(jsonTxt);
            //return the list of students
            return allStudents;
        }

        // TODO
        public static Student GetStudent(int id)
        {

            return GetStudents().Where(s => s.Id == id).Single();

            /*
            Student studentResult = new Student();
            // get a list of ALL students
            var allStudents = GetStudents();
            //itterate troguh all students
            foreach(var student in allStudents)
            {
                //compare the Student id with the id parameter
                //if they are equal, you found your student
                if(student.Id == id)
                {
                    //return the student
                    studentResult = student;
                }
            }
            return studentResult;
            */
        }
    }
}