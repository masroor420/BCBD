using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Http.OData;
using VacationRequest.Data.Repositories;
using VacationRequest.Model;

namespace VacationRequest.Web.Controllers
{
    public class EmployeesDataController : EntitySetController<Employee, int>
    {
        private readonly VacationRequestContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public EmployeesDataController(VacationRequestContext context)
        {
            _context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IQueryable<Employee> Get()
        {
            var queryOptions = this.QueryOptions;
            IQueryable<Employee> employees = _context.
                Employees
                .AsQueryable();

            queryOptions.ApplyTo(employees);
            return employees.AsQueryable();
        }
    }
}