using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacationRequest.Model;

namespace VacationRequest.Data.Repositories
{
    public class EmployeeRepository
    {
        private readonly VacationRequestContext _context;

        public EmployeeRepository(VacationRequestContext   context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

               _context = context;

        }


        /// <summary>
        /// Get Emloyee by ID
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Employee Get(int employeeId)
        {
            return _context.Employees             
                .SingleOrDefault(q => q.EmployeeId == employeeId);
        }


        public Employee GetByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        // Crud Operation need go here too. 
    }
}
