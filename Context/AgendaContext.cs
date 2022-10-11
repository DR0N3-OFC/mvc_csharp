using Microsoft.EntityFrameworkCore;
using mvc_csharp.Models;

namespace mvc_csharp.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}