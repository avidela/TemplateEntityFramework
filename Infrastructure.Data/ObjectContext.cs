using System.Data.Entity;
using Domain;

namespace Infrastructure.Data
{
    public class ObjectContext:DbContext
    {
        public ObjectContext()
            :base("ConnectionStringName")
        {
        }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Proyect> Proyects { get; set; }
    }
}
