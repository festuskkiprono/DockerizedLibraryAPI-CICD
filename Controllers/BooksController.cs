using LibraryManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Dto;
using LibraryManagement.Mapper;

namespace LibraryManagement.Controllers
{
    [Route("api/books")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _context.Books.ToList();
            return Ok(books);
        }
        [HttpGet("{id}")]
        public IActionResult GetBookById([FromRoute] int id)
        {
            //model binding to extract the string, parse it into int and pass it to the Find
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            var bookDto = BookMapper.MapToDto(book);
            return Ok(bookDto);
        }
        [HttpPost]
        public IActionResult CreateBook([FromBody] CreateBookDto createBookDto)
        {
            var book = BookMapper.MapToEntity(createBookDto); 

            _context.Books.Add(book);
            _context.SaveChanges();
            var bookDto = BookMapper.MapToDto(book);
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, bookDto);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
