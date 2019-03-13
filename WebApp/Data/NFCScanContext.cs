using Microsoft.EntityFrameworkCore;
using NFCSystem.Models;

namespace NFCSystem.Data
{
    public class NFCScanContext: DbContext
    {
        public NFCScanContext(DbContextOptions<NFCScanContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            base.OnModelCreating(builder);
        }

        public DbSet<NFCScan> NFCScans {get;set;}
    }
}