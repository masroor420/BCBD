using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacationRequest.Model;

namespace VacationRequest.Data.Repositories
{
    public class TeamRepository
    {
        private readonly VacationRequestContext _context;

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="context">the context dependency</param>
        public TeamRepository(VacationRequestContext context)
        {          
            _context = context;
        }

      /// <summary>
      /// Get one 
      /// </summary>
      /// <param name="teamId"></param>
      /// <returns></returns>
        public Team Get(int teamId)
        {
            return _context.Teams.SingleOrDefault(q => q.TeamId == teamId);
        }

        // All other queries including Crud Operation will go here.
    }
}
