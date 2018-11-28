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

            return Ok();
            // return CreatedAtRoute("GetBy", new { id = model.Id }, model);
        }

        [HttpPatch]
        public IActionResult PartialUpdate([FromBody] ToDo model)
        {
            ToDo item = _context.ToDo.Find(model.Id);
            if (item == null) return NotFound();

            item.Description = model.Description;

            _context.ToDo.Update(item);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ToDo item = _context.ToDo.Find(id);
            if (item == null) return NotFound();

            _context.ToDo.Remove(item);
            _context.SaveChanges();

            return Ok();
        }
    }
}