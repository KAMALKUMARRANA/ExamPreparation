using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using EFCoreTutorials.Data;
using EFCoreTutorials.Models.Repository;
using EFCoreTutorials.Models;

namespace EFCoreTutorials.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly DataBaseContext _context;
        private readonly IEmployeeRepository employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository )
        {
            this.employeeRepository = employeeRepository;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            try { return Ok(await employeeRepository.GetEmployee()); }

            catch(Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
        }
         
        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            return await employeeRepository.GetEmployeeById(id);
        }
        [HttpGet("{search}")]
        public async Task<ActionResult<Employee>> Search(string name,Gender? gender)
        {
            try
            {
              var result=await  employeeRepository.Search(name, gender);
                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, UpdatedEmployee updatedEmployee)
        {

            return Ok(await  employeeRepository.UpdateEmployee(id, updatedEmployee));   
           
        }

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)

        {
            /*var emp=employeeRepository.GetEmployeeByEmail(employee.Email);
            if(emp != null)
            {
                ModelState.AddModelError("email", "Email already in use!");
            }*/

           return await employeeRepository.AddEmployee(employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            return Ok(await employeeRepository.DeleteEmployee(id));
        }

       /* private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }*/
    }
}
