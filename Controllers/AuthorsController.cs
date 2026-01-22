using LibraryManagement.Data;
using LibraryManagement.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagement.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _context.Authors.ToList();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorById([FromRoute] int id)
        {
            var author = _context.Authors.Find(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        [HttpPost]
        public IActionResult CreateAuthor([FromBody] Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAuthorById), new { id = author.Id }, author);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor([FromRoute] int id)
        {
            var author = _context.Authors.Find(id);
            if (author == null)
            {
                return NotFound();
            }
            _context.Authors.Remove(author);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
