using System.Collections.Generic;
using angular_coelsa_example.Models;
using Microsoft.AspNetCore.Mvc;

namespace angular_coelsa_example.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        private readonly ItemContext _context;

        public ToDoController(ItemContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.ToDo);
        }

        [HttpGet("{id}")]
        public IActionResult GetBy(int id)
        {
            ToDo item = _context.ToDo.Find(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Add([FromBody] ToDo model)
        {
            _context.ToDo.Add(model);
            _context.SaveChanges();

            return CreatedAtRoute("GetBy", new { id = model.Id }, model);
        }
    }
}