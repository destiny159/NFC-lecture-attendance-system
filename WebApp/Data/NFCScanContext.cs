using Microsoft.EntityFrameworkCore;
using NFCSystem.Models;

namespace NFCSystem.Data
{
    public class NFCScanContext: DbContext
    {
        public NFCScanContext(DbContextOptions<NFCScanContext> options): base(options)
        {

        }

        public DbSet<NFCScan> NFCScans {get;set;}
    }
}