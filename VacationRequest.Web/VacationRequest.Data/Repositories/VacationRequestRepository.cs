using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacationRequest.Model;

namespace VacationRequest.Data.Repositories
{
    public class VacationRequestRepository
    {
        private readonly VacationRequestContext _context;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public VacationRequestRepository(VacationRequestContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get one
        /// </summary>
        /// <param name="vacationRequestId"></param>
        /// <returns></returns>
        public RequestVacation Get(int vacationRequestId)
        {
            return _context.VacationRequests               
                .Single(q => q.VacationRequestId == vacationRequestId);
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RequestVacation> GetAll()
        {
            return _context.VacationRequests.ToList();
        }

    }
}
