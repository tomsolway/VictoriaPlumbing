using Microsoft.EntityFrameworkCore;

namespace VictoriaPlumbing.Domain.Models
{
    public class VictoriaPlumbingContext : DbContext
    {
        public VictoriaPlumbingContext(DbContextOptions<VictoriaPlumbingContext> options)
            : base(options)
        {
        }

        public DbSet<Order> CustomerOrder{ get; set; }
    }
}
