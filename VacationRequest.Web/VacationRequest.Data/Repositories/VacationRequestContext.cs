using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacationRequest.Model;

namespace VacationRequest.Data.Repositories
{
    public class VacationRequestContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public VacationRequestContext()
            : base("VacationRequestDB")
        {            
        }

        /// <summary>
        /// Employee Collection
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// VacationRequest Collection
        /// </summary>
        public DbSet<RequestVacation> VacationRequests { get; set; }

        /// <summary>
        /// Team Collection
        /// </summary>
        public DbSet<Team> Teams { get; set; }


    }
}
