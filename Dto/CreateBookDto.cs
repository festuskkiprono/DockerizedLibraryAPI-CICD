namespace LibraryManagement.Dto
{
    public class CreateBookDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int PublicationYear { get; set; }
        public string Genre { get; set; } = string.Empty;

        public int AuthorId { get; set; }
    }
}
