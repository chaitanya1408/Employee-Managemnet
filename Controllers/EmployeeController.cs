using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBL employeeBL;
        public EmployeeController(IEmployeeBL employeeBusiL)
        {
            employeeBL = employeeBusiL;
        }
        [HttpGet]
        public List<Employee> GetAllEmployee()
        {
            var result = employeeBL.GetAllEmployee();
            return result;
        }
        // GET api/employee/2
        [HttpGet]
        [Route("{id}")]
        public Employee GetEmployeeInformation(int id)
        {
            var result = employeeBL.GetEmployeeInfo(id);
            return result;
        }

        [HttpPost]
        public Employee AddEmployee(Employee employee)
        {

            var result = employeeBL.AddEmployee(employee);
            return result;
        }
        [HttpDelete]
        [Route("{id}")]
        public void DeleteEmployee(int id)
        {
            employeeBL.DeletEmployee(id);
        }

        [HttpPut]

        public Employee UpdateEmployee(Employee employee)
        {
            var result = employeeBL.UpdateEmployee(employee);
            return result;
        }
    }
}