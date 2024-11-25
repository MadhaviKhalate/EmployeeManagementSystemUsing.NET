using System.Collections.Generic;
using System.Threading.Tasks;
using EmpMgmtSystem.Models;

namespace EmpMgmtSystem.Data.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);

    }
}
