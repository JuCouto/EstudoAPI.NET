using Microsoft.EntityFrameworkCore;
using teste.Entities;

namespace teste.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        { 
        
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
