using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext: DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
    }
}