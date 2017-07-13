using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using System.Threading.Tasks;
using PayrollTest.Presentation.Web.Models;
using System.Web.Script.Serialization;

namespace PayrollTest.Presentation.Web.WebAPI
{
    public class WebClient
    {
        private HttpClient _client;

        private JavaScriptSerializer _jsonSerializer = new JavaScriptSerializer();


        public WebClient()
        {
            _client = new HttpClient();
        }

        public async Task<Advance> GetAdvance()
        {
            Advance advance = new Advance();

            using (var response = await _client.GetAsync(" http://localhost:55882/API/Advance/GetAdvance"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    advance = _jsonSerializer.Deserialize<Advance>(jsonString);
                }
            }

            return advance;
        }
        public async Task<Attendance> GetAttendance()
        {
            Attendance attendance = new Attendance();

            using (var response = await _client.GetAsync(" http://localhost:55882/API/Attendance/GetAttendance"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    attendance = _jsonSerializer.Deserialize<Attendance>(jsonString);
                }
            }

            return attendance;
        }
        public async Task<Bank> GetBank()
        {
            Bank bank = new Bank();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Bank/GetBank"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    bank = _jsonSerializer.Deserialize<Bank>(jsonString);
                }
            }

            return bank;
        }
        public async Task<Bonus> GetBonus()
        {
            Bonus bonus = new Bonus();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Bonus/GetBonus"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    bonus = _jsonSerializer.Deserialize<Bonus>(jsonString);
                }
            }

            return bonus;
        }
        public async Task<BonusType> GetBonusType()
        {
            BonusType bonusType = new BonusType();

            using (var response = await _client.GetAsync("http://localhost:55882/API/BonusType/GetBonusType"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    bonusType = _jsonSerializer.Deserialize<BonusType>(jsonString);
                }
            }

            return bonusType;
        }

        public async Task<Customer> GetCustomer()
        {
            Customer customer = new Customer();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Customer/GetCustomer"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    customer = _jsonSerializer.Deserialize<Customer>(jsonString);
                }
            }

            return customer;
        }

        public async Task<Deduction> GetDeduction()
        {
            Deduction deduction = new Deduction();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Deduction/GetDeduction"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    deduction = _jsonSerializer.Deserialize<Deduction>(jsonString);
                }
            }

            return deduction;
        }

        public async Task<Department> GetDepartment()
        {
            Department department = new Department();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Department/GetDepartment"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    department = _jsonSerializer.Deserialize<Department>(jsonString);
                }
            }

            return department;
        }

        public async Task<Employee> GetEmployee()
        {
            Employee employee = new Employee();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Employee/GetEmployee"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    employee = _jsonSerializer.Deserialize<Employee>(jsonString);
                }
            }

            return employee;
        }

        public async Task<Grade> GetGrade()
        {
            Grade grade = new Grade();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Grade/GetGrade"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    grade = _jsonSerializer.Deserialize<Grade>(jsonString);
                }
            }

            return grade;
        }
        public async Task<Leaves> GetLeaves()
        {
            Leaves leaves = new Leaves();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Leaves/GetLeaves"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    leaves = _jsonSerializer.Deserialize<Leaves>(jsonString);
                }
            }

            return leaves;
        }

        public async Task<Loan> GetLoan()
        {
            Loan loan = new Loan();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Loan/GetLoan"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    loan = _jsonSerializer.Deserialize<Loan>(jsonString);
                }
            }

            return loan;
        }

        public async Task<Person> GetPerson()
        {
            Person person = new Person();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Person/GetPerson"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    person = _jsonSerializer.Deserialize<Person>(jsonString);
                }
            }

            return person;
        }

        public async Task<Role> GetRole()
        {
            Role role = new Role();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Role/GetRole"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    role = _jsonSerializer.Deserialize<Role>(jsonString);
                }
            }

            return role;
        }

        public async Task<Salary> GetSalary()
        {
            Salary salary = new Salary();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Salary/GetSalary"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    salary = _jsonSerializer.Deserialize<Salary>(jsonString);
                }
            }

            return salary;
        }

        public async Task<Systems> GetSystems()
        {
            Systems systems = new Systems();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Systems/GetSystems"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    systems = _jsonSerializer.Deserialize<Systems>(jsonString);
                }
            }

            return systems;
        }

        public async Task<SystemUser> GetSystemUser()
        {
            SystemUser systemUser = new SystemUser();

            using (var response = await _client.GetAsync("http://localhost:55882/API/SystemUser/GetSystemUser"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    systemUser = _jsonSerializer.Deserialize<SystemUser>(jsonString);
                }
            }

            return systemUser;
        }


    }
}