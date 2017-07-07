﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollTest.Presentation.Web.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string GlobalId { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string NIC { get; set; }
        public int Mobile { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MaritalStatus { get; set; }

        public virtual ICollection<Employee> Emloyee { get; set; }
        public virtual ICollection<SystemUser> SystemUser { get; set; }
        public virtual Systems System { get; set; }
    }
}