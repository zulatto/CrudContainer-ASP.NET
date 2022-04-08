using ContainerCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ContainerCRUD.Data
{
    public class CntrContext : DbContext
    {
        public CntrContext(DbContextOptions<CntrContext> options)
            : base (options)
        { 

        }

        public DbSet<Container> Container { get; set; }
    }
}
