using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F18_MVCSchoolApp.Models
{
    public abstract class Person
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Student's nice name")]
        public string Name { get; set; }
        [DisplayName("Student's long email")]
        public string Email { get; set; }
        [DisplayName("Student's fancy address")]
        public string Address { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public int Mobile { get; set; }
    }
}