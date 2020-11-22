using DotNetCoreRepository.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreRepository.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> Add(Employee employee);

        Task<Employee> Delete(int Id);

        Task<IEnumerable<Employee>> GetAllEmployee();

        Task<Employee> GetEmployee(int Id);

        Task<Employee> Update(Employee employeeChanges);
    }
}
