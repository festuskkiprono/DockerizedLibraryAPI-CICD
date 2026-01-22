namespace LibraryManagement.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; } = string.Empty;

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
