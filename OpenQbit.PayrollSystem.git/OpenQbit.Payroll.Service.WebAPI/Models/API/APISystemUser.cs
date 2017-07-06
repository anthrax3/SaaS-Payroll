using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Payroll.Service.WebAPI.Models.API
{
    public class APISystemUser
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public int SystemId { get; set; }
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
    }
}