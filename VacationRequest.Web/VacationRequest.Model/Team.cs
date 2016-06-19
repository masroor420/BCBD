using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationRequest.Model
{
   public class Team
    {
        /// <summary>
        /// the unique identifier for team entities
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// ManagerId
        /// </summary>
        public int ManagerId { get; set; }

        /// <summary>
        /// Manager
        /// </summary>
        public Employee Manager { get; set; }

        /// <summary>
        /// Employees
        /// </summary>
        public ICollection<Employee> Employees { get; set; }
    }
}
