using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using VacationRequest.Data.Repositories;
using VacationRequest.Model;

namespace VacationRequest.Web.Controllers
{
    public class VacationRequestController : ApiController
    {
        /// <summary>
        /// These should be Interfaces. That I haven't created....
        /// </summary>
        private readonly VacationRequestRepository _vacationRequestRepository = null;
        private readonly EmployeeRepository _employeeRepository = null;
        


        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        [Route("{year:int}")]
        public async Task<IEnumerable<RequestVacation>> GetUserVacationRequests(int year)
        {
            throw new NotImplementedException();
        }
    }
}
