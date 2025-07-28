using Microsoft.EntityFrameworkCore;

namespace TrangQuanTri_BanSach.Models.Domain
{
  public class DatabaseContext : DbContext
  {
    // ctor (gõ code nhanh)
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
      
    }

    public DbSet<Author> Author { get; set; }
    public DbSet<Book> Book { get; set; }
    public DbSet<Genre> Genre { get; set; }
    public DbSet<Publisher> Publisher { get; set; }

  }
}
