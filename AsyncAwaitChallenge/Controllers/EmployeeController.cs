using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncAwaitChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoAPI.Controllers
{
           
    // Change all the Controller methods for Supporting and Usage of async and await keyword
    // Use Task.Fromresult method to return the Data 
    [ApiController]
    public class EmployeeController : Controller
    {
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            logger.LogInformation("Created");
        }

        [HttpGet]
        [Route("api/employees/employee/{id}")]
        public ActionResult<EmployeeData> GetByID(int id)
        {
            var employee = new EmployeeData()
            {
                ID = id,
                FirstName = "Test",
                LastName = "Test1",
                DateOfBirth = DateTime.Now.AddYears(-30)
            };

            return Ok(employee);
        }

        [HttpGet]
        [Route("api/getallemployees")]
        public ActionResult<List<EmployeeData>> GetEmployees()
        {
            var employees = new List<EmployeeData>()
            {
                new EmployeeData()
                {
                    ID = 1,
                    FirstName = "First Name",
                    LastName = "Last Name",
                    DateOfBirth = DateTime.Now.AddYears(-30)
                },
                new EmployeeData()
                {
                    ID = 2,
                    FirstName = "First Name",
                    LastName = "Last Name",
                    DateOfBirth = DateTime.Now.AddYears(-37)
                },
                new EmployeeData()
                {
                    ID = 3,
                    FirstName = "First Name",
                    LastName = "Last Name",
                    DateOfBirth = DateTime.Now.AddYears(-3)
                },
                 new EmployeeData()
                {
                    ID = 3,
                    FirstName = "First Name",
                    LastName = "Last Name",
                    DateOfBirth = DateTime.Now.AddYears(-1)
                }
            };


            return Ok(employees);
        }
    }
}

