using Day01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly CourseContext _context;

        public CourseController(CourseContext context)
        {
            _context = context;
        }

        // GET: api/course
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var courses = await _context.Courses.ToListAsync();
            if (!courses.Any())
                return NotFound();
            return Ok(courses);
        }

        // GET: api/course/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // GET: api/course/byname/{name}
        [HttpGet("byname/{name}")]
        public async Task<IActionResult> CourseByName(string name)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Crs_name == name);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST: api/course
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Course course)
        {
            if (course == null)
                return BadRequest();

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // PUT: api/course/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Course course)
        {
            if (id != course.ID)
                return BadRequest();

            var existingCourse = await _context.Courses.FindAsync(id);
            if (existingCourse == null)
                return NotFound();

            existingCourse.Crs_name = course.Crs_name;
            existingCourse.crs_desc = course.crs_desc;
            existingCourse.Duration = course.Duration;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/course/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
                return NotFound();

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            var courses = await _context.Courses.ToListAsync();
            return Ok(courses);
        }
    }
}
