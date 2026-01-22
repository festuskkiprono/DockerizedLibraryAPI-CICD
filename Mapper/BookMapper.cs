using LibraryManagement.Entities;
using LibraryManagement.Dto;
namespace LibraryManagement.Mapper
{
    public class BookMapper
    {
        public static Book MapToEntity(CreateBookDto dto)
        {
            return new Book
            {
                Title = dto.Title,
                Description = dto.Description,
                PublicationYear = dto.PublicationYear,
                Genre = dto.Genre,
                AuthorId = dto.AuthorId
            };
        }
        public static CreateBookDto MapToDto(Book book)
        {
            return new CreateBookDto
            {
                Title = book.Title,
                Description = book.Description,
                PublicationYear = book.PublicationYear,
                Genre = book.Genre,
                AuthorId = book.AuthorId ?? 0
            };
        }
    }
}
