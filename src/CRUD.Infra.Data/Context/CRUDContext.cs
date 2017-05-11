using System.Data.Entity;
using CRUD.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using CRUD.Infra.Data.EntityConfig;

namespace CRUD.Infra.Data.Context
{
    public class CRUDContext : DbContext        
    {
        public CRUDContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }

        // This method is executed during database creation
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClientConfig());
            modelBuilder.Configurations.Add(new AddressConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
