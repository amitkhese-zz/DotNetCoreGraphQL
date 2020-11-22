using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreRepository.Model;
using DotNetCoreRepository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreGraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository empRepo;
        public EmployeeController(IEmployeeRepository _empRepo)
        {
            empRepo = _empRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Index()
        {
            var emp = await empRepo.GetAllEmployee();
            return emp;
        }
    }
}