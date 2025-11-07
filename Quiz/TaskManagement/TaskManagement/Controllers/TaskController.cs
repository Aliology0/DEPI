using Microsoft.AspNetCore.Mvc;
using TaskManagement.Core.Interfaces;
using Core.Models;

namespace TaskManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] bool? isCompleted = null, [FromQuery] bool sortByDueDateAsc = true)
        {
            var tasks = await _taskRepository.GetAllAsync(isCompleted, sortByDueDateAsc);
            return Ok(tasks);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var task = await _taskRepository.GetByIdAsync(id);
            if (task == null)
                return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TaskItem task)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _taskRepository.CreateAsync(task);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TaskItem task)
        {
            if (id != task.Id)
                return BadRequest("Task ID mismatch.");

            var exists = await _taskRepository.ExistsAsync(id);
            if (!exists)
                return NotFound();

            var updated = await _taskRepository.UpdateAsync(task);
            if (updated == null)
                return StatusCode(500, "Failed to update task.");

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = await _taskRepository.ExistsAsync(id);
            if (!exists)
                return NotFound();

            var deleted = await _taskRepository.DeleteAsync(id);
            if (!deleted)
                return StatusCode(500, "Failed to delete task.");

            return NoContent();
        }
    }
}
