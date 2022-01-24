using Microsoft.EntityFrameworkCore;

namespace MyTrails.Models
{
  public class MyTrailsContext : DbContext
  {
    public MyTrailsContext(DbContextOptions<MyTrailsContext> options) : base(options)
    {

    }

    public DbSet<Trail> Trails { get; set; }
  }
}