using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.BLL.BusinessService.Contracts;
using OpenQbit.Payroll.Common.Models;
using OpenQbit.Payroll.Common.Utils.Logs;
using OpenQbit.Payroll.DataAccess.DAL.Contracts;

namespace OpenQbit.Payroll.BLL.BusinessService
{
    public class PersonManager : IPersonManager
    {
        private IRepository repository;
        private ILogger logger;

        public PersonManager(IRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public bool RecordPerson(Person person)
        {
            logger.LogError("");
            return repository.Create<Person>(person);
        }

        public bool EditPerson(Person person)
        {
            logger.LogError("");
            return repository.Update<Person>(person);
        }

        public bool RemovePerson(Person person)
        {
            logger.LogError("");
            return repository.Delete<Person>(person);
        }

        public List<Person> GetAllPersons()
        {
            logger.LogError("");
            return repository.GetAll<Person>();
        }

        public Person FindPerson(Person person)
        {
            logger.LogError("");
            return repository.Find<Person>(P => P.Id == person.Id);
        }
    }
}
