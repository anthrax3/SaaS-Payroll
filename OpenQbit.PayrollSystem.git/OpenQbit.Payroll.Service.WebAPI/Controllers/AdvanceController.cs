using OpenQbit.Payroll.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.Payroll.BLL.BusinessService.Contracts;
using OpenQbit.Payroll.BLL.BusinessService;
using OpenQbit.Payroll.Common.Ioc;

namespace OpenQbit.Payroll.Service.WebAPI.Controllers
{
    [RoutePrefix("api/Advance")]
    public class AdvanceController : ApiController
    {
        private IAdvanceManager _am = UnityResolver.Resolve<IAdvanceManager>();
        [HttpGet]
        public Advance GetAdvance()
        {

            Advance advance = new Advance { Amount = 12, Date = DateTime.Today, Id = 1 };
            return advance;
          //  return _am.FindAdvance(advance);
        }
    }
}
