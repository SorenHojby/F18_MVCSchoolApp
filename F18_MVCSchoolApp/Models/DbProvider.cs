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
            List<Student> allStudents = new List<Student>();

            //TODO: replace the for-loop and get data from the json
            for(int i = 1; i < 21; i++)
            {
                Student student = new Student()
                {
                    Id = i,
                    Name = "Student Doe-" + i,
                    Email = string.Format("john-{0}@eal.dk", i),
                    Address = "Seeblasgade" + i + " 1",
                    City = "Odense",
                    Zip = 5000,
                    Mobile = 12345678 * i
                };
                allStudents.Add(student);
            }

            return allStudents;
        }

        // TODO
        public static Student GetStudent(int id)
        {
            return new Student();
        }
    }
}