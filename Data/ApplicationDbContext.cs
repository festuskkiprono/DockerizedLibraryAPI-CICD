using Microsoft.EntityFrameworkCore;
using LibraryManagement.Entities;

namespace LibraryManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }
        //ApplicationDbContext: Allows us to access the tables in the database.
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
