using DotNetCoreRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRepository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> Add(Employee employee)
        {
            employee.Id = _context.Employees.Max(e => e.Id) + 1;
            await _context.Employees.AddAsync(employee);
            return employee;
        }

        public async Task<Employee> Delete(int Id)
        {
            Employee employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == Id);
            if (employee != null)
            {
                 _context.Employees.Remove(employee);
            }
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await  _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> Update(Employee employeeChanges)
        {
            Employee employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                // employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
