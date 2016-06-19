using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VacationRequest.Model
{
    public class Employee
    {
        /// <summary>
        /// the unique identifier 
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// JobTitle
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Team
        /// </summary>
        public Team Team { get; set; }

        /// <summary>
        /// ManagedT eams
        /// </summary>
        public ICollection<Team> ManagedTeams { get; set; }


        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is manager; otherwise, <c>false</c>.
        /// </value>
        public bool IsManager { get { return ManagedTeams != null && ManagedTeams.Any(); } }

    }
}
