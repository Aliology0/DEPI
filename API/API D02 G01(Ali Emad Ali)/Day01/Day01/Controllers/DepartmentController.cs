using Day01.DTOs;
using Day01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly CourseContext _context;

        public DepartmentController(CourseContext context)
        {
            _context = context;
        }

        // GET: api/department (custom serialization)
        [HttpGet("custom")]
        public async Task<IActionResult> GetWithSerialization()
        {
            var departments = await _context.Departments
                .Include(d => d.Courses)
                .Select(d => new
                {
                    d.Name,
                    NumberOfCourses = d.Courses.Count
                })
                .ToListAsync();

            return Ok(departments);
        }

        // GET: api/department/dto (DTO)
        [HttpGet("dto")]
        public async Task<IActionResult> GetWithDTO()
        {
            var departments = await _context.Departments
                .Include(d => d.Courses)
                .Select(d => new DepartmentCoursesDTO
                {
                    DepartmentName = d.Name,
                    NumberOfCourses = d.Courses.Count
                })
                .ToListAsync();

            return Ok(departments);
        }
    }
}
