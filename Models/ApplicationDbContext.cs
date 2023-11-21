using Microsoft.EntityFrameworkCore;

namespace SignalRTest.Models
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<tblMes> tblMes { get; set; }
    }
}
