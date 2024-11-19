using Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
