using MTech.Data;
using MTech.Models;
using MTech.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace MTech.Controllers
{
    // API Controller for managing Employee entities.
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeesDbContext _context;

        public EmployeesController(EmployeesDbContext context)
        {
            _context = context;
        }
        // POST: Adds a new employee, validating RFC format and uniqueness
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (!RfcValidator.IsValid(employee.RFC))
                return BadRequest("Invalid RFC format.");

            if (_context.Employees.Any(e => e.RFC == employee.RFC))
                return Conflict("Employee with this RFC already exists.");

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }
        // GET: Retrieves employees, optionally filtering by name, sorted by birthdate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get([FromQuery] string? name)
        {
            var query = _context.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(name))
                query = query.Where(e => e.Name.Contains(name));

            var result = await query
                .OrderBy(e => e.BornDate)
                .ToListAsync();

            return Ok(result);
        }
    }
}
