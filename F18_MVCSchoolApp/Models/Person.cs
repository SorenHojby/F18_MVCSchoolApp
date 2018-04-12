﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace F18_MVCSchoolApp.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public int Mobile { get; set; }
    }
}