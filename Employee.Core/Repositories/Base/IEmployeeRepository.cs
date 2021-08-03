using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories.Base
{
    public interface IEmployeeRepository : IRepository<Employee.Core.Entities.Employee>
    {
        // custom operations here
        Task<IEnumerable<Employee.Core.Entities.Employee>> GetEmployeesByLastName(string lastname);
        
    }
}
