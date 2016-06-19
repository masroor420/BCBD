using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationRequest.Model
{
    /// <summary>
    ///  Request Status
    /// </summary>
    public enum RequestStatus
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Pending
        /// </summary>
        Pending = 1,
        /// <summary>
        /// Approved
        /// </summary>
        Approved = 2,
        /// <summary>
        /// Denied
        /// </summary>
        Denied = 3
    }
}
